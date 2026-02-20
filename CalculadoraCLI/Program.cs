public class CalculadoraCLI
{
    public static void Main(string[] args)
    {

        Console.WriteLine("PROJETO - CALCULADORA CLI");

        Console.WriteLine("Digite o primeiro número:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double b = double.Parse(Console.ReadLine());

        int opcao = 0;

        do
        {
            Console.WriteLine("Selecione a opção desejada.");
            Console.WriteLine("1)Multiplicação\n2)Divisão\n3)Soma\n4)Substração\n5)Novo cálculo\n6)SAIR");
            opcao = int.Parse(Console.ReadLine());


            if (opcao == 6)
            {
                Console.WriteLine("SAINDO DO PROGRAMA...");
            }

            if (opcao == 5)
            {
                Console.WriteLine("SAINDO DO PROGRAMA...");


                Console.WriteLine("Digite o primeiro número:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                b = double.Parse(Console.ReadLine());
            }

            if (opcao == 1)
            {
                Console.WriteLine(multiplicar(a, b));
            }

            if (opcao == 2)
            {
                Console.WriteLine(dividir(a, b));
            }

            if (opcao == 3)
            {
                Console.WriteLine(somar(a, b));
            }
            if (opcao == 4)
            {
                Console.WriteLine(subtrair(a, b));
            }

        } while (opcao != 6);
    }

    public static double somar(double a, double b)
    {
        return (a + b);
    }

    public static double subtrair(double a, double b)
    {
        return (a - b);
    }

    public static double dividir(double a, double b)
    {
        return (a / b);
    }

    public static double multiplicar(double a, double b)
    {
        return (a * b);
    }


}
