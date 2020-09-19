using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
  class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person(33);
      Person p2 = new Person(33);
      Compare compare = new Compare();
      Console.WriteLine(p1.Age + " equals " + p2.Age + " ? " + compare.AreEqual<int>(1,2));
    }
  }
}
