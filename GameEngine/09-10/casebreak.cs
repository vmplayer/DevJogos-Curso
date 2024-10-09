using System;

public class casebreak {

    public static void Main (string[] args){

        switch ("nacionalidade") {

            case "brasileiro":
            Console.WriteLine("bem-vindo ao Brasil");
            break;

            case "americano":
            Console.WriteLine("Hello, World!");
            break;

            case "russo":
            Console.WriteLine("Priviat!");
            break;

            default:
            Console.WriteLine("Não encontramos a sua nacionalidade.");
            break;
        }
    }
}

//"switch" é o que define a ala de codições/case para ser executado ao código.
// | switch("") {}

//"case" é uma estrutura de condição que define o código a ser executado com base em comparação de valores. (sempre deve terminar com dois pontos ":"!)
// | case "":

//"default" indica quando nenhuma daquelas condições forem necessárias, fazendo com que ative uma função geral a ser executada junto ao código. (sempre deve terminar em dois pontos ":")
// | default:

//"break" é utilizado para declarar a última linha do código a ser executado dentro da condição e deve sempre ser mencionado, se não mencionado, a case será ignorada.
// | break;
