using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class MathProbs
    {
        public int question1(int first )
        {
            return first + 5;
        }

        public int question2(decimal second)
        {
            int results = Convert.ToInt32(second);
            return results - 10;
        }

        public int question3(string third)
        {
            int answer = Convert.ToInt32(third);
            return answer + 30;
        }
    }
}
