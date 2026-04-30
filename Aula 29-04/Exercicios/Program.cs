namespace Exercicios;

class Program
{
    static void Main(string[] args)
    {
       
    //Exercicio 1 - Contagem crescente (for): Mostre na tela os números de 1 até 10.

    //    for(int i = 1; i <=10; i++)
    //    {
    //     Console.WriteLine(i);
    //    }

    //Exercicio 2 - Contagem regressiva (for): Mostre na tela os números de 10 até 1.

    //    for(int i = 10; i >=1; i--)
    //    {
    //     Console.WriteLine(i);
    //    }

    //Exercicio 3: Tabuada simples (for): Leia um número e mostre a tabuada dele de 1 a 10.
       
    // Console.Write("Digite um numero para obter sua Tabuada: ");
    // int n = int.Parse(Console.ReadLine());

    // for (int i = 1; i <= 10; i++)
    // {
    //     Console.WriteLine(i*n);
    // }

    //Exercicio 4: Repetição com while: Mostre os números de 1 até 5 usando while.

    // int n = 1;

    //     while (n <= 5)
    //     {
    //         Console.WriteLine(n);
    //         n++;
    //     }

    //Exercicio 5: Soma até 5 (for): Some os números de 1 até 5 e mostre o resultado.

    // int soma = 0;

    //     for (int i = 1; i <= 5; i++)
    //     {
    //         soma += i;
    //     }

    //     Console.WriteLine("Soma: " + soma);

    //Exercicio 5: Soma de números digitados (for): Peça 5 números ao usuário e mostre a soma total.

    // Console.Write("Digite um numero: ");
    // int n1 = int.Parse(Console.ReadLine());

    // Console.Write("Digite um novo numero: ");
    // int n2 = int.Parse(Console.ReadLine());

    // Console.Write("Digite um novo numero: ");
    // int n3 = int.Parse(Console.ReadLine());

    // Console.Write("Digite um novo numero: ");
    // int n4 = int.Parse(Console.ReadLine());

    // Console.Write("Digite um novo numero: ");
    // int n5 = int.Parse(Console.ReadLine());
        
    // int soma = 0;

    // for(int i = n1; i <= n5; i++)
    // {
    //     soma += i;
    // }

    // Console.WriteLine("Soma: " + soma);

    //Codigo reduzido:

        int limite = 5; 
        
        double[] numeros = new double[limite]; 
        int contador = 0;

        Console.WriteLine($"Digite {limite} números.");

        while (contador < limite)
        {
            Console.Write($"Digite o {contador + 1}º número: ");
            numeros[contador] = double.Parse(Console.ReadLine());
            contador++;
        }

        double soma = 0;
        foreach (double n in numeros) 
        {
            soma += n;
        }

        Console.WriteLine($"\nA soma dos {limite} números é: {soma}");


    }
}
