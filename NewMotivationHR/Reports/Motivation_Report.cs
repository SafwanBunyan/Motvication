using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Motivation.PL.Salary;

namespace Motivation.Reports
{
    public partial class Motivation_Report : DevExpress.XtraReports.UI.XtraReport
    {
        frmMonth month = new frmMonth();
        public Motivation_Report()
        {
            InitializeComponent();
       
        }


    }
}
