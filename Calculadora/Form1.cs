using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.CodeDom;

namespace Calculadora
{
    public partial class FrmCalcular : Form
    {
        public FrmCalcular()
        {
            InitializeComponent();
        }

        decimal Final;
        decimal Resultado;
        int Multiplicacion;
        decimal Actividad;
        int Peso;
        int Estatura ;
        int SumarCalorias;
        int Multi = 22;

        private void Mensaje(string Mensaje)
        {
            MessageBox.Show(Mensaje,"Calculadora de calorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje,"Calculadora de calorias", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int peso = int.Parse(TxtPeso.Text);
                int estatura = int.Parse(TxtEstatura.Text);
                double actividad = double.Parse(TxtActividad.Text);
                int sumaCalorias = int.Parse(TxtSumarCalorias.Text);

                //Operaciones
                int multiplicacion = peso * 22; //22 esta fijo para la multiplicación
                double resultado = multiplicacion * actividad;
                double final = resultado + sumaCalorias;

                if (final >= 4000) 
                {
                    Mensaje($"Estas muy gordo, tus calorias son: {final}, necesitas un déficit o recomposicion");
                }
                else if (final <=3000)
                {
                    Mensaje($"Eres un flacow, tus calorías son {final} metele a la comida");
                }
                else if (final <=3999 && final >=3000)
                {
                    Mensaje($"Estás en el rango de calorias {final} sigue asi para mutar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Favor verifica tus datos. | Error" + ex.Message);

            }

        

        }

        private void TxtPeso_TextChanged(object sender, EventArgs e)
        {
            int peso =0;
        }

        public void TxtEstatura_TextChanged(object sender, EventArgs e)
        {
            int Estatura = 0;
        }

        private void TxtActividad_TextChanged(object sender, EventArgs e)
        {
            decimal Actividad = 0;
        }

        private void TxtAumento_TextChanged(object sender, EventArgs e)
        {
            int SumarCalorias = 0;    
        }

        private void TxtMultiplicar_TextChanged(object sender, EventArgs e)
        {
            int multi = 0;
        }
    }
}
