﻿
namespace FileFilterFile
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
            this.bt_dir_sorce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.tb_target = new System.Windows.Forms.TextBox();
            this.bt_dir_target = new System.Windows.Forms.Button();
            this.cb_autoFill = new System.Windows.Forms.CheckBox();
            this.bt_check = new System.Windows.Forms.Button();
            this.bt_execute = new System.Windows.Forms.Button();
            this.bt_help = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_oepn_source = new System.Windows.Forms.Button();
            this.bt_open_target = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_dir_sorce
            // 
            this.bt_dir_sorce.Location = new System.Drawing.Point(606, 10);
            this.bt_dir_sorce.Name = "bt_dir_sorce";
            this.bt_dir_sorce.Size = new System.Drawing.Size(37, 23);
            this.bt_dir_sorce.TabIndex = 0;
            this.bt_dir_sorce.Text = ". . .";
            this.bt_dir_sorce.UseVisualStyleBackColor = true;
            this.bt_dir_sorce.Click += new System.EventHandler(this.bt_dir_sorce_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder źródłowy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folder docelowy:";
            // 
            // tb_source
            // 
            this.tb_source.Location = new System.Drawing.Point(105, 12);
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(441, 20);
            this.tb_source.TabIndex = 4;
            this.tb_source.TextChanged += new System.EventHandler(this.tb_source_TextChanged);
            // 
            // tb_target
            // 
            this.tb_target.Location = new System.Drawing.Point(105, 38);
            this.tb_target.Name = "tb_target";
            this.tb_target.Size = new System.Drawing.Size(441, 20);
            this.tb_target.TabIndex = 5;
            this.tb_target.TextChanged += new System.EventHandler(this.tb_target_TextChanged);
            // 
            // bt_dir_target
            // 
            this.bt_dir_target.Location = new System.Drawing.Point(606, 36);
            this.bt_dir_target.Name = "bt_dir_target";
            this.bt_dir_target.Size = new System.Drawing.Size(37, 23);
            this.bt_dir_target.TabIndex = 6;
            this.bt_dir_target.Text = ". . .";
            this.bt_dir_target.UseVisualStyleBackColor = true;
            this.bt_dir_target.Click += new System.EventHandler(this.bt_dir_target_Click);
            // 
            // cb_autoFill
            // 
            this.cb_autoFill.AutoSize = true;
            this.cb_autoFill.Checked = true;
            this.cb_autoFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_autoFill.Enabled = false;
            this.cb_autoFill.Location = new System.Drawing.Point(439, 68);
            this.cb_autoFill.Name = "cb_autoFill";
            this.cb_autoFill.Size = new System.Drawing.Size(134, 17);
            this.cb_autoFill.TabIndex = 12;
            this.cb_autoFill.Text = "Usuń przeniesonie pliki";
            this.cb_autoFill.UseVisualStyleBackColor = true;
            this.cb_autoFill.CheckedChanged += new System.EventHandler(this.cb_autoFill_CheckedChanged);
            // 
            // bt_check
            // 
            this.bt_check.Location = new System.Drawing.Point(273, 64);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(75, 23);
            this.bt_check.TabIndex = 13;
            this.bt_check.Text = "Sprawdz";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // bt_execute
            // 
            this.bt_execute.Location = new System.Drawing.Point(354, 64);
            this.bt_execute.Name = "bt_execute";
            this.bt_execute.Size = new System.Drawing.Size(75, 23);
            this.bt_execute.TabIndex = 26;
            this.bt_execute.Text = "Przenies";
            this.bt_execute.UseVisualStyleBackColor = true;
            this.bt_execute.Click += new System.EventHandler(this.bt_execute_Click);
            // 
            // bt_help
            // 
            this.bt_help.Location = new System.Drawing.Point(579, 64);
            this.bt_help.Name = "bt_help";
            this.bt_help.Size = new System.Drawing.Size(64, 23);
            this.bt_help.TabIndex = 27;
            this.bt_help.Text = "Pomoc";
            this.bt_help.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(255, 200);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Folder";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ilość";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rozmiar";
            // 
            // bt_oepn_source
            // 
            this.bt_oepn_source.Enabled = false;
            this.bt_oepn_source.Location = new System.Drawing.Point(552, 10);
            this.bt_oepn_source.Name = "bt_oepn_source";
            this.bt_oepn_source.Size = new System.Drawing.Size(48, 23);
            this.bt_oepn_source.TabIndex = 29;
            this.bt_oepn_source.Text = "Otwórz";
            this.bt_oepn_source.UseVisualStyleBackColor = true;
            this.bt_oepn_source.Click += new System.EventHandler(this.bt_oepn_source_Click);
            // 
            // bt_open_target
            // 
            this.bt_open_target.Enabled = false;
            this.bt_open_target.Location = new System.Drawing.Point(552, 36);
            this.bt_open_target.Name = "bt_open_target";
            this.bt_open_target.Size = new System.Drawing.Size(48, 23);
            this.bt_open_target.TabIndex = 30;
            this.bt_open_target.Text = "Otwórz";
            this.bt_open_target.UseVisualStyleBackColor = true;
            this.bt_open_target.Click += new System.EventHandler(this.bt_open_target_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(273, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 147);
            this.listBox1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Other:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_open_target);
            this.Controls.Add(this.bt_oepn_source);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_help);
            this.Controls.Add(this.bt_execute);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.cb_autoFill);
            this.Controls.Add(this.bt_dir_target);
            this.Controls.Add(this.tb_target);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_dir_sorce);
            this.Name = "Form1";
            this.Text = "FileFilterLite 1.00";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_dir_sorce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.TextBox tb_target;
        private System.Windows.Forms.Button bt_dir_target;
        private System.Windows.Forms.CheckBox cb_autoFill;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.Button bt_execute;
        private System.Windows.Forms.Button bt_help;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button bt_oepn_source;
        private System.Windows.Forms.Button bt_open_target;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}

