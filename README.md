# Csharp


### SWITCH
```csharp

using System;

/*
no exemplo abaixo faremos um programa que sempre 
ficará dentro de um laço atraves de labels(rotulos) 
*/
class switchSelect
{
    public static void Main()
    {
        string myInput;
        int myInt;

        //Label BEGIN
        begin:
            Console.Write("Digite um numero entre 1 e 3: ");
        myInput = Console.ReadLine();
        myInt   = int32.Parse(myInput);

        //switch com tipo inteiro
        switch (myInt)
        {   
            case 1:
                Console.WriteLine("Seu numero é {0}.", myInt);
            case 2:
                Console.WriteLine("Seu numero é {0}.", myInt);
            case 3:
                Console.WriteLine("Seu numero é {0}.", myInt);
            default:
                Console.WriteLine("O numero {0} não está entre 1 e 3", myInt);
        }

        //Label DECIDE
        decide:
            Console.Write("Digite \" continuar\" para continuar ou \"sair\" para sair: " );
        myInput= Console.ReadLine();
        
        //switch com tipo string
        switch (myInput)
        {
            case "continuar":
                goto begin;
            case "sair":
                Console.WriteLine("Tchau.");
                break;
            default:
                Console.WriteLine("Sua entrada {0} está incorreta." , myInput);
                goto decide;
        }
    }
 }
```
