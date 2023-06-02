using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FilmekGUI
{
  class Film
  {
    public string cim { get; private set; }
    public int ar { get; private set; }
    List<int> ertekelesek;

    public Film(string cim_, int ar_)
    {
      cim = cim_;
      ar = ar_;
      ertekelesek = new List<int>();
    }
    public double Atlag
    {
      get
      {
        if (ertekelesek.Count < 1)
        {
          Exception AtlagSzamitasHiba = new Exception("Átlag számítási hiba");
          AtlagSzamitasHiba.Source = this.ToString();
          throw AtlagSzamitasHiba;
        }
        return (ertekelesek.Average());
      }
    }
    public virtual void Ertekel(int ertek)
    {
      if (ertekelesek.Count<11) {
        ertekelesek.Add(ertek);
      }
      else
      {
        //később
        Exception UjErtekelesHiba = new Exception("Új értékelés hiba!");
        UjErtekelesHiba.Source = this.ToString();
        throw UjErtekelesHiba;
      }
    }
  }
}
