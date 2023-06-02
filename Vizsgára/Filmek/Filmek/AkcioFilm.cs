using System;
using System.Collections.Generic;
using System.Text;

namespace Filmek
{
  class AkcioFilm:Film, IKorhataros
  {
    int korhatar;
    public AkcioFilm(int korhatar_, string cim_, int ar_):base(cim_, ar_)
    {
      korhatar = korhatar_;
    }
    public int Korhatar
    {
      get
      {
        return korhatar;
      }
    }
    public int Buntetes(int eletkor)
    {
      //(eletkor paraméter – korhatar) *ar
      return (eletkor - korhatar) * ar;
    }
    public override void Ertekel(int ertek)
    {
      if (ertek < 5)
      {
        base.Ertekel(ertek);
      }
    }
  }
}
