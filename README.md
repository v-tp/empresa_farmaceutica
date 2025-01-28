# Instruções para instalação:

1. Instalar o Docker Desktop (https://www.docker.com/products/docker-desktop/)
2. No diretório raiz (onde fica localizado o arquivo compose.yaml) rodar o comando docker-compose up -d. Isso irá iniciar o banco de dados MySql e a API.
3. Dentro do diretório /blazor há o arquivo .sln para execução da solução via Visual Studio.
4. É necessário configurar uma variável de ambiente com o par chave-valor: "URL_API" - https://localhost:8082 para que o Front-end consiga se comunicar com a API.
 
