using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class Fibonacci
    {
        private Dictionary<int, int> memo;
        public Fibonacci()
        {
            this.memo = new Dictionary<int, int>();
            this.memo[0] = 0;
            this.memo[1] = 1;
        }
        public int Valor(int n)
        {
            if (this.memo.ContainsKey(n)) return this.memo[n];
            int v = Valor(n - 1) + Valor(n - 2);
            this.memo[n] = v;
            return v;
        }
    }

}
