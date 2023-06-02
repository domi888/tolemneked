using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmekGUI
{
  public interface IKorhataros
  {
    int Korhatar { get; }
    int Buntetes(int eletkor);
  }
  public partial class FilmekGUI : Form
  {
    List<IKorhataros> dolgok = new List<IKorhataros>();
    public FilmekGUI()
    {
      InitializeComponent();

      dolgok.Add(new Puzzle(1000));
      dolgok.Add(new Puzzle(5000));
      dolgok.Add(new AkcioFilm(16, "Pirates of Caribean 1", 15000));
      dolgok.Add(new AkcioFilm(14, "Pirates of Caribean 2", 4000));

    }

    private void FilmekGUI_Load(object sender, EventArgs e)
    {

    }

    private void buntetlenul_Click(object sender, EventArgs e)
    {
      foreach (var dolog in dolgok)
      {
        if((dolog as AkcioFilm) != null)
        {
          if(eletkor_tbox.Text == "")
          {
            throw new Exception("Az életkor mező nincs kitöltve!");
          }
          else
          {
            if((dolog as AkcioFilm).Korhatar < Convert.ToInt32(eletkor_tbox.Text))
            {
              listBox1.Items.Add((dolog as AkcioFilm).cim + ": " + (dolog as AkcioFilm).ar + "-FT " + (dolog as AkcioFilm).Korhatar + "-év kórtól");
            }
          }
        }
      }
    }

    private void osszes_buntetes_Click(object sender, EventArgs e)
    {
      int buntetesek = 0;
      foreach (var dolog in dolgok)
      {
        if (eletkor_tbox.Text == "")
        {
          throw new Exception("Az életkor mező nincs kitöltve!");
        }
        else
        {
          if (dolog.Korhatar > Convert.ToInt32(eletkor_tbox.Text))
          {
            buntetesek += dolog.Buntetes(Convert.ToInt32(eletkor_tbox.Text));
          }
        }
      }
      MessageBox.Show("Büntetések összege: "+buntetesek);
    }
  }
}
