using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {

        private int nextEmployeeID = 416644;
        private List<Employee> employees = new List<Employee>();
           
            

        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    

       

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string generatedID = nextEmployeeID.ToString();
            nextEmployeeID++;

            Employee emp = new Employee(
                generatedID,
                Firstname.Text,
                txtLastname.Text,
                txtPostion.Text
            );

            employees.Add(emp);

            dgvEmployeeList.DataSource = null;
            dgvEmployeeList.DataSource = employees;

           
            txtEmployeeID.Text = generatedID; 

            Firstname.Clear();
            txtLastname.Clear();
            txtPostion.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
