using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEP_Revisao_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string placa;
            double velmax, velvei, velex, multa = 0;

            velmax = double.Parse(txt_velmax.Text);
            velvei = double.Parse(txt_velvei.Text);
            placa = txt_placa.Text;

            velex = velvei - velmax;

            if (velvei <= velmax)
            {
                MessageBox.Show("Você não cometeu nenhuma infração de transito");
            }
            else
            {
                if (velex <= 10)
                {
                    multa = 127.50;
                }
                else if (velex > 10 && velex <= 30)
                {
                    multa = 127.50 + (127.50 * 0.2);
                }
                else
                {
                    multa = 127.50 + (127.50 * 0.5);
                }

                lbl_placaS.Text = placa;
                lbl_velex.Text = "O veículo estava " + velex + "KM/H acima da velocidade máxima.";
                lbl_valor.Text = "O valor da multa será de " + multa.ToString("C");
            }
        }
    }
}
