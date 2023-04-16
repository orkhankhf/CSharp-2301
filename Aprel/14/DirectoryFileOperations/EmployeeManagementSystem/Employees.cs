using EmployeeManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Employees : Form
    {
        public string LastUploadedCv { get; set; }
        public string LastUploadedImage { get; set; }

        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            employeesDataGridView.DataSource = VirtualDatabase.Employees;

            if (!Directory.Exists(GlobalSettings.WAITING_UPLOADS_PATH))
                Directory.CreateDirectory(GlobalSettings.WAITING_UPLOADS_PATH);
        }

        private void addNewEmployeeBtn_Click(object sender, EventArgs e)
        {
            Gender gender = Gender.Male;

            if(male.Checked)
                gender = Gender.Male;
            else if (female.Checked)
                gender = Gender.Female;

            Employee employee = new Employee(employeeName.Text, employeeSurname.Text, employeeBirthDate.Value, employeeJobDetails.Text, gender);
            VirtualDatabase.Employees.Add(employee);

            var imgPath = GlobalSettings.IMAGE_PATH + employee.Name + " " + employee.Surname + " " + employee.DateOfBirth.ToString("dd.MM.yyyy") + " Photo.jpg";
            var cvPath = GlobalSettings.CV_PATH + employee.Name + " " + employee.Surname + " " + employee.DateOfBirth.ToString("dd.MM.yyyy") + " CV.pdf";

            if(!Directory.Exists(GlobalSettings.IMAGE_PATH))
                Directory.CreateDirectory(GlobalSettings.IMAGE_PATH);

            if (!Directory.Exists(GlobalSettings.CV_PATH))
                Directory.CreateDirectory(GlobalSettings.CV_PATH);

            File.Move(LastUploadedImage, imgPath);
            File.Move(LastUploadedCv, cvPath);

            LastUploadedImage = string.Empty;
            LastUploadedCv = string.Empty;

            uploadImageBtn.Enabled = true;
            uploadCvBtn.Enabled = true;
            employeeName.Text = string.Empty;
            employeeSurname.Text = string.Empty;
            employeeJobDetails.Text = string.Empty;

            employee.ImagePath = imgPath;
            employee.CvPath = cvPath;

            Log(employee, true);
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            if(employeesDataGridView.SelectedRows.Count > 0)
            {
                var selectedEmployeeIndex = employeesDataGridView.SelectedRows[0].Index;

                var employee = VirtualDatabase.Employees[selectedEmployeeIndex];

                Log(employee, false);

                File.Delete(employee.ImagePath);
                File.Delete(employee.CvPath);

                VirtualDatabase.Employees.Remove(employee);
            }
            else
            {
                MessageBox.Show("Heç bir işçi seçilməyib!");
            }
            
        }

        private void uploadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files | *.jpg";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string safeFileName = dialog.SafeFileName;

                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    if((reader.BaseStream.Length / 1024) > 500)
                        MessageBox.Show("Max image size limit is 500KB!", "Image size limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        var newFileName = GlobalSettings.WAITING_UPLOADS_PATH + DateTime.Now.Ticks + ".jpg";
                        LastUploadedImage = newFileName;
                        reader.Close();
                        File.Copy(path, newFileName);
                        uploadImageBtn.Enabled = false;
                    }
                }
            }
        }

        private void uploadCvBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files | *.pdf";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string safeFileName = dialog.SafeFileName;

                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    if ((reader.BaseStream.Length / 1024) > 2000)
                        MessageBox.Show("Max image size limit is 2MB!", "Image size limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        var newFileName = GlobalSettings.WAITING_UPLOADS_PATH + DateTime.Now.Ticks + ".pdf";
                        LastUploadedCv = newFileName;
                        reader.Close();
                        File.Copy(path, newFileName);
                        uploadCvBtn.Enabled = false;
                    }
                }
            }
        }

        private void Log(Employee emp, bool isAdded)
        {
            FileStream fileStream = null;
            var filename = DateTime.Now.ToString("yyyy-MM-dd") + "_LOG.txt";

            if (!Directory.Exists(GlobalSettings.LOGS_PATH))
                Directory.CreateDirectory(GlobalSettings.LOGS_PATH);

            if (fileStream != null)
                fileStream.Close();

            List<string> logDetails = new List<string>
            {
                "----------------------------------------------" + (isAdded ? "Added" : "Removed") + " at " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.ms"),
                "Name: " + emp.Name,
                "Surname: " + emp.Surname,
                "Date Of Birth: " + emp.DateOfBirth.ToString("yyyy-MM-dd"),
                "Gender: " + emp.Gender.ToString(),
                "JobDetails: " + emp.JobDetails,
                "Created By User: " + "Some User",
                "----------------------------------------------",
                ""
            };

            File.AppendAllLines(GlobalSettings.LOGS_PATH + filename, logDetails);
        }
    }
}
