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
            int[] a = { 1, 2, 3 };
           var b =  s.Permute(a);
            var cehck = b;
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
