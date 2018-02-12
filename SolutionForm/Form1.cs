using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI
        private void button1_Click(object sender, EventArgs e)
        {
            Permutation.Solution s = new Permutation.Solution();
            int[] a = { 1, 2,3,4 };
           var b =  s.Permute(a);
            foreach ( var list1 in b)
            {
                foreach (var item in list1)
                {
                    txtOutPut.AppendText($"{item},");
                }
                txtOutPut.AppendText(Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
