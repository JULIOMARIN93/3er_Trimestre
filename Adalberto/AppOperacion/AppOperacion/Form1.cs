using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_operacion;


namespace AppOperacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num1, num2;
            //capturamos los valores de las cajas de texto en cada variable//
            num1 = Convert.ToInt32(txtn1.Text);
            num2 = Convert.ToInt32(txtn2.Text);
            //instanciar logica de negocio//
            Operacion ObjOp = new Operacion();
            //enviar los valores a la logica de negocio//
            ObjOp.SetN1 = num1;
            ObjOp.SetN2 = num2;
            if (ObjOp.calcular())
            {
                txtsuma.Text = ObjOp.GetSuma.ToString();
                return;
            }
            else
            {
                MessageBox.Show(ObjOp.GetError);
            }
        }
    }
}
