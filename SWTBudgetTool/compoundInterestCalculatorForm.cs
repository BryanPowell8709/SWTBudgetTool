using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWTBudgetTool
{
    public partial class compoundInterestCalculatorForm : Form
    {
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtTotal;
        public compoundInterestCalculatorForm()
        {
            InitializeComponent();
        }

        private void compoundInterestCalculatorForm_Load(object sender, EventArgs e)
        {

        }

    }
}
