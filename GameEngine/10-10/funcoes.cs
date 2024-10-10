using System;

class Funcao {

        public void calculaAreaR(int baseR, int alturaR) {

            int areaR = baseR * alturaR;
            Console.WriteLine(areaR);
        }
        
    static void Main (String[] args) {

        Funcao meuObj = new Funcao();

        meuObj.calculaAreaR(5,10);
        meuObj.calculaAreaR(3,2);
        meuObj.calculaAreaR(8,4);
    }
}
