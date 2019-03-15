using System;
//Construindo uma aplicação com paramentros
//Agora vamos criar uma pequana aplicação que terá paramentros(argumentos) de 
//entrada e exibirá o conteudo deste argumento.

class sistema
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Seja bem vindo, {0} !", args[0]);
        Console.WriteLine("Este é o curso de C# por Carlos Vamberto");
    }
    
}