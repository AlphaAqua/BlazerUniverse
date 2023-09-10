using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassUniverse.Data;

namespace ClassUniverse.Services
{
  internal class UniverseService
  {
    private Universe? defaultUniverse;

    public Universe NewUniverse ()
    {
      var uni = new Universe
      {
        Name = "Galaxia"
      };

      defaultUniverse = uni;
      return uni;
    }

    public void RunUniverseTick()
    {
      if (defaultUniverse == null)
      {
        throw new ArgumentNullException("No universe to run exist");
      }
      RunUniverseTick(defaultUniverse);
    }

    public void RunUniverseTick (Universe universe)
    {
      if (universe == null)
      {
        throw new ArgumentNullException(nameof(universe));
      }
    }
  }
}
