using System;


namespace HellowWorld{
    class ProgramAula2{
        static void Main (string[] args){
            //ENTRADA DE USUARIO 
            string nome = " ";
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: "+ nome);

            Console.ReadLine();

            //OPERADORES ARITMETICOS

            int numeroInteiro = 20 + 20;
            Console.WriteLine("Resultado Soma: "+ numeroInteiro);
            int numeroMult = 10 * 90;
            Console.WriteLine("\nResultado Multiplicacao: "+ numeroMult);
            float numeroDiv = 5.0f/2;
            Console.WriteLine("\nResultado Divisao: "+ numeroDiv);

            int matematica = 2 + 2 * 10;
            Console.WriteLine("\nResultado da operacao: "+ matematica);
            matematica = (2+2) * 10;
            Console.WriteLine("\nResultado da operacao: "+ matematica);

        }
    }
}