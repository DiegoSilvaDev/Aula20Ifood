using System;
namespace Ifood
{
    public class Restaurante
    {
        public string NomeR { get; set; }
        public string Endereco { get; set; }

        public string MostrarDados(){
            System.Console.WriteLine("Detalhes do Estabelecimento:");
            Console.ForegroundColor = ConsoleColor.Blue;
            return $"\nNome: {NomeR}\nEndereço: {Endereco}";
        }
    }   
}