using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
  class Compare
  {
    public bool AreEqual<t>(t a, t b) where t : IComparable<t>
    {
      if (a.GetType().Equals(b.GetType()))
      {
        if (a.CompareTo(b) == 0)
          return true;
      }
      return false;
    }
  }
}
