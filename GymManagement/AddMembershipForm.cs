using System;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class AddMembershipForm : Form
    {
        public DateTime StartDate => dtpStartDate.Value.Date;
        public DateTime EndDate => dtpEndDate.Value.Date;

        public AddMembershipForm()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddMonths(1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EndDate <= StartDate)
            {
                MessageBox.Show("Data zakończenia musi być późniejsza niż data rozpoczęcia.",
                    "Błąd daty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
