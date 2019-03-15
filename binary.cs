using System;
//Trabalhando com operadores binarios
class binary
{
    public static void Main()
    {
        int x, y, resultado; 
        float floatResult;
        
        x = 7;
        y = 5; 
        
        resultado = x + y;
        Console.WriteLine("x+y: {0}", resultado);

        resultado = x - y;
        Console.WriteLine("x-y: {0}", resultado);

        resultado = x * y;
        Console.WriteLine("x*y: {0}", resultado);

        resultado = x / y;
        Console.WriteLine("x/y: {0}", resultado);

        floatResult = (float) x / (float)  y;
        Console.WriteLine("x/y: {0}", floatResult);

        resultado = x % y;
        Console.WriteLine("x%y: {0}", resultado);

        resultado += x;
        Console.WriteLine("resultado +=x: {0}", resultado);
 
    }
}