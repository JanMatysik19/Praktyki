namespace Zadanie30
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textExcuse = new System.Windows.Forms.TextBox();
            this.textResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fileData = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.randomExcuse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wymówka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wyniki";
            // 
            // textExcuse
            // 
            this.textExcuse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textExcuse.Location = new System.Drawing.Point(107, 6);
            this.textExcuse.Name = "textExcuse";
            this.textExcuse.Size = new System.Drawing.Size(243, 20);
            this.textExcuse.TabIndex = 2;
            this.textExcuse.TextChanged += new System.EventHandler(this.textExcuse_TextChanged);
            // 
            // textResults
            // 
            this.textResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResults.Location = new System.Drawing.Point(107, 32);
            this.textResults.Name = "textResults";
            this.textResults.Size = new System.Drawing.Size(243, 20);
            this.textResults.TabIndex = 3;
            this.textResults.TextChanged += new System.EventHandler(this.textResults_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ostatnie użyte";
            // 
            // lastUsed
            // 
            this.lastUsed.CustomFormat = "d MMMM yyyy";
            this.lastUsed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastUsed.Location = new System.Drawing.Point(107, 58);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(225, 20);
            this.lastUsed.TabIndex = 5;
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data pliku";
            // 
            // fileData
            // 
            this.fileData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileData.Location = new System.Drawing.Point(107, 85);
            this.fileData.Name = "fileData";
            this.fileData.Size = new System.Drawing.Size(243, 17);
            this.fileData.TabIndex = 7;
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(12, 110);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(75, 23);
            this.directory.TabIndex = 8;
            this.directory.Text = "Folder";
            this.directory.UseVisualStyleBackColor = true;
            this.directory.Click += new System.EventHandler(this.directory_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(93, 110);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Enabled = false;
            this.open.Location = new System.Drawing.Point(174, 110);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 10;
            this.open.Text = "Otwórz";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // randomExcuse
            // 
            this.randomExcuse.Enabled = false;
            this.randomExcuse.Location = new System.Drawing.Point(255, 110);
            this.randomExcuse.Name = "randomExcuse";
            this.randomExcuse.Size = new System.Drawing.Size(115, 23);
            this.randomExcuse.TabIndex = 11;
            this.randomExcuse.Text = "Losowa wymówka";
            this.randomExcuse.UseVisualStyleBackColor = true;
            this.randomExcuse.Click += new System.EventHandler(this.randomExcuse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 142);
            this.Controls.Add(this.randomExcuse);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.fileData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textResults);
            this.Controls.Add(this.textExcuse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Program do zarządzania wymówkami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textExcuse;
        private System.Windows.Forms.TextBox textResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fileData;
        private System.Windows.Forms.Button directory;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button randomExcuse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

