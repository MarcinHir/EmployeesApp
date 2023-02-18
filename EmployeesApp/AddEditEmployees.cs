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
    public partial class AddEditEmployees : Form
    {

        private int _employeeId;
        private Employee _employee;
        private DateTime ?_EndOfWorking;

        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);

        public AddEditEmployees(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;
            GetEmployeeData();
            tbFirstName.Select();
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie Danych Pracownika";
                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.Id == _employeeId);
                if (_employee == null)
                {
                    throw new Exception("Brak pracownika o podanym ID!!");
                }

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            tbSalary.Text = _employee.Salary.ToString();
            tbComments.Text = _employee.Comments;
            dtpStartingWork.Text = _employee.StartingWorkingTime.ToString();
            _EndOfWorking = _employee.EndOfWorkingTime;
        }

        private void AddNewEmployeeToList(List<Employee> employees)
        {
            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Comments = tbComments.Text,
                Salary = Convert.ToDouble(tbSalary.Text),
                StartingWorkingTime = dtpStartingWork.Value,
                EndOfWorkingTime = _EndOfWorking
            };

            employees.Add(employee);
        }
        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var employeeWithHigestId = employees.
                    OrderByDescending(x => x.Id).FirstOrDefault();

            _employeeId = employeeWithHigestId == null ?
                1 : employeeWithHigestId.Id + 1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);
            else
                AssignIdToNewEmployee(employees);

            AddNewEmployeeToList(employees);

            _fileHelper.SerializeToFile(employees);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
