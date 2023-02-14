using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesApp
{
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);
        public Main()
        {
            InitializeComponent();
            RefreshGridView();
        }
        private void RefreshGridView()
        {
            var employees = _fileHelper.DeserializeFromFile();
            dgvEmployees.DataSource = employees;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEditEmployees addEditEmployees = new AddEditEmployees();
            addEditEmployees.FormClosing += AddEditEmployees_FormClosing;
            addEditEmployees.ShowDialog();
        }

        private void AddEditEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshGridView();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
