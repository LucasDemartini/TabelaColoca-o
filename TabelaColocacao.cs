using System;
using System.Collections.Generic;

namespace TabelaColocação
{
    class TabelaColocacao
    {
        public List<Times> times;

        public TabelaColocacao() {
            times = new List<Times>();
        }

        public void resultado() {
            times.ForEach(delegate(Times t) {
                System.Console.WriteLine($"Time: {t.time} | Pontuação: {t.pont}");
            });
        }
        
    }    
}