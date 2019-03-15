using System;
/*********************************************************
 while (<condicao>)
 {
     ...
     <expressões>
     ...
 }
 *********************************************************/

class whileLoop
{
    public static void Main ()
    {
        int myInt = 0;
        while (myInt < 10)
        {
            Console.Write("{0} ", myInt );
            myInt++;
        }
        Console.WriteLine();
    }
}