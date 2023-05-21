using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0 || args[0] == "--help")
        {
            ExibirModoDeUso();
            return;
        }

        string command = args[0];
        switch (command)
        {
            case "tarefa1":
                ExecutarTarefa1();
                break;
            case "tarefa2":
                ExecutarTarefa2();
                break;
            default:
                Console.WriteLine("Parâmetro inválido.");
                ExibirParametrosDisponiveis();
                break;
        }
    }

    static void ExibirModoDeUso()
    {
        Console.WriteLine("Modo de uso:");
        Console.WriteLine("dotnet run [tarefa]");
        Console.WriteLine("Parâmetros disponíveis:");
        Console.WriteLine("- tarefa1: Executa a Tarefa 1");
        Console.WriteLine("  Descrição: Esta tarefa realiza a ação X.");
        Console.WriteLine("- tarefa2: Executa a Tarefa 2");
        Console.WriteLine("  Descrição: Esta tarefa realiza a ação Y.");
    }

    static void ExibirParametrosDisponiveis()
    {
        Console.WriteLine("Parâmetros disponíveis:");
        Console.WriteLine("- tarefa1: Executa a Tarefa 1");
        Console.WriteLine("- tarefa2: Executa a Tarefa 2");
    }

    static void ExecutarTarefa1()
    {
        Console.WriteLine("Executando Tarefa 1...");
    }

    static void ExecutarTarefa2()
    {
        Console.WriteLine("Executando Tarefa 2...");
    }
}
