namespace Ifood
{
    public class Pedido
    {
        public string[] Itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }
        public float Value { get; set; }        

        public string EntregarPedido(){
            if(PedidoPago == true){
                return "\nO pedido está a caminho!\n";
            }
            return "\nO pedido será entregue após o pagamento ser efetuado!\n";
        }
        public string MostrarDados(){
            return $"\nAqui está os dados do seu pedido:\nFoi efetuado por {Cliente}\nNo restaurante: {Restaurante}\nCom um total de: R${Value}\nSerá pago com a seguinte forma de pagamento: {FormaDePGTO}";
        }

    }
}