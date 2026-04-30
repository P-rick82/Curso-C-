namespace Aula_30_04;

class Program
{
    static void Main(string[] args)
    {
        //Funções

        /*
        Tipos_de_retorno Nome_da_Função(Parametros) ou Tiposderetorno NomedaFunção(Parametros)
        {
            Comandos da Função
        }
        */

        //Exemplo:

        // //Função sem parametros e sem retorno
        
        // static void Mostrar_Mensagem()
        // {
        //     Console.WriteLine("Hello World");
        // }

        // //Chama a função
        // Mostrar_Mensagem();

       // // Função com Parametro
        
        // static void Saudacao(string nome)
        // {
        //     Console.WriteLine($"Hi, {nome}!");
        // }

        // Saudacao("lek");

        //Função com retorno
        
        //Parametros a e b
        //Retorno é a soma

        // static int somar(int a, int b)
        // {
        //     // int soma = a + b;  é msm coisa q a linha abaixo
        //     return a + b;
        // }

        // int resultado = somar(15,30);
        // Console.WriteLine(resultado);

        //Outro exemplo

        // static void exibirdobro(int num)
        // {
        //     Console.WriteLine(num*2);
        // }
        // exibirdobro(10);

        //Arrays -> Armazena varios valores do mesmo tipo em uma unica variavel

        // int[] numeros = new int[5];

        // Console.WriteLine(numeros);

        // numeros[0] = 2;
        // numeros[1] = 5;
        // numeros[2] = 8;
        // numeros[3] = 15;
        // numeros[4] = 20;

        // Console.WriteLine(numeros);
        // Console.WriteLine(string.Join(",", numeros));

        // //Outro exemplo

        // string[] nomes = {"Zezé di Camargo", "Amado Batista", "Leonardo"};
        
        // //Percorrendo com for

        // for (int i = 0; i < nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }

        // //Percorrendo com foreach

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nume);
        // }

        // // Função + Array
        
        // static double CalcularMedia(double[] notas)
        // {
        //     double soma = 0;

        //     for(int i =0; i < notas.Length; i++)
        //     {
        //         //soma = soma + nota[posição]
        //         soma += notas[i];
        //     }

        //     return soma / notas.Length;
        // }

        // double[] notasAluno = {8.0, 7.5, 9.0, 6.5};
        
        // double media = CalcularMedia(notasAluno);

        // Console.WriteLine($"Média final: {media}");

        //Outro exemplo

        // int[] numeros = new int[5];
        // int soma = 0;

        // for(int i = 0; i < numeros.Length; i++)
        // {
        //     Console.WriteLine($"Digite o {i + 1}º número: ");
        //     numeros[i] = int.Parse(Console.ReadLine());

        //     soma += numeros[i];
            
        // }

        // Console.WriteLine(string.Join(",", numeros));
        // Console.WriteLine($"A soma dos números é: {soma}");

        //Exercicio Realizado durante a aula

        static string VerificarSituação(double nota)
        {
            if(nota >= 7);
            {
                return "Aprovado";

            }
        }        


    }
}
