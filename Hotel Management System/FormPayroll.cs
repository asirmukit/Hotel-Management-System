using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormPayroll : Form
    {
        public FormPayroll()
        {
            InitializeComponent();
        }

        private void FormPayroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet6.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.cmbloginDataSet6.Salary);

        }
    }
}
