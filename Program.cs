using System;
using System.Text.RegularExpressions;

namespace DesvioFluxo
{
    class Program
    {
        static Regex rgx = new Regex(@"^[a-zA-Z]{3}-\d{4}");
        static string placa;
        static int tamanho;
        static int posFinal;


        static void Main(string[] args)
        {
            Console.WriteLine("Verifica placa rodizio");

            do{
            
                Console.WriteLine("Digite sua placa:(AAA-0000)");
                placa=Console.ReadLine();

            }while(!rgx.IsMatch(placa));

            //retorna tamanho da string
            tamanho = placa.Length;

            //retorna posicao final da string: ultimo digito da placa
            posFinal = tamanho-1;

/* 
            if(placa.Substring(posFinal) == "1" || placa.Substring(posFinal) == "2")
            {
                Console.WriteLine("Segunda");
            }
            else if(placa.Substring(posFinal) == "3" || placa.Substring(posFinal) == "4")
            {
                Console.WriteLine("Terça");
            }
            else if(placa.Substring(posFinal) == "5" || placa.Substring(posFinal) == "6")
            {
                Console.WriteLine("Quarta");
            }
            else if(placa.Substring(posFinal) == "7" || placa.Substring(posFinal) == "8")
            {
                Console.WriteLine("Quinta");
            }
            else if(placa.Substring(posFinal) == "9" || placa.Substring(posFinal) == "0")
            {
                Console.WriteLine("Sexta");
            }
            else{
                Console.WriteLine("Placa inválida!");
            }
*/


            switch(placa.Substring(posFinal)){
                case "1":
                case "2": Console.WriteLine("Segunda");break;
                case "3": 
                case "4": Console.WriteLine("Terça");break;
                case "5": 
                case "6": Console.WriteLine("Quarta");break;
                case "7": 
                case "8": Console.WriteLine("Quinta");break;
                case "9": 
                case "0": Console.WriteLine("Sexta");break;
            }


        }
    }
}
