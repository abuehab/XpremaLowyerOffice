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
        public Employee TargetEmployee{ get; set; }
        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
