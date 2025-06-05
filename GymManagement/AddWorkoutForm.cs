using System;
using System.Linq;
using System.Windows.Forms;
using GymManagement.Data;
using GymManagement.Models;

namespace GymManagement
{
    public partial class AddWorkoutForm : Form
    {
        private readonly GymDbContext _context;
        private readonly int _memberId;
        private WorkoutPlan _editingWorkout = null!;

        public AddWorkoutForm(int memberId)
        {
            InitializeComponent();
            _context = new GymDbContext();
            _memberId = memberId;
            cmbDay.SelectedIndex = 0;
            LoadWorkouts();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadWorkouts()
        {
            lvWorkouts.Items.Clear();
            string[] dayOrder = new[]
            {
                "Poniedziałek", "Wtorek", "Środa", "Czwartek",
                "Piątek", "Sobota", "Niedziela"
            };

            var workouts = _context.WorkoutPlans
                .Where(w => w.MemberId == _memberId)
                .ToList()
                .OrderBy(w => Array.IndexOf(dayOrder, w.DayOfWeek))
                .ThenBy(w => w.Exercise)
                .ToList();
            foreach (var workout in workouts)
            {
                var item = new ListViewItem(workout.DayOfWeek);
                item.SubItems.Add(workout.Exercise);
                item.SubItems.Add($"{workout.Sets}x{workout.Reps}");
                item.Tag = workout;
                lvWorkouts.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExercise.Text) || cmbDay.SelectedItem == null)
            {
                MessageBox.Show("Wypełnij wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_editingWorkout != null)
            {
                _editingWorkout.Exercise = txtExercise.Text.Trim();
                _editingWorkout.Sets = (int)nudSets.Value;
                _editingWorkout.Reps = (int)nudReps.Value;
                _editingWorkout.DayOfWeek = cmbDay.SelectedItem.ToString()!;
                _context.SaveChanges();
                _editingWorkout = null!;
            }
            else
            {
                var workout = new WorkoutPlan
                {
                    MemberId = _memberId,
                    Exercise = txtExercise.Text.Trim(),
                    Sets = (int)nudSets.Value,
                    Reps = (int)nudReps.Value,
                    DayOfWeek = cmbDay.SelectedItem.ToString()!
                };

                _context.WorkoutPlans.Add(workout);
                _context.SaveChanges();
            }

            ClearInputs();
            LoadWorkouts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvWorkouts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz trening do edycji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = lvWorkouts.SelectedItems[0].Tag as WorkoutPlan;
            if (selected != null)
            {
                _editingWorkout = selected;
                txtExercise.Text = selected.Exercise;
                nudSets.Value = selected.Sets;
                nudReps.Value = selected.Reps;
                cmbDay.SelectedItem = selected.DayOfWeek;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvWorkouts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz trening do usunięcia.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = lvWorkouts.SelectedItems[0].Tag as WorkoutPlan;
            if (selected != null)
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć wybrany trening?", "Potwierdzenie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _context.WorkoutPlans.Remove(selected);
                    _context.SaveChanges();
                    LoadWorkouts();
                }
            }
        }

        private void ClearInputs()
        {
            txtExercise.Clear();
            nudSets.Value = 3;
            nudReps.Value = 10;
            cmbDay.SelectedIndex = 0;
            _editingWorkout = null!;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
