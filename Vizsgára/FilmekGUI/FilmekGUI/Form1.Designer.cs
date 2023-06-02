
namespace FilmekGUI
{
  partial class FilmekGUI
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.buntetlenul = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.eletkor_tbox = new System.Windows.Forms.TextBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.osszes_buntetes = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buntetlenul
      // 
      this.buntetlenul.Location = new System.Drawing.Point(23, 13);
      this.buntetlenul.Name = "buntetlenul";
      this.buntetlenul.Size = new System.Drawing.Size(193, 23);
      this.buntetlenul.TabIndex = 0;
      this.buntetlenul.Text = "Büntetlenül megvásárolható";
      this.buntetlenul.UseVisualStyleBackColor = true;
      this.buntetlenul.Click += new System.EventHandler(this.buntetlenul_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(281, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Életkor:";
      // 
      // eletkor_tbox
      // 
      this.eletkor_tbox.Location = new System.Drawing.Point(342, 18);
      this.eletkor_tbox.Name = "eletkor_tbox";
      this.eletkor_tbox.Size = new System.Drawing.Size(100, 20);
      this.eletkor_tbox.TabIndex = 2;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(23, 80);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(269, 264);
      this.listBox1.TabIndex = 3;
      // 
      // osszes_buntetes
      // 
      this.osszes_buntetes.Location = new System.Drawing.Point(23, 415);
      this.osszes_buntetes.Name = "osszes_buntetes";
      this.osszes_buntetes.Size = new System.Drawing.Size(269, 23);
      this.osszes_buntetes.TabIndex = 4;
      this.osszes_buntetes.Text = "Összes Büntetés";
      this.osszes_buntetes.UseVisualStyleBackColor = true;
      this.osszes_buntetes.Click += new System.EventHandler(this.osszes_buntetes_Click);
      // 
      // FilmekGUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.osszes_buntetes);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.eletkor_tbox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buntetlenul);
      this.Name = "FilmekGUI";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FilmekGUI_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buntetlenul;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox eletkor_tbox;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button osszes_buntetes;
  }
}

