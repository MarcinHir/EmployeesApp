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
        private Employee _employee;
        public Main()
        {
            InitializeComponent();
            RefreshGridView();
            SetColumnsHeader();
            
        }
        private void RefreshGridView()
        {
            var employees = _fileHelper.DeserializeFromFile();
            var isEmployed = cbIsWorking.Text;
         
            if (isEmployed == "Zatrudnieni")
                dgvEmployees.DataSource = employees.FindAll(x => x.EndOfWorkingTime == null);

            else if (isEmployed == "Zwolnieni")
                dgvEmployees.DataSource = employees.FindAll(x => x.EndOfWorkingTime != null);

            else
                dgvEmployees.DataSource = employees;

            dgvEmployees.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEmployees.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void SetColumnsHeader()
        {
            dgvEmployees.Columns[0].HeaderText = "Numer :";
            dgvEmployees.Columns[1].HeaderText = "Imię :";
            dgvEmployees.Columns[2].HeaderText = "Nazwisko :";
            dgvEmployees.Columns[3].HeaderText = "Uwagi :";
            dgvEmployees.Columns[4].HeaderText = "Data Rozpocęcia Pracy :";
            dgvEmployees.Columns[5].HeaderText = "Data Zwolnienia :";
            dgvEmployees.Columns[6].HeaderText = "Zarobki :";
            
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
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybierz pracownika którego chcesz edytować !");
                return;
            }
            AddEditEmployees addEditEmployees = new AddEditEmployees
                (Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value));

            addEditEmployees.FormClosing += AddEditEmployees_FormClosing;
            addEditEmployees.ShowDialog();
        }


        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybierz pracownika którego chcesz zwolnić !");
                return;
            }
            else if (dgvEmployees.SelectedRows[0].Cells[5].Value != null)
            {
                MessageBox.Show("Pracownik został już zwolniony !");
                return;
            }
            var selectedEmployee = dgvEmployees.SelectedRows[0];
            var conifirmFiring = MessageBox.Show(
                $"Czy na pewno zwolnić pracownika? {(selectedEmployee.Cells[1].Value.ToString() + " " + selectedEmployee.Cells[2].Value.ToString())}", "Zwalnianie pracownika!!!", MessageBoxButtons.OKCancel);
            var employeeId = Convert.ToInt32(selectedEmployee.Cells[0].Value);
            if (conifirmFiring == DialogResult.OK)
            {
                FireEmployee(employeeId);
            }
            else
                return;
        }
        private void FireEmployee(int employeeId)
        {
            var employees = _fileHelper.DeserializeFromFile();
            _employee = employees.FirstOrDefault(x => x.Id == employeeId);

            if (employeeId != 0)
            {
                _employee.EndOfWorkingTime = DateTime.Now;
                employees.RemoveAll(x => x.Id == employeeId);
            }
            employees.Add(_employee);
            _fileHelper.SerializeToFile(employees);
            RefreshGridView();
        }

        private void cbIsWorking_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridView();
        }
    }
}
