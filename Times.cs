using System;

namespace TabelaColocação
    
{
    class Times
    {
        public string time;
        public int pont;

        public Times(string nomeTime, int pontuacao) {
            this.time = nomeTime;
            this.pont = pontuacao;
        }
        
        public void dados() {
            System.Console.WriteLine("\ntime: " + time + " | pontuação: " + pont);
        }
    }
     
}
