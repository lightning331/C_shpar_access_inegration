using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.OleDb;
using Glen_Eden_Cat_Clinic.DBManage;
using Glen_Eden_Cat_Clinic.AddVisit;
using Glen_Eden_Cat_Clinic.UpdateVisit;
using Glen_Eden_Cat_Clinic.PrintInvoices;
using Glen_Eden_Cat_Clinic.PrintVeterinarians;

namespace Glen_Eden_Cat_Clinic
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddVisitButton_Click(object sender, EventArgs e)
        {
            OwnerListForm form = new OwnerListForm(0);
            form.ShowDialog();
        }

        private void UpdateVisitButton_Click(object sender, EventArgs e)
        {
            VisitListForm form = new VisitListForm(0);
            form.ShowDialog();

        }

        private void DeleteVisitButton_Click(object sender, EventArgs e)
        {
            VisitListForm form = new VisitListForm(1);
            form.ShowDialog();
        }

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            OwnerListForm form = new OwnerListForm(1);
            form.ShowDialog();
        }

        private void UpdateCartButton_Click(object sender, EventArgs e)
        {
            CatListForm form = new CatListForm(model: null, 0);
            form.ShowDialog();
        }

        private void DeleteCartButton_Click(object sender, EventArgs e)
        {
            CatListForm form = new CatListForm(model: null, 1);
            form.ShowDialog();
        }

        private void AssignTreatmentButton_Click(object sender, EventArgs e)
        {
            VisitListForm form = new VisitListForm(2);
            form.ShowDialog();
        }

        private void RemoveTreatmentButton_Click(object sender, EventArgs e)
        {
            VisitListForm form = new VisitListForm(3);
            form.ShowDialog();
        }

        private void PrintInvoicesButton_Click(object sender, EventArgs e)
        {
            PrintInvoicesForm form = new PrintInvoicesForm();
            form.ShowDialog();
        }

        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            PrintVeterinariansForm form = new PrintVeterinariansForm();
            form.ShowDialog();
        }
    }
}
