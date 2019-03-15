using System;

class unario
{
    public static void Main()
    {
        // Declaração da variaveis 
        int unario = 0;
        int preIncremento;
        int preDecremento;
        int posIncremento;
        int posDecremento;
        int positivo;
        int negativo;
        sbyte bitNao;
        bool logNao;

        //Inicio do Código 
        preIncremento = ++unario;
        Console.WriteLine("Pré-incremento   : {0}", preIncremento);
        Console.WriteLine("Unário           : {0}", unario);
        Console.WriteLine(" --- ");

        preDecremento = --unario;
        Console.WriteLine("Pré-decremento   : {0}", preDecremento);
        Console.WriteLine("Unário           : {0}", unario);
        Console.WriteLine(" --- ");

        posIncremento = unario++;
        Console.WriteLine("Pós Incremento   : {0}", posIncremento);
        Console.WriteLine("Unário           : {0}", unario);
        Console.WriteLine(" --- ");

        posDecremento = unario--;
        Console.WriteLine("Pós decremento   : {0}", posDecremento);
        Console.WriteLine("Unario           : {0}", unario);
        console.WriteLine(" --- ");

        Console.WriteLine("Valor Final do Unário: {0}",unario);
        Console.WriteLine(" --- ");
        
        positivo = -posIncremento;
        Console.WriteLine("Positivo             : {0}",positivo);
        
        negativo = +posIncremento;
        Console.WriteLine("Negativo             : {0}",negativo);
        Console.WriteLine(" --- ");

        bitNao = 0;
        bitNao = (sbyte) (~bitNao);
        Console.WriteLine("Bitwise              : {0}",bitNao)
        Console.WriteLine(" --- ");

        logNao = false; 
        logNao = !logNao;
        Console.WriteLine("Não Lógico           : {0}",logNao);
        Console.WriteLine(" --- ");
    }
}