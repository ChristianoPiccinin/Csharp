using System;
/*********************************************************
if (<lista de condicoes>)
{
    <comandos>;
}
Else //senao
{
    <comandos>;
}
AND (&&) ou OR (||)... 
**********************************************************/

class condicionais
{
    public static void Main()
    {
        string myInput;
        int myInt;
        Console.Write("Entre com um numero e pressione ENTER: ");
        myInput = Console.ReadLine();
        Console.WriteLine("myInput: {0} ",myInput );
        myInt = int32.Parse(myInput);

        //decisão simples com brackets
        if(myInt > 0 )
        {
            Console.WriteLine("Seu numero {0} é maior que zero.", myInt);
        }

        //decisão simples sem brackets
        if(myInt < 0)
            Console.WriteLine("Seu numero {0} é menor que zero.", myInt);

        //decisão com else 
        if( myInt != 0){
            Console.WriteLine("Seu numero {0} é diferete de zero.", myInt);
        }
        else
        {
            Console.WriteLine("Seu numero {0} é igual a zero.", myInt);
        }

        // multipla decisao com "E" e "OU"
        if(myInt < 0 || myInt == 0 )
        {
            Console.WriteLine("Seu numero {0} é menor ou igual a zero.", myInt);
        }
        else if(myInt > 0 && myInt <= 10)
        {
            Console.WriteLine("Seu numero {0} está entre 1 e 10." , myInt);
        }
        else if (myInt > 10 && myInt <= 20)
        {
            Console.WriteLine("Seu numero {0} está entre 11 e 20.", myInt);
        }
        else if(myInt > 20 && myInt <= 30)
        {
            Console.WriteLine("Seu numero {0} está entre 21 e 30.", myInt);
        }
        else{
            Console.WriteLine("Seu numero {0} é maior que 30.", myInt);
        }
    }
}