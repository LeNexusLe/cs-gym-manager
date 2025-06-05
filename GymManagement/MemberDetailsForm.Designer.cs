using System;
using System.Windows.Forms;

namespace GymManagement
{
    partial class MemberDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabPersonal = new TabPage();
            this.tabAttendance = new TabPage();
            this.tabMemberships = new TabPage();

            this.txtFirstName = new TextBox();
            this.txtLastName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPhone = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.btnSave = new Button();

            this.dgvAttendance = new DataGridView();
            this.dgvMemberships = new DataGridView();
            this.dgvWorkoutPlan = new DataGridView();

            this.btnDeleteMembership = new Button();

            // tabControl
            this.tabControl.Controls.Add(this.tabPersonal);
            this.tabControl.Controls.Add(this.tabAttendance);
            this.tabControl.Controls.Add(this.tabMemberships);
            this.tabControl.Location = new Point(12, 12);
            this.tabControl.Size = new Size(480, 320);
            this.tabControl.TabIndex = 0;

            // tabPersonal
            this.tabPersonal.Controls.Add(this.btnSave);
            this.tabPersonal.Controls.Add(this.txtPhone);
            this.tabPersonal.Controls.Add(this.txtEmail);
            this.tabPersonal.Controls.Add(this.txtLastName);
            this.tabPersonal.Controls.Add(this.txtFirstName);
            this.tabPersonal.Controls.Add(this.label4);
            this.tabPersonal.Controls.Add(this.label3);
            this.tabPersonal.Controls.Add(this.label2);
            this.tabPersonal.Controls.Add(this.label1);
            this.tabPersonal.Text = "Dane osobowe";
            this.tabPersonal.UseVisualStyleBackColor = true;

            // TextBoxes
            this.txtFirstName.Location = new Point(180, 30);
            this.txtFirstName.Size = new Size(200, 23);
            this.txtFirstName.BackColor = Color.White;
            this.txtFirstName.ForeColor = Color.Black;
            this.txtFirstName.BorderStyle = BorderStyle.FixedSingle;

            this.txtLastName.Location = new Point(180, 70);
            this.txtLastName.Size = new Size(200, 23);
            this.txtLastName.BackColor = Color.White;
            this.txtLastName.ForeColor = Color.Black;
            this.txtLastName.BorderStyle = BorderStyle.FixedSingle;

            this.txtEmail.Location = new Point(180, 110);
            this.txtEmail.Size = new Size(200, 23);
            this.txtEmail.BackColor = Color.White;
            this.txtEmail.ForeColor = Color.Black;
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;

            this.txtPhone.Location = new Point(180, 150);
            this.txtPhone.Size = new Size(200, 23);
            this.txtPhone.BackColor = Color.White;
            this.txtPhone.ForeColor = Color.Black;
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;

            // Labels
            this.label1.Text = "Imię";
            this.label1.Location = new Point(100, 33);

            this.label2.Text = "Nazwisko";
            this.label2.Location = new Point(100, 73);

            this.label3.Text = "Email";
            this.label3.Location = new Point(100, 113);

            this.label4.Text = "Telefon";
            this.label4.Location = new Point(100, 153);

            // btnSave
            this.btnSave.Text = "Zapisz";
            this.btnSave.Location = new Point(180, 200);
            this.btnSave.Size = new Size(100, 30);
            this.btnSave.BackColor = Color.FromArgb(58, 124, 165);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // tabAttendance
            this.tabAttendance.Controls.Add(this.dgvAttendance);
            this.tabAttendance.Text = "Historia wejść";
            this.tabAttendance.UseVisualStyleBackColor = true;

            // dgvAttendance
            this.dgvAttendance.Dock = DockStyle.Fill;
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = Color.FromArgb(245, 245, 245);
            this.dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.DefaultCellStyle.BackColor = Color.White;
            this.dgvAttendance.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvAttendance.DefaultCellStyle.SelectionBackColor = Color.FromArgb(58, 124, 165);
            this.dgvAttendance.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            this.dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // tabMemberships
            this.tabMemberships.Controls.Add(this.dgvMemberships);
            this.tabMemberships.Controls.Add(this.btnDeleteMembership);
            this.tabMemberships.Text = "Członkostwa";
            this.tabMemberships.UseVisualStyleBackColor = true;

            // dgvMemberships
            this.dgvMemberships.Location = new Point(3, 3);
            this.dgvMemberships.Size = new Size(446, 200);
            this.dgvMemberships.ReadOnly = true;
            this.dgvMemberships.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberships.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberships.BackgroundColor = Color.FromArgb(245, 245, 245);
            this.dgvMemberships.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberships.DefaultCellStyle.BackColor = Color.White;
            this.dgvMemberships.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvMemberships.DefaultCellStyle.SelectionBackColor = Color.FromArgb(58, 124, 165);
            this.dgvMemberships.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvMemberships.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            this.dgvMemberships.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // btnDeleteMembership
            this.btnDeleteMembership.Text = "Usuń";
            this.btnDeleteMembership.Location = new Point(175, 215);
            this.btnDeleteMembership.Size = new Size(100, 30);
            this.btnDeleteMembership.BackColor = Color.FromArgb(58, 124, 165);
            this.btnDeleteMembership.ForeColor = Color.White;
            this.btnDeleteMembership.FlatStyle = FlatStyle.Flat;
            this.btnDeleteMembership.Click += new EventHandler(this.btnDeleteMembership_Click);

            // dgvWorkoutPlan
            this.dgvWorkoutPlan.Dock = DockStyle.Fill;
            this.dgvWorkoutPlan.ReadOnly = true;
            this.dgvWorkoutPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkoutPlan.BackgroundColor = Color.FromArgb(245, 245, 245);
            this.dgvWorkoutPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkoutPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkoutPlan.DefaultCellStyle.BackColor = Color.White;
            this.dgvWorkoutPlan.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvWorkoutPlan.DefaultCellStyle.SelectionBackColor = Color.FromArgb(58, 124, 165);
            this.dgvWorkoutPlan.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvWorkoutPlan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            this.dgvWorkoutPlan.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // MemberDetailsForm
            this.ClientSize = new Size(500, 340);
            this.Controls.Add(this.tabControl);
            this.Name = "MemberDetailsForm";
            this.Text = "Szczegóły członka";
            this.Load += new EventHandler(this.MemberDetailsForm_Load);
        }


        #endregion

        private TabControl tabControl;
        private TabPage tabPersonal;
        private TabPage tabAttendance;
        private TabPage tabMemberships;

        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;

        private DataGridView dgvAttendance;
        private DataGridView dgvMemberships;
        private DataGridView dgvWorkoutPlan;
        private Button btnDeleteMembership;
    }
}
