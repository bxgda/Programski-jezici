using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab5_zad1
{
    public partial class Form1 : Form
    {
        List<Automobil> lista;
        
        public Form1()
        {
            InitializeComponent();
            lista = new List<Automobil>();
            checkbAtest.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkbAtest.Enabled = false;
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveSnimi.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Automobil.upisiListu(saveSnimi.FileName, lista);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil();
            NapraviObjekatSaPod(a);
            lista.Add(a);
            PrikaziListu();
            ResetujKontrole();
        }

        private void ResetujKontrole()
        {
            txtBoxModel.Text = string.Empty;
            txtBoxProizvodjac.Text = string.Empty;
            nudZapremina.Value = (decimal)0.5;
            dtpDatum.Value = DateTime.Today;
            txtBoxProizvodjac.Focus();
            radbBenzin.Checked = false;
            radbDizel.Checked = false;
            radbGas.Checked = false;
            checkbAtest.Checked = false;
        }

        private void PrikaziListu()
        {
            listbAutomobili.Items.Clear();
            listbAutomobili.Items.AddRange(lista.ToArray());
        }

        private void NapraviObjekatSaPod(Automobil a)
        {
            a.Proizvodjac = txtBoxProizvodjac.Text;
            a.Model = txtBoxModel.Text;
            a.ZapreminaMotora = (float)nudZapremina.Value;
            a.DatumProizvodnje = dtpDatum.Value;
            if (radbBenzin.Checked)
                a.VrstaGoriva = Automobil.Gorivo.BENZIN;
            if (radbDizel.Checked)
                a.VrstaGoriva = Automobil.Gorivo.DIZEL;
            if (radbGas.Checked)
            {
                a.VrstaGoriva = Automobil.Gorivo.GAS;
                if (checkbAtest.Checked)
                    a.Atest = true;
            }

        }

        private void listbAutomobili_DoubleClick(object sender, EventArgs e)
        {
            if (listbAutomobili.SelectedIndex != -1)
            {
                Automobil a = lista[listbAutomobili.SelectedIndex];
                txtBoxProizvodjac.Text = a.Proizvodjac;
                txtBoxModel.Text = a.Model;
                nudZapremina.Value = (decimal)a.ZapreminaMotora;
                dtpDatum.Value = a.DatumProizvodnje;
                if (a.VrstaGoriva == Automobil.Gorivo.BENZIN)
                    radbBenzin.Checked = true;
                if (a.VrstaGoriva == Automobil.Gorivo.DIZEL)
                    radbDizel.Checked = true;
                if (a.VrstaGoriva == Automobil.Gorivo.GAS)
                {
                    radbGas.Checked = true;
                    if (a.Atest)
                        checkbAtest.Checked = true;
                }
            }
        }

        private void ucitajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openUcitaj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lista = Automobil.ucitajListu(openUcitaj.FileName);
                PrikaziListu();
            }
        }

        private void radbGas_CheckedChanged(object sender, EventArgs e)
        {
            if (radbGas.Checked)
                checkbAtest.Enabled = true;
            else
                checkbAtest.Enabled = false;
        }
    }
}
