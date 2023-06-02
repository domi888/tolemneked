using System;
using System.Collections.Generic;

namespace Filmek
{
   public interface IKorhataros
   {
     int Korhatar { get; }
     int Buntetes(int eletkor);
   }
  class Program
  {
    static void Main(string[] args)
    {
      List<Film> filmek = new List<Film>();
      filmek.Add(new Film("Bombei bukszák", 10000));
      filmek.Add(new Film("Armageddon", 5000));
      filmek.Add(new AkcioFilm(16 ,"Pirates of Caribean 1", 15000));
      filmek.Add(new AkcioFilm(14, "Pirates of Caribean 2", 4000));

      try
      {
        int min = filmek[0].ar;
        int minIndex = 0;
        for (int i = 1; i < filmek.Count; i++)
        {
          if (filmek[i].ar < min)
          {
            min = filmek[i].ar;
            minIndex = i;
          }
        }
        Console.WriteLine("A legolcsóbb film:");
        if((filmek[minIndex] as AkcioFilm) != null)
        {
          Console.WriteLine(filmek[minIndex].cim + ": " + filmek[minIndex].ar + "-FT "+ (filmek[minIndex] as AkcioFilm).Korhatar+"-év kórtól");
        }
        else
        {
          Console.WriteLine(filmek[minIndex].cim + ": " + filmek[minIndex].ar + "-FT ");
        }
      }
      catch
      {

        
      }


      Console.ReadKey();
    }
  }
}
