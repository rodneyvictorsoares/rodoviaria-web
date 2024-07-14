# Rodoviaria.WEB

## Descrição

Rodoviaria.WEB é uma aplicação web desenvolvida em ASP.NET Core com Razor Pages e Blazor, criada para ilustar e exemplificar os tópicos das aulas ministradas para o curso de Análise e Desenvolvimento de Sistemas na Disciplina Introdução a Programação WEB.

## Índice

- [Descrição](#descrição)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Funcionalidades](#funcionalidades)
- [Instalação](#instalação)
- [Uso](#uso)
- [Contribuição](#contribuição)
- [Licença](#licença)
- [Contato](#contato)

## Tecnologias Utilizadas

- ASP.NET Core 6
- Razor Pages
- Blazor
- Entity Framework Core
- Bootstrap
- CSS
- Git

## Funcionalidades

- Compra de passagens online
- Visualização de horários de viagens
- Gestão de serviços de viagem
- Redirecionamento HTTPS
- Tratamento de erros

## Instalação

### Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

### Passos

1. Clone o repositório:
    ```bash
    git clone https://github.com/seu-usuario/Rodoviaria.WEB.git
    cd Rodoviaria.WEB
    ```

2. Restaure as dependências do projeto:
    ```bash
    dotnet restore
    ```

3. Configure os certificados HTTPS de desenvolvimento:
    ```bash
    dotnet dev-certs https --trust
    ```

4. Execute a aplicação:
    ```bash
    dotnet run
    ```

## Uso

Após seguir os passos de instalação, a aplicação estará disponível em `https://localhost:5001`. Navegue até a URL no seu navegador para acessar o sistema de rodoviária.

### Navegação Principal

- **Home**: Página inicial com as principais funcionalidades.
- **Viagens**: Visualize horários e destinos de viagens.
- **Compra de Passagem**: Compre suas passagens de forma rápida e segura.

## Contribuição

Contribuições são bem-vindas! Siga os passos abaixo para contribuir:

1. Fork o repositório
2. Crie um branch para sua feature (`git checkout -b feature/nova-feature`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova feature'`)
4. Faça o push para o branch (`git push origin feature/nova-feature`)
5. Abra um Pull Request

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Contato

- **Seu Nome** - ordabelem@hotmail.com
- **GitHub** - rodneyvictorsoares

---

<p align="center">
  <img src="https://img.shields.io/badge/Made_with-ASP.NET_Core-1f425f.svg" alt="Feito com ASP.NET Core">
  <img src="https://img.shields.io/badge/Deployed_on-GitHub_Pages-1f425f.svg" alt="Deploy no GitHub Pages">
</p>

