# MouseKeepAlive

Um utilitário simples em C# para manter o computador “ativo” simulando atividade do mouse e evitando que o sistema entre em modo de inatividade ou bloqueio de tela.

Esse projeto foi criado para impedir que o sistema entre em idle ou sleep automaticamente, simulando movimentação do mouse e gerenciando eventos de energia conforme necessário.

## Funcionalidades

- Detecta tempo de inatividade do sistema
- Simula movimento do mouse para manter o sistema ativo
- Gerenciamento de eventos de energia
- Aplicação leve, sem interface gráfica

## Motivação

Alguns sistemas entram em modo de suspensão ou bloqueiam a tela quando não detectam atividade do usuário.

O MouseKeepAlive é útil em cenários como:
- Apresentações longas
- Execução de processos demorados
- Monitoramento contínuo
- Ambientes onde o sistema não pode entrar em idle automaticamente

## Tecnologias Utilizadas

- .NET
- C#
- APIs nativas do Windows
- Console Application

## Estrutura do Projeto

```
MouseKeepAlive/
├── IdleTimeHelper.cs        # Verifica o tempo de inatividade do sistema
├── MouseHelper.cs           # Simula movimentação do mouse
├── PowerHelper.cs           # Gerenciamento de energia
├── Program.cs               # Ponto de entrada da aplicação
├── appsettings.json         # Configurações da aplicação
├── MouseKeepAlive.sln       # Solução .NET
└── MouseKeepAlive.csproj    # Projeto .NET
```

## Como Usar

### Clonar o repositório

```
git clone https://github.com/gabrielf-agostinho/MouseKeepAlive  
cd MouseKeepAlive
```

### Build do projeto

```
dotnet build MouseKeepAlive.sln
```

### Executar

```
dotnet run --project MouseKeepAlive
```

A aplicação começará a monitorar o tempo de inatividade e simular movimentos do mouse conforme necessário.

## Publicação

Para gerar um executável standalone para Windows:

```
dotnet publish -c Release
```

O executável será gerado na pasta bin\Release\net9.0\win-x64.

## Contribuições

Contribuições são bem-vindas.  
Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias, correções ou novas funcionalidades.

## Licença

Este projeto está licenciado sob a licença MIT.
