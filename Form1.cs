using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyeU2
{
    public partial class Form1 : Form
    {
        List<double> list = new List<double>(); //Lista para almacenar los precios totales
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btAgr_Click(object sender, EventArgs e)
        {
            double precio = 0;
            if ((tbDes.Equals("") || Canti.Value == 0 || tbPre.Equals("")))
            {
                //no estan llenados los 3 campos
                MessageBox.Show("No estan llenados los 3 campos para ejecutar");
            }
            else
            {
                //Formato
                //Descripcion_Cantidad_Precio_Precio Total_Precio Total C/Iva
                try
                {
                precio = int.Parse(tbPre.Text);
                list.Add(((double)Canti.Value * precio) * 1.16);
                rTB.Text += tbDes.Text + "\t\t\t" + Canti.Value + "\t" + tbPre.Text + "\t\t" + ((double)Canti.Value * precio) + "\t\t" + (((double)Canti.Value * precio) * 1.16) + "\n";

                double totem = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    totem += list.ElementAt(i);
                }
                tbTot.Text = totem.ToString();
            }catch (Exception ex) {
                    MessageBox.Show("Debes ingresar solo numeros en el precio");
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            
            btAgr.Enabled = false;
            double total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list.ElementAt(i); ;
            }
            tbSob.Text = (double.Parse(tbRec.Text) - total).ToString();
        }catch(Exception ex)
            {
                MessageBox.Show("Debes ingresar solo cantidades numericas en el recibido");
            }
        }
        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTB.Clear();
            list.Clear();
            tbDes.Clear();
            Canti.Value = 0;
            tbPre.Clear();
            tbTot.Clear();
            btAgr.Enabled = true;
            tbRec.Clear();
            tbSob.Clear();
        }
    }
}
