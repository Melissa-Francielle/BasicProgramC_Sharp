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

            //ESTRUTURAS CONDICIONAIS BASICAS
            /*
                TIPOS 
                > < == >= <= != 

                Utilizando If para testar a condição
                onde caso ela seja verdadeira será realizada a ação dentro do bloco 
                e caso seja falsa sera executada outra ação 
                
                Neste caso o IF ele pode ser escrito sozinho, porém o ELSE
                ele deve estar sempre acompanhado de um IF. 
            */
            
            if (10 > 200){
                Console.WriteLine("É verdade");
            } else{
                Console.WriteLine("É mentira");
            }

            if(250 >= 250){
                Console.WriteLine("É verdade");
            } else{
                Console.WriteLine("É mentira");
            }

            //ELSE IF 
            /*
                O Else if ele sempre deve estar antes do ELSE.
                seu uso é ilimitado
            */

            if(1 > 20 ){ //SE 
                Console.WriteLine("É verdade");
            } else if(20 == 20){ 
                Console.Write("Executou o else if");
            } else{ // SE NAO
                Console.WriteLine("É mentira");
            }

            if(1 > 20){ //SE 
                Console.WriteLine("É verdade");
            } else if(20 !=20){ 
                Console.Write("Executou o else if");
            } else{ // SE NAO
                Console.WriteLine("É mentira");
            }
            /*
                É possivel comparar variaveis também
            */
            int a = 20;
            int b = 30;
            int c = 60;

            if(a < c){ //SE 
                Console.WriteLine("É verdade");
            } else if(b > a){ 
                Console.Write("Executou o else if");
            } else{ // SE NAO
                Console.WriteLine("É mentira");
            }

            //OPERADORES LOGICOS 

            /*
                TIPOS:
                       &&            || 
                    (E / and)    (OU / or )

                Esses operadores funcionam para garantir que mais de uma condição seja verdadeira ou não 
                por exemplo 
                o operador && (E / AND) 
                Ele é responsável por garantir que as duas condições sejam verdadeiras 
                caso as duas sejam verdadeiras então o código irá rodar aquele determinado bloco

                o operador || (OU / OR)
                Este operador atende uma ou outra condição caso uma ou a outra, ou ambas sejam verdadeiras então o resultado 
                é execução do bloco de código 
            */
            int numDois = 20;
            int numUm = 30;
            int numTres = 20;
            int numQuatro = 40;

            if (numDois != numUm && numDois == numTres){
                Console.WriteLine("É verdade (AND)");
            } else if (numTres != numQuatro || numDois == numUm){
                Console.WriteLine("É verdade (OR)");

            } else{
                Console.WriteLine("É Mentira");

            }

        }
    }
}
