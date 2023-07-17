# Meu Projeto

#IMPORTANTE:
### PARA UTILIZAR O PROJETO. ACESSE Program.cs DENTRO DO PROJETO E ALTERE A LINHA 19 PARA O IP CORRETO DO SERVIDOR. AO UTILIZAR DOCKER, PODE APONTAR PARA O IPV4 DA SUA MÁQUINA

## Funcionalidades
- Endpoint de sincronização
- Endpoint de consulta individual
- Paginação por usuário
- Paginação por postagem

## Perguntas

### Qual DB foi usado e por quê?
Foi utilizado o MySQL como banco de dados. A escolha do banco de dados depende de vários fatores, como requisitos de desempenho, escalabilidade, suporte e familiaridade. O MySQL é um banco de dados popular e é compatível com o Entity Framework Core, que foi usado no código para acessar e manipular os dados.

### Qual arquitetura e/ou padrões de projeto você seguiu e por quê?
Foi seguida a estrutura básica de um aplicativo Blazor Server com as páginas, serviços e contexto de banco de dados. Essa estrutura fornece uma organização clara do código e separação de responsabilidades, facilitando a manutenção e evolução do projeto.

### Consegue citar alguma outra arquitetura e/ou padrão de projeto que seria interessante usar num cenário de alta performance?
Em um cenário de alta performance, algumas arquiteturas e padrões de projeto interessantes seriam:
- Arquitetura de Microsserviços: Dividir a aplicação em vários microsserviços independentes, cada um responsável por uma funcionalidade específica. Isso permite escalar e manter cada serviço separadamente, garantindo alta disponibilidade e desempenho.
- Padrão de Projeto CQRS (Command Query Responsibility Segregation): Separar as operações de leitura (queries) das operações de escrita (commands), permitindo otimizar cada uma separadamente para atender às necessidades de desempenho.
- Uso de Cache: Implementar estratégias de cache para armazenar dados frequentemente acessados em memória, reduzindo a carga no banco de dados e melhorando a velocidade de resposta.

### Quais princípios do SOLID foram seguidos, quais não e por quê?
Foram seguidos os seguintes princípios do SOLID:
- Princípio da Responsabilidade Única (SRP): Cada classe tem responsabilidade única, como exibir usuário e suas postagens, seguindo o princípio de coesão.
- Princípio da Inversão de Dependência (DIP): Foi utilizado o recurso de injeção de dependência para obter instâncias de classes necessárias, permitindo uma maior flexibilidade e facilidade de substituição de implementações.
- Princípio da Substituição de Liskov (LSP): O modelo de dados é utilizado de forma consistente, respeitando as regras e contratos estabelecidos para sua utilização.
- Princípio da Segregação de Interface (ISP): A chamada para o contexto do banco de dados carrega apenas as interfaces necessárias, evitando dependências desnecessárias.

Não foram mencionados princípios específicos que não foram seguidos.

### Script usado para criar o banco de dados no MySQL
CREATE DATABASE MyDatabase;

CREATE TABLE MyDatabase.Blog (
    id INT PRIMARY KEY,
    title VARCHAR(255),
    content_text TEXT,
    photo_url VARCHAR(255),
    created_at DATETIME,
    updated_at DATETIME,
    user_id INT,
    description VARCHAR(255),
    content_html TEXT,
    category VARCHAR(255)
);
CREATE TABLE MyDatabase.User (
    id INT PRIMARY KEY,
    last_name VARCHAR(255),
    email VARCHAR(255),
    phone VARCHAR(30),
    street VARCHAR(255),
    state VARCHAR(100),
    zipcode VARCHAR(20),
    latitude FLOAT,
    gender VARCHAR(10),
    first_name VARCHAR(255),
    date_of_birth DATETIME,
    job VARCHAR(255),
    city VARCHAR(100),
    country VARCHAR(100),
    longitude FLOAT
);
