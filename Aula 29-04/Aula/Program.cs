namespace Aula_29_04;

class Program
{
    static void Main(string[] args)
    {
        //Estruturas de Repetição

        /*
        
        for -> usado quando se sabe quantas vezes irá repetir

        while -> usado quando não se sabe quantas vezes ocorrerá a repetição. A repetição continua enquanto uma condição for verdadeira.

        do/while -> É similar ao while, mas a diferença é que - msm q a condição seja falsa, ele executa ao menos uma vez ("Faz primeiro e dps pergunta")

        foreach -> usado para percorrer listas
        
        */

        // Exemplo For

        // 1°: int i = 1  -> Inicializador, valor inicial
        // 2°: i <= 5     -> Condição, se for verdadeiro, continua executando
        // 3°: i++        -> Inteirador, acrescenta um valor a mais dentro do i (i = i + 1)

        // for(int i = 1; i <= 5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // Outro codigo:

        // int soma = 0;

        // for(int i = 1; i <= 10; i++)
        // {
        //     soma = soma + i;
        //     // soma += 1;   (Da na msm q a linha de cima)
        //     Console.WriteLine("Soma: " + soma);
        // }

        // Console.WriteLine("Soma Total: " + soma);

        //Exemplo While

        // int contador = 1;

        // while(contador <= 5)
        // {
        //     Console.WriteLine(contador);
        //     // contador = contador + 1
        //     contador++;
        // }
        
        //  Console.WriteLine("Contador Final: " + contador);

        //Outro codigo: Porem á validar

        // int numero = 5;
        // int resultado = numero++;

        // Console.WriteLine(numero);
        // Console.WriteLine(resultado);

        // Outro codigo:

    //     int numero = 0;

    //    while(numero <= 0)
    //     {
    //         Console.Write("Digite um numero maior do que zero: ");
    //         numero = int.Parse(Console.ReadLine());
    //     }

    //     Console.WriteLine("Número válido: " + numero);

        // Exemplo Do/while

        // int numero = 0;

        // do //faça
        // {
        //     Console.Write("Digite um númeero maior do que zero: ");
        //     numero = int.Parse(Console.ReadLine());
        // }
        // while(numero <= 0); //enquanto condição for verdadeira

        // Console.WriteLine("Número válido: " + numero);

        //Menu

        // int opcao;

        // do
        // {
        //      Console.WriteLine("1 - Continuar");
        //      Console.WriteLine("2 - Sair");
        //      opcao = int.Parse(Console.ReadLine());
        // }
        // while(opcao != 2);

        // Console.WriteLine("Programa encerrado");

        // Foreat

        // string[] nomes = {"Discumungado", "Zé", "Mundiça"};

        // // para cada nome na lista nomes
        // foreach(string nome in nomes)
        // {
        //     //imprima um nome
        //     Console.WriteLine(nome);
        // }

        //Outro codigo:

        // int[] numeros = {14, 44, 62, 36};
        // int soma = 0;

        // foreach(int numero in numeros)
        // {
        //     soma += numero;
        //     //soma = soma + numeros;
        // }

        // Console.WriteLine("Soma: " + soma);

    }
}
