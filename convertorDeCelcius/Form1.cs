using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertorDeCelcius
{
    public partial class frmConvertorDeCelcius : Form
    {
        public frmConvertorDeCelcius()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if(isCelcius.Checked != isFahrenheit.Checked)
            {
                if (isCelcius.Checked)
                {
                    if(txtCelcius.Text != "")
                    {
                        float celcius = float.Parse(txtCelcius.Text);
                        float fahrenheit = (celcius * 9 / 5) + 32;
                        txtResponse.Text = fahrenheit.ToString();
                    }
                    else
                    {
                        txtResponse.Text = "Digite um número válido";
                    }
                } else
                {
                    if (txtFahre.Text != "")
                    {
                        float fahrenheit = float.Parse(txtFahre.Text);
                        float celcius = (fahrenheit - 32) * 5 / 9;
                        txtResponse.Text = celcius.ToString();
                    }
                    else
                    {
                        txtResponse.Text = "Digite um número válido";
                    }
                }
            } else
            {
                txtResponse.Text = "Selecione uma caixa";
            }
        }
    }
}
