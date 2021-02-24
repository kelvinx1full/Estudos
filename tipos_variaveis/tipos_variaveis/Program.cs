using System;

namespace tipos_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;

            var b = "Tipagem Dinâmica"; // exemplo de tipagem dinâmica

            string c = "Tipagem Estática"; // exemplo de tipagem estática

            char d = 'A'; // char aceitando só aspas simples

            int e = 19838; // int com tipagem estática

            double f = 1.5d; // double aceita ponto flutuante (8byte)

            var g = 1.5d; // 'd' representa que é um double

            float h = 1.5f; // Float necessita do f para ser reconhecido, float é um ponto flutuante menor que double (4 byte)

            decimal i = 1.9485m; // Decimal usa 'm' no final para ser reconhecido, decimal é o maior ponto flutuante (16 byte)

            bool j = true;
                              // boolean só aceita true ou false; positivo negativo ; 1 ou 0; sim ou não;
            bool k = false;

            
            bool boolean = bool.Parse("true"); //casting usando .Parse

            Console.WriteLine(boolean);

            bool boolean2 = Convert.ToBoolean("false"); //castin usando Convert.To

            Console.WriteLine(boolean2);


            

        }
    }
}
