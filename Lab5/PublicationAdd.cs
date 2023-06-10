using ResearchLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class PublicationAdd : Form
    {
        private bool isAdding;
        private bool isSaved;
        private Publication pub;
        private ErrorProvider errorProvider;
        public PublicationAdd(Publication publication, bool isAdding)
        {
            InitializeComponent();
            this.pub = publication;
            this.isAdding = isAdding;
            this.isSaved = false;

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void InputsPlaceholders()
        {
            StudentName.Text = pub.Student.Name;
            Surname.Text = pub.Student.Surname;
            Date.Value = pub.Student.EnrollmentYear;
            Achivments.SelectedItem = Enum.Parse<ScientificAchivments>(pub.ScientificAchivments.ToString()).ToString();
        }

        private void Publication_Load(object sender, EventArgs e)
        {
            Enum.GetValues(typeof(ScientificAchivments)).Cast<ScientificAchivments>()
                .Select(item => item.ToString()).ToList()
                .ForEach(elem => Achivments.Items.Add(elem));
            if (!isAdding)
            {
                InputsPlaceholders();
            }
            else { Achivments.SelectedItem = Achivments.Items[0]; }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                isSaved = true;
                SaveProps(pub);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                isSaved = false;
                MessageBox.Show("Invalid inputs, try again!");
            }
        }

        private void SaveProps(Publication pub)
        {
            pub.Student = new Student();
            pub.Student.Name = StudentName.Text;
            pub.Student.Surname = Surname.Text;
            pub.Student.EnrollmentYear = Date.Value.Date;
            pub.ScientificAchivments = Enum.Parse<ScientificAchivments>(Achivments.SelectedItem.ToString());
        }

        private void PublicationAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!isAdding && !isSaved)
                {
                    DialogResult result = MessageBox.Show("Apply changes?",
                        "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SaveProps(pub);
                        DialogResult = DialogResult.OK;
                    }
                    else
                        DialogResult = DialogResult.Cancel;
                }                   
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException)
            {
                MessageBox.Show("Invalid inputs!");
                DialogResult result = MessageBox.Show("Close without saving?",
                    "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void StudentName_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[A-Z][a-z]{0,9}$");
            if (!regex.IsMatch(StudentName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((TextBox)sender, "Name cant contain numbers or more than 1 uppercase letter");
            }
            else
            {
                errorProvider.SetError((TextBox)sender, null);
            }
        }

        private void Surname_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[A-Z][a-z]{0,9}$");
            if (!regex.IsMatch(Surname.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((TextBox)sender, "Name cant contain numbers or more than 1 uppercase letter");
            }
            else
            {
                errorProvider.SetError((TextBox)sender, null);
            }
        }
    }
}
