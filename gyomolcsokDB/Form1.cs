using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace gyomolcsokDB
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GyomolcsokBetoltese();
        }

        private void GyomolcsokBetoltese()
        {
            listBox_Gyomolcsok.Items.Clear();
            foreach (Gyumolcs item in database.getGyomolcs())
            {
                listBox_Gyomolcsok.Items.Add(item);
            }

        }

        private void newFruite_Click(object sender, EventArgs e)
        {
            if (HianyosAdat())
            {
                return;
            }
            Gyumolcs ujGyumolcs = new Gyumolcs(1, textBox_nev.Text, (double)numericUpDown_egysegar.Value, (double)numericUpDown_mennyiseg.Value);
            database.addGyumolcs(ujGyumolcs);
            if (database.addGyumolcs(ujGyumolcs))
            {
                MessageBox.Show("Sikeres adatrögzítés!");
                textBox_nev.Text = "";
                textBox_azonosito.Text = "";


            }
            else
            {
                MessageBox.Show("Rögzítés sikertelen!");
            }
            GyomolcsokBetoltese();
        }
        private void modositas_Click(object sender, EventArgs e)
        {
            if (HianyosAdat())
            {
                return;
            }
            Gyumolcs ujGyumolcs = new Gyumolcs(1, textBox_nev.Text, (double)numericUpDown_egysegar.Value, (double)numericUpDown_mennyiseg.Value);
            if (database.updataGyumolcs(ujGyumolcs))
            {
                MessageBox.Show("Sikeresen frissítettük!");
                textBox_nev.Text = "";
                textBox_azonosito.Text = "";
            }
            else
            {
                MessageBox.Show("nem tudott frissülni!");
            }
            GyomolcsokBetoltese();
        }
        private bool HianyosAdat()
        {
            if (String.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Érvénytelen gyömölcsné!");
                textBox_nev.Focus();
                return true;   
            }
            
            return false;
        }

        private void listBox_Gyomolcsok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Gyomolcsok.SelectedIndex < 0)
            {
                return;
            }
            Gyumolcs friss= (Gyumolcs) listBox_Gyomolcsok.SelectedItem;
            textBox_azonosito.Text = friss.Id.ToString();
            textBox_nev.Text = friss.Nev.ToString();
            numericUpDown_egysegar.Value = (decimal)friss.Egysegar;
            numericUpDown_mennyiseg.Value = (decimal)friss.Menyiseg;
        }

        private void torlse_Click(object sender, EventArgs e)
        {
            if (listBox_Gyomolcsok.SelectedIndex<0)
            {
                return;
            }
            Gyumolcs torol = (Gyumolcs)listBox_Gyomolcsok.SelectedItem;


        }
    }
}
