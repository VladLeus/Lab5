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
    public partial class Researches : Form
    {
        private Research research;
        private List<Publication> pubs;
        private bool isAdding;
        private bool isSaved;
        private ErrorProvider errorProvider;
        public Researches(Research research, bool isAdding)
        {
            InitializeComponent();
            this.research = research;
            this.isAdding = isAdding;
            pubs = new List<Publication>();
            if (!isAdding)
                pubs = research.Publications.ToList();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void Researches_Load(object sender, EventArgs e)
        {
            Edit.Enabled = false;
            Remove.Enabled = false;
            InputsPlaceholders();
            ActiveControl = Organization;
        }

        private void InputsPlaceholders()
        {
            if (!isAdding)
            {
                OrgName.Text = research.Customer.OrganizationName;
                Theme.Text = research.Customer.ResearchTheme;
                Cost.Text = research.Customer.Cost.ToString();
                Date.Value = research.SigningDate;
                pubs.ForEach(elem => PublicationList.Items.Add(elem));
            }            
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            pubs.RemoveAt(PublicationList.SelectedIndex);
            PublicationList.Items.RemoveAt(PublicationList.SelectedIndex);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Publication selected = pubs[PublicationList.SelectedIndex];
            PublicationAdd editPubForm = new PublicationAdd(selected, false);
            editPubForm.ShowDialog();
            if (editPubForm.DialogResult == DialogResult.OK)
            {
                pubs[PublicationList.SelectedIndex] = selected;
                PublicationList.Items[PublicationList.SelectedIndex] = selected.ToString();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Publication newPublic = new Publication();
            PublicationAdd newPubForm = new PublicationAdd(newPublic, true);
            newPubForm.ShowDialog();
            if(newPubForm.DialogResult == DialogResult.OK)
            {
                pubs.Add(newPublic);
                PublicationList.Items.Add(newPublic);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                isSaved = true;
                SaveProps(research);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                isSaved = false;
                MessageBox.Show("Invalid inputs, try again!");
            }
        }

        private void SaveProps(Research research)
        {
            research.Customer = new Customer();
            research.Customer.OrganizationName = OrgName.Text;
            research.Customer.ResearchTheme = Theme.Text;
            research.Customer.Cost = int.Parse(Cost.Text);
            research.SigningDate = Date.Value.Date;
            research.Publications = pubs.ToList();
        }

        private void PublicationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PublicationList.SelectedIndex == -1)
            {
                Remove.Enabled = false;
                Edit.Enabled = false;
                Add.Enabled = true;
            }
            else
            {
                Remove.Enabled = true;
                Edit.Enabled = true;
                Add.Enabled = false;
            }
        }

        private void OrgName_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[A-Za-z_]{1,30}$");
            if (!regex.IsMatch(OrgName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((TextBox)sender, "Name cant contain numbers or more than 1 uppercase letter");
            }
            else
            {
                errorProvider.SetError((TextBox)sender, null);
            }
        }

        private void Theme_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[A-Za-z_]{1,30}$");
            if (!regex.IsMatch(Theme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((TextBox)sender, "Name cant contain numbers or more than 1 uppercase letter");
            }
            else
            {
                errorProvider.SetError((TextBox)sender, null);
            }
        }

        private void Cost_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!0$)(?:[1-9]\d{0,4}|100000)$");
            if (!regex.IsMatch(Cost.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((TextBox)sender, "Name cant contain numbers or more than 1 uppercase letter");
            }
            else
            {
                errorProvider.SetError((TextBox)sender, null);
            }
        }

        private void Researches_FormClosing(object sender, FormClosingEventArgs e)
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
                        SaveProps(research);
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

        private void Researches_Click(object sender, EventArgs e)
        {
            PublicationList.ClearSelected();
        }
    }
}
