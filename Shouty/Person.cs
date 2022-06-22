using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shouty
{
    public class Person
    {
        public void MoveTo(int distance)
        {
        }

        public void Shouts(string message)
        {
        }

        public IEnumerable<string> MessageHeard()
        {
            return new List<string> { "free bagels at Sean's" };
        }
    }

}
