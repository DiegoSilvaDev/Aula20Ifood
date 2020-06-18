using System;

namespace Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cl = new Cliente();
            Console.WriteLine("Digite seu nome");
            cl.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite seu endereço");
            cl.EndereçoAtual = Console.ReadLine();
            System.Console.WriteLine("Deseja fazer algum pedido?");
            string decisao1 = Console.ReadLine();    
                if(decisao1 == "Sim"){
                    System.Console.WriteLine("Aqui está um restaurante famoso\n");
                    Restaurante bk = new Restaurante();
                    bk.NomeR = "BurguerKing";
                    bk.Endereco = "R. Voluntários da Pátria, 2325";
                    Console.ForegroundColor = ConsoleColor.Blue; 
                    System.Console.WriteLine(bk.MostrarDados());
                    Console.ResetColor();
                    System.Console.WriteLine();
                    Pedido p1 = new Pedido();
                    p1.Cliente = cl.Nome;
                    p1.Restaurante = bk.NomeR;
                    System.Console.WriteLine("Deseja fazer algum pedido nele?");
                    string decisao2 = Console.ReadLine();
                    if(decisao2 == "Não" ){
                        Restaurante mc = new Restaurante();
                        mc.NomeR = "McDonalds";
                        mc.Endereco = "R. Voluntários da Pátria, 2273/2279";
                        System.Console.WriteLine("Aqui está outro restaurante famoso\n");
                        System.Console.WriteLine(mc.MostrarDados());
                        Console.ResetColor();
                        Pedido p2 = new Pedido();
                        p2.Cliente = cl.Nome;
                        p2.Restaurante = mc.NomeR;
                        System.Console.WriteLine("Qual forma de Pagamento?");
                        p2.FormaDePGTO = Console.ReadLine();
                        System.Console.WriteLine(cl.Pay(25.50f));
                        p2.PedidoPago = false;
                        p2.Value = 25.50f;
                        System.Console.WriteLine(p2.MostrarDados());
                        System.Console.WriteLine(p2.EntregarPedido());



                    }else{
                        System.Console.WriteLine("Qual forma de Pagamento?");
                        p1.FormaDePGTO = Console.ReadLine();
                        System.Console.WriteLine(cl.Pay(14.99f));
                        p1.PedidoPago = true;
                        p1.Value = 14.99f;
                        System.Console.WriteLine(p1.MostrarDados());
                        System.Console.WriteLine(p1.EntregarPedido());

                    }
            }
        
        }
    }
}
