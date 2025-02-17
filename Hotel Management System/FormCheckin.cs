using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormCheckin : Form
    {
        public FormCheckin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form3 f4 = new Form3();
            f4.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FormCheckin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet10.CheckIn' table. You can move, or remove it, as needed.
            this.checkInTableAdapter2.Fill(this.cmbloginDataSet10.CheckIn);
            // TODO: This line of code loads data into the 'cmbloginDataSet9.CheckIn' table. You can move, or remove it, as needed.
            this.checkInTableAdapter1.Fill(this.cmbloginDataSet9.CheckIn);
            // TODO: This line of code loads data into the 'cmbloginDataSet8.CheckIn' table. You can move, or remove it, as needed.
            this.checkInTableAdapter.Fill(this.cmbloginDataSet8.CheckIn);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into CheckIn Values(@NID,@Name,@Role,@Password,@Gender,@Mobile)", con);


            cnn.Parameters.AddWithValue("@NID", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@Check-InDate", monthCalendar1.Text);
            cnn.Parameters.AddWithValue("@PhoneNo", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@Address", textBox3.Text);
            cnn.Parameters.AddWithValue("@NumberOfPerson", comboBox1.Text);
            cnn.Parameters.AddWithValue("@CustomerInfo", textBox7.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from CheckIn", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
