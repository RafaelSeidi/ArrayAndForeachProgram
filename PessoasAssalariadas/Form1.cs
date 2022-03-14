using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoasAssalariadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nomes = { "Mario", "Ana", "Roberta", "Julia", "Renato", "Luiz", "Osvaldo", "Thanos", "George", "Irineu",
                               "Lindomar", "André", "Heitor", "José", "Menó", "Turineu", "Thiago", "Elias", "Raparajé", "Dollynho"};
            float[] salarios = { 100.00f, 200.00f, 500.00f, 156.00f, 123.49f, 234.61f, 987.00f, 123.45f, 678.90f, 768.12f, 174.00f, 129.49f,
                                00.15f, 98.65f, 7891.00f, 567.00f, 567.64f, 12.02f, 6780.78f, 789.37f};
            int cont = -1;
            foreach (string N in nomes)
            {
                cont++;
                listBox1.Items.Add(N + " " + salarios[cont]);
            }
        }
    }
}
