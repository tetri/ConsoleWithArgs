# Programa de Linha de Comando

Este é um programa de linha de comando escrito em C# que permite executar diferentes tarefas com base nos parâmetros fornecidos. O programa oferece uma maneira simples e flexível de automatizar a execução de tarefas específicas.

## Requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) instalado.

## Como usar

1. Clone o repositório ou faça o download dos arquivos.
2. Navegue até o diretório raiz do projeto.
3. Abra um terminal ou prompt de comando na pasta do projeto.

### Compilar o código

Execute o seguinte comando para compilar o código:

```shell
dotnet build
```

### Executar o programa

Para executar o programa, utilize o seguinte comando:

```shell
dotnet run [tarefa]
```

Substitua `[tarefa]` pelo nome da tarefa que deseja executar. Existem duas tarefas disponíveis:

- `tarefa1`: Executa a Tarefa 1.
  - Descrição: Esta tarefa realiza a ação X.
- `tarefa2`: Executa a Tarefa 2.
  - Descrição: Esta tarefa realiza a ação Y.

Exemplo de execução da Tarefa 1:

```shell
dotnet run tarefa1
```

Exemplo de execução da Tarefa 2:

```shell
dotnet run tarefa2
```

### Modo de uso

Se você não fornecer nenhum parâmetro ou usar `--help`, o programa exibirá o modo de uso e a lista de parâmetros disponíveis:

```shell
dotnet run --help
```

### Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas (issues) e enviar solicitações de pull (pull requests) para aprimorar este programa.

## Licença

Este programa está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para obter mais informações.
