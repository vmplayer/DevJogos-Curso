using System;

class Funcao {
    //void - quando a string não retornar nada.
        public void calculaAreaR(int baseR, int alturaR) {

            int areaR = baseR * alturaR;
            Console.WriteLine(areaR);
        }

        //string, int, double, char - quando precisar retornar algo!
        public double conta(double num1, double num2) {
            double resultado = num1 + num2;
            return resultado;
        }
        
    static void Main (String[] args) {

        Funcao meuObj = new Funcao();

        meuObj.calculaAreaR(5,10);
        meuObj.calculaAreaR(3,2);
        meuObj.calculaAreaR(8,4);

    }
    static void Main (String[] args) {
        Funcao meuObj = new Funcao[];

        double numero = meuObj.conta(5,6);
        Console.WriteLine(numero + 10);
    }
}
