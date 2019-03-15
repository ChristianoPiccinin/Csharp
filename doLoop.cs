using System; 
/*********************************************************
do
{
    ...  <expressões>;  ... 
} while(<condicional>);
*********************************************************/

class doLoop
{
    public static void Main()
    {
       string myChoice;
       do
       {
           //Imprime o menu
            Console.WriteLine(" Meu Livro de Endereços\n");
            Console.WriteLine("A - Adicionar");
            Console.WriteLine("D - Deletar");
            Console.WriteLine("M - Modificar");
            Console.WriteLine("V - Visualizar");
            Console.WriteLine("S - Sair\n");
            Console.WriteLine("Escolha (A,D,M, V, ou S): " );

            //obtem a escolha do usuario
            myChoice = Console.ReadLine();

            //Trata a escolha do usuario
            switch (myChoice)
            {   
                case "A":
                case "a":
                    Console.WriteLine("Você escolheu ADICIONAR.");
                    break;
                case "M":
                case "m":
                    Console.WriteLine("Você escolheu MODIFICAR.");
                    break;
                case "V":
                case "v":
                    Console.WriteLine("Você escolheu VISUALIZAR.");
                    break;
                case "D":
                case "d":
                    Console.WriteLine("Você escolheu DELETAR.");
                    break;
                case "S":
                case "s":
                    Console.WriteLine("Você escolheu SAIR.");                    
                   
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Saindo..{0}", i); 
                    }
                    
                    break;
                default:
                    Console.WriteLine("{0} não é uma opção valida", myChoice);
                    break;
            } //Fim SWITCH

            //Da uma pausa para permitir que o  usuario veja o resultado
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
            COnsole.WriteLine();

       } while(myChoice != "S" && myChoice != "s");       //FIM DO 
    }    //repete até o usuario querer sair 
}
