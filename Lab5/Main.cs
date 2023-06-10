using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResearchLibrary;
using Lab5.DTO;

namespace Lab5
{
    public partial class Main : Form
    {
        private List<Research> researches;
        public Main()
        {
            InitializeComponent();
            Click += Main_Click;
            researches = new List<Research>();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            ResearchList.ClearSelected();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Remove.Enabled = false;
            Edit.Enabled = false;
            try
            {
                string json = File.ReadAllText("researches.json");
                researches = JsonSerializer.Deserialize<List<ResearchDTO>>(json)
                    .Select(DTOConverter.ConvertToResearch).ToList();
                researches.ForEach(research => ResearchList.Items.Add(research.ToShortString()));
            }
            catch (JsonException)
            {
                MessageBox.Show("Json EX");
            }
        }

        private void ResearchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResearchList.SelectedIndex == -1)
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

        private void Add_Click(object sender, EventArgs e)
        {
            Research newResearch = new Research();
            Researches researchesForm = new Researches(newResearch, true);
            researchesForm.ShowDialog();
            DialogResult result = researchesForm.DialogResult;
            if (result == DialogResult.OK)
            {
                researches.Add(newResearch);
                ResearchList.Items.Add(newResearch.ToShortString());
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            researches.RemoveAt(ResearchList.SelectedIndex);
            ResearchList.Items.RemoveAt(ResearchList.SelectedIndex);
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            Research selectedResearch = researches[ResearchList.SelectedIndex];
            Researches researchesForm = new Researches(selectedResearch, false);
            researchesForm.ShowDialog();
            DialogResult result = researchesForm.DialogResult;
            if (result == DialogResult.OK)
                ResearchList.Items[ResearchList.SelectedIndex] = selectedResearch.ToShortString();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(researches.Select(DTOConverter.ConvertToResearchDTO).ToList(), new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("researches.json", json);
            }
            catch (Exception)
            {
                MessageBox.Show("SomeEx occured");
            }
        }
    }
}