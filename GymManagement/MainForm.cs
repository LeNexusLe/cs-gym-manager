using GymManagement.Data;
using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class MainForm : Form
    {
        private GymDbContext _context;
        private BindingSource _memberBindingSource;

        public MainForm()
        {
            InitializeComponent();
            _memberBindingSource = new BindingSource();
            ConfigureDataGridView();
            LoadMembers();
        }

        private void ConfigureDataGridView()
        {
            dgvMembers.AutoGenerateColumns = false;

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "Imię",
                Name = "colFirstName"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Nazwisko",
                Name = "colLastName"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Name = "colEmail"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Telefon",
                Name = "colPhone"
            });

            dgvMembers.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Aktywne członkostwo",
                Name = "colHasActiveMembership",
                ReadOnly = true
            });

            dgvMembers.DataSource = _memberBindingSource;
        }

        private async void LoadMembers()
        {
            try
            {

                _context?.Dispose();

                _context = new GymDbContext();

                await _context.Members
                    .Include(m => m.Memberships)
                    .Include(m => m.WorkoutPlans)
                    .Include(m => m.Attendances)
                    .LoadAsync();

                _memberBindingSource.DataSource = _context.Members.Local.ToBindingList();

                foreach (DataGridViewRow row in dgvMembers.Rows)
                {
                    if (row.DataBoundItem is Member member)
                    {
                        row.Cells["colHasActiveMembership"].Value = member.Memberships.Any(m => m.IsActive);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            var form = new AddMemberForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newMember = new Member
                {
                    FirstName = form.FirstName,
                    LastName = form.LastName,
                    Email = form.Email,
                    Phone = form.Phone
                };

                _context.Members.Add(newMember);
                _context.SaveChanges();
                LoadMembers();
            }
        }

        private void btnAddMembership_Click(object sender, EventArgs e)
        {
            if (_memberBindingSource.Current is Member selectedMember)
            {
                bool hasActiveMembership = _context.Memberships
                    .Any(m => m.MemberId == selectedMember.Id && m.EndDate >= DateTime.UtcNow);

                if (hasActiveMembership)
                {
                    MessageBox.Show("Ten członek ma już aktywne członkostwo.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var form = new AddMembershipForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var membership = new Membership
                        {
                            MemberId = selectedMember.Id,
                            StartDate = form.StartDate.ToUniversalTime(),
                            EndDate = form.EndDate.ToUniversalTime()
                        };

                        _context.Memberships.Add(membership);
                        _context.SaveChanges();

                        MessageBox.Show("Członkostwo dodane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadMembers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać członka z listy.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            if (_memberBindingSource.Current is Member selectedMember)
            {
                using (var form = new AddWorkoutForm(selectedMember.Id))
                {
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wybierz członka z listy.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (_memberBindingSource.Current is Member selectedMember)
            {
                var attendance = new Attendance
                {
                    MemberId = selectedMember.Id,
                    CheckInDate = DateTime.UtcNow
                };

                _context.Attendances.Add(attendance);
                _context.SaveChanges();

                MessageBox.Show($"{selectedMember.FirstName} {selectedMember.LastName} został zarejestrowany!", "Wejście zarejestrowane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMembers();
            }
            else
            {
                MessageBox.Show("Proszę wybrać członka z listy", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            if (_memberBindingSource.Current is Member selectedMember)
            {
                var form = new MemberDetailsForm(selectedMember.Id);
                form.ShowDialog();
                form.FormClosed += (s, e) => LoadMembers();

            }
            else
            {
                MessageBox.Show("Proszę wybrać członka z listy.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context?.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }
    }
}