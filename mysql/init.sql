CREATE DATABASE  IF NOT EXISTS `gestao_produtos` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `gestao_produtos`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: gestao_produtos
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `cpf` varchar(50) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `telefone` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `id_usuario_inclusao` int NOT NULL,
  `dt_inclusao` datetime NOT NULL,
  `id_usuario_exclusao` int DEFAULT NULL,
  `dt_exclusao` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `cliente_ibfk_2` (`id_usuario_exclusao`),
  KEY `cliente_ibfk_1` (`id_usuario_inclusao`),
  CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`id_usuario_inclusao`) REFERENCES `usuario_sistema` (`id`),
  CONSTRAINT `cliente_ibfk_2` FOREIGN KEY (`id_usuario_exclusao`) REFERENCES `usuario_sistema` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `materia_prima`
--

DROP TABLE IF EXISTS `materia_prima`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materia_prima` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `descricao` text,
  `fornecedor` varchar(50) NOT NULL,
  `qtd_estoque` int NOT NULL,
  `dt_validade` datetime NOT NULL,
  `id_usuario_inclusao` int NOT NULL,
  `dt_inclusao` datetime NOT NULL,
  `id_usuario_exclusao` int DEFAULT NULL,
  `dt_exclusao` datetime DEFAULT NULL,
  PRIMARY KEY (`id`,`nome`),
  KEY `materia_prima_ibfk_1` (`id_usuario_inclusao`),
  KEY `materia_prima_ibfk_2` (`id_usuario_exclusao`),
  CONSTRAINT `materia_prima_ibfk_1` FOREIGN KEY (`id_usuario_inclusao`) REFERENCES `usuario_sistema` (`id`),
  CONSTRAINT `materia_prima_ibfk_2` FOREIGN KEY (`id_usuario_exclusao`) REFERENCES `usuario_sistema` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `materia_prima_medicamento`
--

DROP TABLE IF EXISTS `materia_prima_medicamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materia_prima_medicamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_materia_prima` int NOT NULL,
  `id_medicamento` int NOT NULL,
  `id_usuario_inclusao` int NOT NULL,
  `dt_inclusao` datetime NOT NULL,
  `id_usuario_exclusao` int DEFAULT NULL,
  `dt_exclusao` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_materia_prima` (`id_materia_prima`),
  KEY `id_medicamento` (`id_medicamento`),
  KEY `materia_prima_medicamento_ibfk_4` (`id_usuario_exclusao`),
  KEY `materia_prima_medicamento_ibfk_3` (`id_usuario_inclusao`),
  CONSTRAINT `materia_prima_medicamento_ibfk_1` FOREIGN KEY (`id_materia_prima`) REFERENCES `materia_prima` (`id`),
  CONSTRAINT `materia_prima_medicamento_ibfk_2` FOREIGN KEY (`id_medicamento`) REFERENCES `medicamento` (`id`),
  CONSTRAINT `materia_prima_medicamento_ibfk_3` FOREIGN KEY (`id_usuario_inclusao`) REFERENCES `usuario_sistema` (`id`),
  CONSTRAINT `materia_prima_medicamento_ibfk_4` FOREIGN KEY (`id_usuario_exclusao`) REFERENCES `usuario_sistema` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `medicamento`
--

DROP TABLE IF EXISTS `medicamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `descricao` text,
  `valor` decimal(10,0) NOT NULL,
  `qtd_estoque` int NOT NULL,
  `id_usuario_inclusao` int NOT NULL,
  `dt_inclusao` datetime NOT NULL,
  `id_usuario_exclusao` int DEFAULT NULL,
  `dt_exclusao` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `medicamento_ibfk_2` (`id_usuario_exclusao`),
  KEY `medicamento_ibfk_1` (`id_usuario_inclusao`),
  CONSTRAINT `medicamento_ibfk_1` FOREIGN KEY (`id_usuario_inclusao`) REFERENCES `usuario_sistema` (`id`),
  CONSTRAINT `medicamento_ibfk_2` FOREIGN KEY (`id_usuario_exclusao`) REFERENCES `usuario_sistema` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_cliente` int NOT NULL,
  `data_pedido` datetime NOT NULL,
  `valor_total` decimal(10,0) NOT NULL,
  `id_usuario_inclusao` int NOT NULL,
  `dt_inclusao` datetime NOT NULL,
  `id_usuario_exclusao` int DEFAULT NULL,
  `dt_exclusao` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_cliente` (`id_cliente`),
  KEY `pedido_ibfk_3` (`id_usuario_exclusao`),
  KEY `pedido_ibfk_2` (`id_usuario_inclusao`),
  CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id`),
  CONSTRAINT `pedido_ibfk_2` FOREIGN KEY (`id_usuario_inclusao`) REFERENCES `usuario_sistema` (`id`),
  CONSTRAINT `pedido_ibfk_3` FOREIGN KEY (`id_usuario_exclusao`) REFERENCES `usuario_sistema` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pedido_medicamento`
--

DROP TABLE IF EXISTS `pedido_medicamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido_medicamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pedido` int NOT NULL,
  `id_medicamento` int NOT NULL,
  `quantidade_medicamento` int NOT NULL,
  `id_usuario_inclusao` int NOT NULL,
  `dt_inclusao` datetime NOT NULL,
  `id_usuario_exclusao` int DEFAULT NULL,
  `dt_exclusao` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_pedido` (`id_pedido`),
  KEY `id_medicamento` (`id_medicamento`),
  KEY `pedido_medicamento_ibfk_4` (`id_usuario_exclusao`),
  KEY `pedido_medicamento_ibfk_3` (`id_usuario_inclusao`),
  CONSTRAINT `pedido_medicamento_ibfk_1` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id`),
  CONSTRAINT `pedido_medicamento_ibfk_2` FOREIGN KEY (`id_medicamento`) REFERENCES `medicamento` (`id`),
  CONSTRAINT `pedido_medicamento_ibfk_3` FOREIGN KEY (`id_usuario_inclusao`) REFERENCES `usuario_sistema` (`id`),
  CONSTRAINT `pedido_medicamento_ibfk_4` FOREIGN KEY (`id_usuario_exclusao`) REFERENCES `usuario_sistema` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuario_sistema`
--

DROP TABLE IF EXISTS `usuario_sistema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario_sistema` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `id_usuario_inclusao` int NOT NULL,
  `dt_inclusao` datetime NOT NULL,
  `id_usuario_exclusao` int DEFAULT NULL,
  `dt_exclusao` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_usuario_exclusao` (`id_usuario_exclusao`),
  KEY `usuario_sistema_ibfk_1` (`id_usuario_inclusao`),
  CONSTRAINT `usuario_sistema_ibfk_1` FOREIGN KEY (`id_usuario_inclusao`) REFERENCES `usuario_sistema` (`id`),
  CONSTRAINT `usuario_sistema_ibfk_2` FOREIGN KEY (`id_usuario_exclusao`) REFERENCES `usuario_sistema` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

INSERT INTO `usuario_sistema` VALUES (1, 'API Sistema de pedidos', 1, NOW(), NULL, NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-01-27  9:26:05
