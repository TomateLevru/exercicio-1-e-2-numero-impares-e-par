    using System;
    // exercio 2
    public class umA50
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 != 0)
                {

                    soma = soma + i;
               
                }
            }
            Console.WriteLine("total de nº impares = " + soma);
        }
    }