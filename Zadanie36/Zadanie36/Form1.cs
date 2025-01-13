using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie36
{
    public partial class Form1 : Form
    {
        GetSecretIndegrient indegrientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();

        public Form1()
        {
            InitializeComponent();
        }

        private void useIngredient_Click(object sender, EventArgs e)
        {
            if (indegrientMethod != null) Console.WriteLine("Dodam " + indegrientMethod((int)amount.Value));
            else Console.WriteLine("Nie mam tajnego składnika!");
        }

        private void getSuzanne_Click(object sender, EventArgs e)
        {
            indegrientMethod = new GetSecretIndegrient(suzanne.MySecretIndegrientMethod);
        }

        private void getAmy_Click(object sender, EventArgs e)
        {
            indegrientMethod = new GetSecretIndegrient(amy.MySecretIndegrientMethod);
        }
    }
}
