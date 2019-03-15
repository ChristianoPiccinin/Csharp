using System;

class vetores
{
    public static void Main()
    {
        //Declaração de vetor
        string[] vetNome = new string[4];

        //atribuição
        vetNome[0] = "Adriano";
        vetNome[1] = "Marcelo";
        vetNome[2] = "Ferrari";
        vetNome[3] = "Christiano";

        for (int x=0; x<=3;x++){
            Console.WriteLine("Nome: {0} = {1}", x , vetNome);
        }


        //Outra forma de declarar vetor
        string[] vetCarros ={"Civic","Uno","D-20"};

        for(int x=0; x<=2; x++)
        {
            Console.WriteLine("Carro: {0} = {1}",x,vetCarros);
        }

    }
}
