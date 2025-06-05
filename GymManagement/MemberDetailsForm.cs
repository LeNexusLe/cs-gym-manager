using GymManagement.Data;
using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class MemberDetailsForm : Form
    {
        private readonly int _memberId;
        private Member? _member;

        public MemberDetailsForm(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void MemberDetailsForm_Load(object sender, EventArgs e)
        {
            LoadMemberData();
            LoadAttendances();
            LoadMemberships();
        }

        private void LoadMemberData()
        {
            using var db = new GymDbContext();

            _member = db.Members.Find(_memberId);
            if (_member == null)
            {
                MessageBox.Show("Nie znaleziono członka.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            txtFirstName.Text = _member.FirstName;
            txtLastName.Text = _member.LastName;
            txtEmail.Text = _member.Email;
            txtPhone.Text = _member.Phone;
        }

        private void LoadAttendances()
        {
            using var db = new GymDbContext();

            var attendanceList = db.Attendances
                .Where(a => a.MemberId == _memberId)
                .OrderByDescending(a => a.CheckInDate)
                .Select(a => new
                {
                    a.CheckInDate
                })
                .ToList();

            dgvAttendance.DataSource = attendanceList;
        }

        private void LoadMemberships()
        {
            using var db = new GymDbContext();

            var memberships = db.Memberships
                .Where(m => m.MemberId == _memberId)
                .OrderByDescending(m => m.StartDate)
                .Select(m => new
                {
                    m.Id,
                    m.StartDate,
                    m.EndDate,
                    Status = m.IsActive ? "Aktywne" : "Nieaktywne"
                })
                .ToList();

            dgvMemberships.DataSource = memberships;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Proszę podać imię.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Proszę podać nazwisko.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    MessageBox.Show("Proszę podać poprawny adres email.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                string phonePattern = @"^\d{9}$";
                if (!Regex.IsMatch(txtPhone.Text, phonePattern))
                {
                    MessageBox.Show("Telefon musi zawierać dokładnie 9 cyfr.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_member == null)
                return;

            if (!ValidateForm())
                return;

            using var db = new GymDbContext();

            var memberToUpdate = db.Members.Find(_memberId);
            if (memberToUpdate == null)
                return;

            memberToUpdate.FirstName = txtFirstName.Text;
            memberToUpdate.LastName = txtLastName.Text;
            memberToUpdate.Email = txtEmail.Text;
            memberToUpdate.Phone = txtPhone.Text;

            db.SaveChanges();

            MessageBox.Show("Zapisano zmiany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteMembership_Click(object sender, EventArgs e)
        {
            if (dgvMemberships.CurrentRow == null)
                return;

            int membershipId = (int)dgvMemberships.CurrentRow.Cells["Id"].Value;

            var confirm = MessageBox.Show("Czy na pewno chcesz usunąć to członkostwo?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            using var db = new GymDbContext();

            var membership = db.Memberships.Find(membershipId);
            if (membership != null)
            {
                db.Memberships.Remove(membership);
                db.SaveChanges();
                LoadMemberships();
            }
        }
    }
}
