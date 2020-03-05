using System;

namespace PasseioCavaloBT{ 

    class PasseioCavalo {
        int[] dx = {1, 2, 2, 1,-1,-2,-2,-1};
        int[] dy = {2, 1,-1,-2,-2,-1, 1, 2};
        int n;
        int numCasas;
        int[,] tabuleiro;

        public PasseioCavalo(int n) {
            this.n = n;
            this.numCasas = n * n;
            tabuleiro = new int[n,n];
        }

        private bool aceitavel(int x, int y){
            bool resultado = (x >= 0 && x <= n - 1);
            resultado = resultado && (y >= 0 && y <= n - 1);
            resultado = resultado && (tabuleiro[x,y] == 0);
            return resultado;
        }

        private bool tentar(int passo, int x, int y) {
            bool achou = (passo > numCasas);
            int k = 0, u, v;

            while (!achou && k < 8) {
                u = x + dx[k];
                v = y + dy[k];

                if (aceitavel(u, v)){
                    tabuleiro[u,v] = passo;
                    achou = tentar(passo + 1, u, v);
                    if (!achou)
                        tabuleiro[u, v] = 0;
                }
                k++;
            }           
            return achou;
        }
        public void imprimirPasseio(int x, int y){
            
            tabuleiro[x, y] = 1;

            bool achou = tentar(2, x, y);

            if (achou){
                for (int i = 0; i < tabuleiro.GetLength(0); i++) {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++) {
                        Console.Write(tabuleiro[i,j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

        }

    }
}