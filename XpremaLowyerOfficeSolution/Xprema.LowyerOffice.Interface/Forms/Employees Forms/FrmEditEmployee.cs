using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Xprema.LowyerOffice.Datalayer.Tables_Classes;
using Xprema.LowyerOffice.Datalayer;
namespace Xprema.LowyerOffice.Interface.Forms
{
    public partial class FrmEditEmployee : Form
    {
        public FrmEditEmployee()
        {
            InitializeComponent();
        }


        EmployeeCmd empcmd = new EmployeeCmd();
        public Employee TargetEmployee{ get; set; }

        void LoadingData()
        {
            txtEmployeeName.Text = TargetEmployee.EmployeeName;
            txtAddress.Text = TargetEmployee.Address;
            txtEmail.Text = TargetEmployee.Email;
            txtIDCard.Text = TargetEmployee.IdNumber;
            txtPhone.Text = TargetEmployee.Phone;
        }
        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            LoadingData();
        }
    }
}
