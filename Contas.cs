namespace CalculadoraX
{
    public class Contas : Calculadora
    {

        // Essas classes são todas publicas, por ser necessário ter o acesso de todas na classe pai "Calculadora"
        public void Dividir(){
            Dados();
            float resultado = n1/n2;
            System.Console.WriteLine("{0} / {1} = {2} é o resultado de sua divisão.",n1,n2,resultado);
        }
        public void Subtrair(){
            Dados();
            float resultado = n1-n2;
            System.Console.WriteLine("{0} / {1} = {2} é o resultado de sua subtração.",n1,n2,resultado);
        }
        public void Multiplicar(){
            Dados();
            float resultado = n1*n2;
            System.Console.WriteLine("{0} / {1} = {2} é o resultado de sua multiplicação.",n1,n2,resultado);
        }
        public void Somar(){
            Dados();
            float resultado = n1+n2;
            System.Console.WriteLine("{0} + {1} = {2} é o resultado de sua soma.",n1,n2,resultado);
        }
    }
}