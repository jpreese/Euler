using System.Diagnostics;
using System.Linq;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
            Debug.WriteLine(sum);
        }
    }
}
