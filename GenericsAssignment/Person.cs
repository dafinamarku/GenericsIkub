using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
  class Person: IComparable<Person>
  {
    private int age;
    public Person(int a)
    {
      age = a;
    }
    public int Age
    {
      get { return age; }
      set { age = value; }
    }
    
    public int CompareTo(Person other)
    {
      if (other == null) return 1;

      return this.age.CompareTo(other.Age);
    }
  }
}
