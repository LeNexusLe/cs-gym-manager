namespace GymManagement
{
    partial class MainForm
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
            dgvMembers = new DataGridView();
            btnAddMember = new Button();
            btnAddMembership = new Button();
            btnAddWorkout = new Button();
            btnCheckIn = new Button();
            lblTitle = new Label();
            btnUserDetails = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();

            // === OGÓLNY STYL OKNA ===
            BackColor = Color.White;
            ForeColor = Color.Black;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // === STYL PRZYCISKÓW ===
            void StyleButton(Button btn)
            {
                btn.BackColor = Color.FromArgb(58, 124, 165);  // wyblakły niebieski
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }

            // === dgvMembers ===
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(12, 60);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(876, 300);
            dgvMembers.TabIndex = 0;
            dgvMembers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMembers.BackgroundColor = Color.FromArgb(245, 245, 245);
            dgvMembers.DefaultCellStyle.BackColor = Color.White;
            dgvMembers.DefaultCellStyle.ForeColor = Color.Black;
            dgvMembers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(58, 124, 165);
            dgvMembers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvMembers.EnableHeadersVisualStyles = false;

            // === lblTitle ===
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(338, 32);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "System zarządzania siłownią";
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);

            // === btnAddMember ===
            btnAddMember.Location = new Point(12, 370);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(150, 30);
            btnAddMember.TabIndex = 1;
            btnAddMember.Text = "Dodaj członka";
            btnAddMember.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StyleButton(btnAddMember);
            btnAddMember.Click += btnAddMember_Click;

            // === btnAddMembership ===
            btnAddMembership.Location = new Point(168, 370);
            btnAddMembership.Name = "btnAddMembership";
            btnAddMembership.Size = new Size(150, 30);
            btnAddMembership.TabIndex = 2;
            btnAddMembership.Text = "Dodaj członkostwo";
            btnAddMembership.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StyleButton(btnAddMembership);
            btnAddMembership.Click += btnAddMembership_Click;

            // === btnAddWorkout ===
            btnAddWorkout.Location = new Point(324, 370);
            btnAddWorkout.Name = "btnAddWorkout";
            btnAddWorkout.Size = new Size(180, 30);
            btnAddWorkout.TabIndex = 3;
            btnAddWorkout.Text = "Informacje Treningowe";
            btnAddWorkout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StyleButton(btnAddWorkout);
            btnAddWorkout.Click += btnAddWorkout_Click;

            // === btnCheckIn ===
            btnCheckIn.Location = new Point(510, 370);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(150, 30);
            btnCheckIn.TabIndex = 4;
            btnCheckIn.Text = "Zarejestruj wejście";
            btnCheckIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StyleButton(btnCheckIn);
            btnCheckIn.Click += btnCheckIn_Click;

            // === btnUserDetails ===
            btnUserDetails.Location = new Point(710, 370);
            btnUserDetails.Name = "btnUserDetails";
            btnUserDetails.Size = new Size(180, 30);
            btnUserDetails.TabIndex = 5;
            btnUserDetails.Text = "Informacje o członku";
            btnUserDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StyleButton(btnUserDetails);
            btnUserDetails.Click += btnUserDetails_Click;

            // === btnRefresh ===
            btnRefresh.Location = new Point(738, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 30);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Odśwież";
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StyleButton(btnRefresh);
            btnRefresh.Click += btnRefresh_Click;

            // === MainForm ===
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 412);
            Controls.Add(btnRefresh);
            Controls.Add(btnUserDetails);
            Controls.Add(lblTitle);
            Controls.Add(btnCheckIn);
            Controls.Add(btnAddWorkout);
            Controls.Add(btnAddMembership);
            Controls.Add(btnAddMember);
            Controls.Add(dgvMembers);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Management System";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView dgvMembers;
        private Button btnAddMember;
        private Button btnAddMembership;
        private Button btnAddWorkout;
        private Button btnCheckIn;
        private Button btnUserDetails;
        private Label lblTitle;
        private Button button1;
        private Button btnRefresh;
    }
}