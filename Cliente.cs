namespace Ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EndereçoAtual { get; set; }

        public string MostrarDados(){
            return $"Aqui está seu Perfil :\n Nome: {Nome}\n Endereço{EndereçoAtual}";
        }

        public string Pedido(string NomeR){
            return $"Você acaba de fazer um pedido no restaurante {NomeR}";
        }
        public string Pay(float Value){
            return $"O total a ser pago é : R${Value}";
        }
    }
}