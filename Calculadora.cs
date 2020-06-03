namespace CalculadoraX
{
    public class Calculadora 
    {
        public float n1= 0;
        public float n2= 0;

        //Este atributo está private pois só é necessario ser acessada pela classe Calculadora, no método "Media".
        private float media;

        //Este método está protected para apenas ser usado na classe filha 
        protected void Dados(){
            System.Console.WriteLine("Digite qualquer numero que desejar");
            n1=float.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Digite o segundo numero que desejar");
            n2=float.Parse(System.Console.ReadLine());
            Media();
        }
        // Este método está privado por ser necessário apenas nesta classe
        private void Media(){   
            media = (n1+n2)/2;
            System.Console.WriteLine("A média dos valores digitados é: {0}",media);  
            
        }
        public void Calculos(string contas){
            Contas soma = new Contas();
            Contas sub = new Contas();
            Contas mult = new Contas();
            Contas div = new Contas();    

            switch (contas){

                case "+":
                    soma.Somar();
                    break;

                case "-":
                    sub.Subtrair();
                    break;

                case "x":
                    mult.Multiplicar();
                    break;

                case "/":
                    div.Dividir();
                    break;

                default:
                    System.Console.WriteLine("Houve erro na digitação, desligando...");
                    break;  
            }
        }

    }
}