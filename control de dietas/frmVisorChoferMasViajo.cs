using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_de_dietas
{
    public partial class frmVisorChoferMasViajo : Form
    {
        public frmVisorChoferMasViajo()
        {
            try
            {
                InitializeComponent();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //InitializeComponent();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C: \Users\DELL\Google Drive\proyecto trabajo final\control de dietas\control de dietas\reporteChoferMasViajo.rpt");

                //cryRpt.Load(nombre_reporte);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmVisorChoferMasViajo_Load(object sender, EventArgs e)
        {

        }
    }
}
