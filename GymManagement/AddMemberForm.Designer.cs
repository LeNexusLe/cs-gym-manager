namespace GymManagement
{
    partial class AddMemberForm
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            panel1 = new Panel();

            panel1.SuspendLayout();
            SuspendLayout();

            // lblFirstName
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(20, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(30, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Imię:";

            // txtFirstName
            txtFirstName.Location = new Point(120, 17);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.BackColor = Color.White;
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;

            // lblLastName
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(20, 60);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Nazwisko:";

            // txtLastName
            txtLastName.Location = new Point(120, 57);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 23);
            txtLastName.TabIndex = 3;
            txtLastName.BackColor = Color.White;
            txtLastName.ForeColor = Color.Black;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";

            // txtEmail
            txtEmail.Location = new Point(120, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 5;
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.Black;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;

            // lblPhone
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 140);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Telefon:";

            // txtPhone
            txtPhone.Location = new Point(120, 137);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 23);
            txtPhone.TabIndex = 7;
            txtPhone.BackColor = Color.White;
            txtPhone.ForeColor = Color.Black;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;

            // btnSave
            btnSave.Location = new Point(120, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.BackColor = Color.FromArgb(58, 124, 165);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Click += btnSave_Click;

            // btnCancel
            btnCancel.Location = new Point(230, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.BackColor = Color.FromArgb(150, 150, 150);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Click += btnCancel_Click;

            // panel1
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 230);
            panel1.TabIndex = 10;
            panel1.BackColor = Color.White;

            // AddMemberForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 250);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddMemberForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj członka";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnSave;
        private Button btnCancel;
        private Panel panel1;
    }
}