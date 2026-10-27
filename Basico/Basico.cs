using System;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de variáveis
            //Inteiros
            short num0 = 1; //16 bits
            int num1 = 10; //32 bits
            long num2 = 100; //64bits

            //Decimais
            float pi0 = 3.1f; //32 bits
            double pi1 = 3.14d; //64 bits ("d" ao final é opcional)
            decimal pi2 = 3.1415m; //128 bits (os bits são de precisão decimal, não de valor inteiro absoluto)

            //Texto
            char letra = 'a';
            string msg = "Hello World";

            //Bool
            bool isTrue = false;

            //Formas de output
            Console.WriteLine("Hello\nWorld"); //Quebra de linha
            Console.WriteLine("Hello\tWorld"); //Identação (tab)
            Console.WriteLine("Hello \"World\"!"); //Adição de aspas textuais na string
            Console.WriteLine("c:\\source\\"); //Adição de barra simples textuais na string
            float valor = 10.50f;
            Console.WriteLine($"Saldo: {valor}"); //Adição de valor de uma variável sem concatenação
            Console.WriteLine(@"Hello\n{var}\"); //Leitura literal da string
            string file = "text";
            Console.WriteLine($@"/{file}.txt/"); //Ambos podem ser usados juntos

            


        }
    }
}