using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie30
{
    public partial class Form1 : Form
    {
        private Excuse currExcuse = new Excuse(new Random());
        private string selectedFolder = "";
        private bool formChanged = false;

        public Form1()
        {
            InitializeComponent();

            currExcuse.LastUsed = lastUsed.Value;
        }

        private void directory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save.Enabled = true;
                open.Enabled = true;
                randomExcuse.Enabled = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textExcuse.Text) || String.IsNullOrEmpty(textResults.Text))
            {
                MessageBox.Show("Określ wymówkę i rezultat", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Plikit tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FileName = textExcuse.Text + ".txt";
            
            
            DialogResult result = saveFileDialog1.ShowDialog();

            if(result == DialogResult.OK )
            {
                currExcuse.Description = textExcuse.Text;
                currExcuse.Results = textResults.Text;
                currExcuse.LastUsed = lastUsed.Value;

                currExcuse.Save(saveFileDialog1.FileName);
                MessageBox.Show("Wymówka zapisana");

                UpdateForms(false);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            //if(!String.IsNullOrEmpty(textExcuse.Text) || !String.IsNullOrEmpty(textResults.Text))
            if(formChanged)
            {
                DialogResult warring = MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (warring == DialogResult.No) return;
            }

            openFileDialog1.InitialDirectory = selectedFolder;
            openFileDialog1.Filter = "Plikit tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";

            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK )
            {
                currExcuse.OpenFile(openFileDialog1.FileName);
                MessageBox.Show("Wymówka otworzona");

                UpdateForms(false);
            }
        }

        private void randomExcuse_Click(object sender, EventArgs e)
        {
            if (formChanged)
            {
                DialogResult warring = MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (warring == DialogResult.No) return;
            }

            string[] files = Directory.GetFiles(selectedFolder);
            currExcuse.OpenFile(files);

            UpdateForms(false);
        }


        private void UpdateForms(bool changed)
        {
            if (!changed)
            {
                textExcuse.Text = currExcuse.Description;
                textResults.Text = currExcuse.Results;
                lastUsed.Value = currExcuse.LastUsed;

                if (!String.IsNullOrEmpty(currExcuse.ExcusePath)) fileData.Text = File.GetLastWriteTime(currExcuse.ExcusePath).ToString();
                Text = "Program do zarządzania wymówkami";
            }
            else Text = "Program do zarządzania wymówkami*";
            formChanged = changed;
        }

        private void textExcuse_TextChanged(object sender, EventArgs e)
        {
            currExcuse.Description = textExcuse.Text;
            UpdateForms(true);
        }

        private void textResults_TextChanged(object sender, EventArgs e)
        {
            currExcuse.Results = textResults.Text;
            UpdateForms(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currExcuse.LastUsed = lastUsed.Value;
            UpdateForms(true);
        }
    }
}
