using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmekGUI
{
  class Puzzle:IKorhataros
  {
    public int darabszam { get; private set; }

    public Puzzle(int darabszam_)
    {
      darabszam = darabszam_;
    }
    public int Korhatar
    {
      get
      {
        return (darabszam / 500);
      }
    }
    public int Buntetes(int eletkor)
    {
      // (eletkor paraméter – Korhatar) * 1000
      return (eletkor - Korhatar) * 1000;
    }
  }
}
