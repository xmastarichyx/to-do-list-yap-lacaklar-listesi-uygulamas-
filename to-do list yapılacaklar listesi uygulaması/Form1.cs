using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list_yapılacaklar_listesi_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SıralaVeGüncelle();
        }

       

        private void gün_liste_Leave(object sender, EventArgs e)
        {
            if(gün_liste.Text=="Pazartesi" || gün_liste.Text == "Salı" || gün_liste.Text == "Çarşamba" || gün_liste.Text == "Perşembe" || gün_liste.Text == "Cuma" || gün_liste.Text == "Cumartesi" || gün_liste.Text == "Pazar")
            {

            }
            else
            {
                gün_liste.Text = "";
            }
        }

        private void önemi_Leave(object sender, EventArgs e)
        {
            if (önemi.Text == "Yüksek Öncelikli" || önemi.Text == "Öncelikli" || önemi.Text == "Orta" || önemi.Text == "Düşük Öncelikli" || önemi.Text == "Gereksiz" )
            {

            }
            else
            {
                önemi.Text = "Orta";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = yapılacak_is.Text.Trim();
            string metin1= gün_liste.Text.Trim();
            // Metin boş değilse ListBox'a ekle
            if (!string.IsNullOrEmpty(metin)&&(!string.IsNullOrEmpty(metin1)))
            {
                StreamWriter ekle = new StreamWriter("iş_liste.txt", append: true);
                ekle.WriteLine(yapılacak_is.Text + "*" + gün_liste.Text + "*" + önemi.Text);
                ekle.Close();
                gün_liste.Text="";
                yapılacak_is.Clear(); 
            }
            
        }
        private void SıralaVeGüncelle()
        {
            string metin;

            List<string> list = new List<string>();
            StreamReader oku = new StreamReader("iş_liste.txt");
            int sayaç = 0;
            // Dosyadan her satırı oku ve listeye ekle
            while ((metin = oku.ReadLine()) != null)
            {

                string[] metinx = metin.Split('*');

                if (metinx.Length >= 3)
                {
                    sayaç++;
                    list.Add(metinx[0] + " / " + metinx[1] + " / " + metinx[2]);
                }
            }
            oku.Close();
            liste.Items.Clear();


            foreach (string x in list)
            {
                liste.Items.Add(x);
            }
        }
            private void sırala_Click(object sender, EventArgs e)
        {
            SıralaVeGüncelle();
            
        }
        
        private void güncelleme(string taskToDelete)
        {
            
                
            
            


            string[] lines = File.ReadAllLines("iş_liste.txt");
            using (StreamWriter writer = new StreamWriter("iş_liste_yeni.txt"))
            {
                foreach (string line in lines)
                {
                    string formattedLine = FormatTask(line);
                    if (!formattedLine.Equals(taskToDelete))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            
            File.Delete("iş_liste.txt");
            File.Move("iş_liste_yeni.txt", "iş_liste.txt");
        }
        private string FormatTask(string taskLine)
        {
            
               
            
         

            string[] metinx = taskLine.Split('*');
            if (metinx.Length >= 3)
            {
                return metinx[0] + " / " + metinx[1] + " / " + metinx[2];
            }
            return string.Empty;
        }

        private void sil_Click_1(object sender, EventArgs e)
        {
            if (liste.SelectedIndex != -1) 
            {
                string selectedItem = liste.SelectedItem.ToString();
                var mesaj = MessageBox.Show($"Seçilen öğeyi silmek istediğinizden emin misiniz?\n\n{selectedItem}", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (mesaj == DialogResult.Yes)
                {
                    güncelleme(selectedItem);
                    SıralaVeGüncelle();
                }
            }
        }
    }
}
