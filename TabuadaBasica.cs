using System;

namespace HelloWorld{
    class TabuadaNumbers{
        static void Main(string[] args){
           int multiplicador, multiplicando, resultado;

           for (multiplicador = 1; multiplicador <= 10; multiplicador++){
                if(multiplicador < 10){
                Console.WriteLine("┌─────────────┐");
                Console.WriteLine("│Tabuada do " + multiplicador+" │");
                Console.WriteLine("└─────────────┘");
                } else if(multiplicador == 10){
                    Console.WriteLine("┌─────────────┐");
                    Console.WriteLine("│Tabuada do " + multiplicador+"│");
                    Console.WriteLine("└─────────────┘");
                }
                for(multiplicando = 1; multiplicando <= 10; multiplicando++){
                    resultado = (multiplicador * multiplicando);
                    Console.WriteLine(" "+multiplicador + " x " + multiplicando +" = " + resultado);
                }
           }

           
        
        }
    }
}
