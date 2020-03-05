using System;
using System.Collections.Generic;

namespace MochilaFB {
    class Program  {
        static void Main(string[] args) {
            List<Item> itens = new List<Item>();

            itens.Add(new Item(12, 4));
            itens.Add(new Item(2, 2));
            itens.Add(new Item(1, 1));
            itens.Add(new Item(4, 10));
            itens.Add(new Item(1, 2));

            int tamanhoMochila = 15;
            forcaBruta(itens, tamanhoMochila);
        }

        private static void forcaBruta(List<Item> itens, int tamanhoMochila) {
            int totalItens = itens.Count;
            int combinacoes = (int) Math.Pow(2, totalItens);

            int pesoOcupado = 0;
            int melhorValor = 0;
            string combinacaoResposta = "";

            for (int i = 0; i < combinacoes; i++) {
                
                int pesoTotal = 0;
                int valorTotal = 0;
                string binario = Convert.ToString(i, 2);                
                binario = binario.PadLeft(totalItens, '0');
                //Console.WriteLine(binario);

                for (int j = 0; j < totalItens; j++) {
                    if (binario[j] != '0') {
                        pesoTotal += itens[j].peso;
                        valorTotal += itens[j].valor;                        
                    }
                    Console.WriteLine(binario + " peso -> " + pesoTotal + " valor -> " +valorTotal );
                }  

                if (pesoTotal <= tamanhoMochila && valorTotal > melhorValor){
                    pesoOcupado = pesoTotal;
                    melhorValor = valorTotal;
                    combinacaoResposta = binario;
                }
            }
            Console.WriteLine("\n\n RESULTADO " + combinacaoResposta + " peso -> " + pesoOcupado + " valor -> " + melhorValor);
        }
    }    
}
