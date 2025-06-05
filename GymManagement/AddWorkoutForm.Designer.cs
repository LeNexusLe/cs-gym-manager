namespace GymManagement
{
    partial class AddWorkoutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblExercise = new Label();
            txtExercise = new TextBox();
            lblSets = new Label();
            nudSets = new NumericUpDown();
            lblReps = new Label();
            nudReps = new NumericUpDown();
            lblDay = new Label();
            cmbDay = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lvWorkouts = new ListView();
            btnEdit = new Button();
            btnDelete = new Button();

            SuspendLayout();

            // lblExercise
            lblExercise.Text = "Ćwiczenie:";
            lblExercise.Location = new Point(20, 20);
            lblExercise.AutoSize = true;

            // txtExercise
            txtExercise.Location = new Point(120, 17);
            txtExercise.Size = new Size(200, 23);

            // lblSets
            lblSets.Text = "Serie:";
            lblSets.Location = new Point(20, 60);
            lblSets.AutoSize = true;

            // nudSets
            nudSets.Location = new Point(120, 57);
            nudSets.Minimum = 1;
            nudSets.Maximum = 20;
            nudSets.Value = 3;
            nudSets.Size = new Size(60, 23);

            // lblReps
            lblReps.Text = "Powtórzenia:";
            lblReps.Location = new Point(20, 100);
            lblReps.AutoSize = true;

            // nudReps
            nudReps.Location = new Point(120, 97);
            nudReps.Minimum = 1;
            nudReps.Maximum = 100;
            nudReps.Value = 10;
            nudReps.Size = new Size(60, 23);

            // lblDay
            lblDay.Text = "Dzień tygodnia:";
            lblDay.Location = new Point(20, 140);
            lblDay.AutoSize = true;

            // cmbDay
            cmbDay.Location = new Point(120, 137);
            cmbDay.Size = new Size(200, 23);
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.Items.AddRange(new string[]
            {
        "Poniedziałek", "Wtorek", "Środa", "Czwartek",
        "Piątek", "Sobota", "Niedziela"
            });

            // btnSave
            btnSave.Text = "Dodaj/Edytuj";
            btnSave.Location = new Point(120, 180);
            btnSave.Size = new Size(90, 30);
            btnSave.BackColor = Color.FromArgb(58, 124, 165);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += new EventHandler(btnSave_Click);

            // btnCancel
            btnCancel.Text = "Zamknij";
            btnCancel.Location = new Point(220, 180);
            btnCancel.Size = new Size(90, 30);
            btnCancel.BackColor = Color.FromArgb(150, 150, 150);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += new EventHandler(btnCancel_Click);

            // lvWorkouts
            lvWorkouts.Location = new Point(20, 230);
            lvWorkouts.Size = new Size(300, 200);
            lvWorkouts.View = View.Details;
            lvWorkouts.FullRowSelect = true;
            lvWorkouts.Columns.Add("Dzień", 100);
            lvWorkouts.Columns.Add("Ćwiczenie", 100);
            lvWorkouts.Columns.Add("Serie/Powt.", 100);

            // btnEdit
            btnEdit.Text = "Edytuj";
            btnEdit.Location = new Point(20, 440);
            btnEdit.Size = new Size(90, 30);
            btnEdit.BackColor = Color.FromArgb(58, 124, 165);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += new EventHandler(btnEdit_Click);

            // btnDelete
            btnDelete.Text = "Usuń";
            btnDelete.Location = new Point(120, 440);
            btnDelete.Size = new Size(90, 30);
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new EventHandler(btnDelete_Click);

            // Dodaj kontrolki do formularza
            Controls.Add(lblExercise);
            Controls.Add(txtExercise);
            Controls.Add(lblSets);
            Controls.Add(nudSets);
            Controls.Add(lblReps);
            Controls.Add(nudReps);
            Controls.Add(lblDay);
            Controls.Add(cmbDay);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lvWorkouts);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);

            ClientSize = new Size(360, 500);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Plan Treningowy";
            BackColor = Color.White;

            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblExercise;
        private TextBox txtExercise;
        private Label lblSets;
        private NumericUpDown nudSets;
        private Label lblReps;
        private NumericUpDown nudReps;
        private Label lblDay;
        private ComboBox cmbDay;
        private Button btnSave;
        private Button btnCancel;
        private ListView lvWorkouts;
        private Button btnEdit;
        private Button btnDelete;
    }
}