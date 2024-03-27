// Módulos ou pacotes 

using System; //Módulo para que o c# consiga manipular o sistema operacional do programador/dev
/*
using System.Collections.Generic; //Armazena algumas estrutura de dados do C#
using System.Linq; //Usado para trabalhar com conjunto grande de dados
using System.Text; //Módulo responsável para manipular texto 
using System.Threading.Task; //Responsável para rodar várias tarefas ao mesmo tempo 
using System.IO; //Usado para manipular arquivos no computador 
using System.Net; //usado para usar redes, aplicações que interjam com a internet 
*/

//É possível usar módulo utilizando a palavra "using"

//Namespece e class program são focados e usados em orientações a objeto em C#
namespace HelloWorld 
{
 class Program { // inicio do programa 
 /*
    Tudo colocado dentro dessas chaves é o programa 
 */
    static void Main(string[] args){ // função principal 
    
        //var MeuTexto = "Hello World" //Forma mais fácil de declarar uma váriavel, mas não aconselhavel a se fazer
        //Console.Write("MeuTexto"); irá exibir da mesma forma que o comando a abaixo.

        Console.Write("Hello World"); //Exibir a mensagem texto para o usuario 
        Console.WriteLine("Ola Mundo");  //pula uma linha, semelhante ao \n
        //Console.ReadLine(); // le o que o usuario escreveu no console
    
        //Tipos de dados no C#
        /*
            Int - inteiros: 156...33402
            Float - Flutuantes, com virgulhas: 15.6...232.123
            Bool - Booleanos: TRUE ou FALSE
            String - palavras, frases: "dada"
            Char - caracters: 'a'
            
            O jeito mais comum no C# é dizer qual o tipo da variavel que quer ser criada
            por exemplo, querer armazenar uma data:

            int ano;
        */
    
        /* 
            Em nomes de variavel pode ser:
            A-Z
            0-9 sendo o numero o ultimo ou no meio 
            caracteres como @ $ . _
            Não pode usar nomes que seja da linguagem em sim como nome da variavel 
            como:
                int static;
            Static é algo próprio da linguagem.
        */
        int dia = 1; //Atribuir valor a variavel
        //Quando se trabalha com numeros puros é possivel realizar operaçoes matematicas
        string corFavorita = "Preto"; //Texto 
        float velocidadeCarro = 294.48f; //ponto flutuante 
        bool acao = true; //booleano
        char character = 'a';
        /* 
            Não pode existir variaveis com o mesmo nome 
            mesmo que sejam de tipos diferentes no mesmo lugar, por exemplo:
        
            int dia;
            string dia;

            isso dará erro no programa. 
        */

        Console.WriteLine(dia);
        Console.WriteLine(corFavorita);
        Console.WriteLine(acao);
        Console.WriteLine(velocidadeCarro);
        Console.WriteLine(character);

        Console.ReadLine();

        // Sinal de atribuição = 
        //Sinal de igualdade ==

        // é possivel modificar o valor de uma variavel, por exemplo;
       
        velocidadeCarro = 330.58f;
        Console.WriteLine("Novo valor: "+ velocidadeCarro);

        //outras formas 

        /*
            VAR
            
            Mesmo que o tipo da variavel não tenha sido colocado antes do nome
            não significa que o código não vá saber o tipo daquela variavell
            segue sendo a mesma ideia, não podendo ser feito:
            var cor = "vermelho";

            cor = 103241

            isso resultará em erro
            
            utilizar o var é uma forma reduzida/preguiçosa por assim dizer de fazer a declaração
        */
        var cor_Favorita = "Vermelho";
        var modeloProduto = 22332;

        Console.WriteLine(cor_Favorita);
        Console.WriteLine(modeloProduto);

        /*
        DYNAMIC - Tipagem dinamica 
            A variavel quando é declara com dynamic já possui um funcionamento um pouco mais diferente
            isso porque é possivel ser feito a seguinte forma de declaração 

            Não é recomendado utilizar, pois quebra muito o padrão da linguagem
            Menos performatica também.
        */

        dynamic cor_Favorite = "Roxo";
        Console.WriteLine(cor_Favorite);

        cor_Favorite = 5322424; //neste casso é possivel alterar a tipagem da variável
        Console.WriteLine(cor_Favorite);


        // CONSTANTES
        /*
            As constantes é criada para ter o mesmo valor durante toda a execução do programa
            não pode ter o valor alterado
        
        */

        const float PI = 3.1416f;
        Console.WriteLine(PI);
        Console.ReadLine();
        //ERROS 
        /*
            Na constante poderá dar erro se for alterado o valor atribuido a ela igual acontece
            com as variaveis, por exemplo:
            PI = 52.249f;

            Isso resulta em um erro
        */

    }
 }   //fim do programa
}

