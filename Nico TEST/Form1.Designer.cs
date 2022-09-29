
namespace Nico_TEST
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDaten = new System.Windows.Forms.DataGridView();
            this.cbbLaender = new System.Windows.Forms.ComboBox();
            this.btEinlessen = new System.Windows.Forms.Button();
            this.btAugaben = new System.Windows.Forms.Button();
            this.txtPlz = new System.Windows.Forms.TextBox();
            this.lblBund = new System.Windows.Forms.Label();
            this.lblPlz = new System.Windows.Forms.Label();
            this.pgbVortschrit = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaten)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDaten
            // 
            this.dgvDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaten.Location = new System.Drawing.Point(279, 12);
            this.dgvDaten.Name = "dgvDaten";
            this.dgvDaten.RowTemplate.Height = 25;
            this.dgvDaten.Size = new System.Drawing.Size(709, 426);
            this.dgvDaten.TabIndex = 0;
            // 
            // cbbLaender
            // 
            this.cbbLaender.FormattingEnabled = true;
            this.cbbLaender.Location = new System.Drawing.Point(108, 41);
            this.cbbLaender.Name = "cbbLaender";
            this.cbbLaender.Size = new System.Drawing.Size(144, 23);
            this.cbbLaender.TabIndex = 1;
            this.cbbLaender.SelectedIndexChanged += new System.EventHandler(this.cbbLaender_SelectedIndexChanged);
            // 
            // btEinlessen
            // 
            this.btEinlessen.Location = new System.Drawing.Point(108, 70);
            this.btEinlessen.Name = "btEinlessen";
            this.btEinlessen.Size = new System.Drawing.Size(144, 23);
            this.btEinlessen.TabIndex = 2;
            this.btEinlessen.Text = "Einlesen";
            this.btEinlessen.UseVisualStyleBackColor = true;
            this.btEinlessen.Click += new System.EventHandler(this.btEinlessen_Click);
            // 
            // btAugaben
            // 
            this.btAugaben.Location = new System.Drawing.Point(23, 415);
            this.btAugaben.Name = "btAugaben";
            this.btAugaben.Size = new System.Drawing.Size(229, 23);
            this.btAugaben.TabIndex = 3;
            this.btAugaben.Text = "Ausgeben";
            this.btAugaben.UseVisualStyleBackColor = true;
            this.btAugaben.Click += new System.EventHandler(this.btAugaben_Click);
            // 
            // txtPlz
            // 
            this.txtPlz.Location = new System.Drawing.Point(108, 99);
            this.txtPlz.Name = "txtPlz";
            this.txtPlz.Size = new System.Drawing.Size(144, 23);
            this.txtPlz.TabIndex = 4;
            this.txtPlz.TextChanged += new System.EventHandler(this.txtPlz_TextChanged);
            // 
            // lblBund
            // 
            this.lblBund.AutoSize = true;
            this.lblBund.Location = new System.Drawing.Point(23, 44);
            this.lblBund.Name = "lblBund";
            this.lblBund.Size = new System.Drawing.Size(79, 15);
            this.lblBund.TabIndex = 5;
            this.lblBund.Text = "Bundesländer";
            // 
            // lblPlz
            // 
            this.lblPlz.AutoSize = true;
            this.lblPlz.Location = new System.Drawing.Point(25, 102);
            this.lblPlz.Name = "lblPlz";
            this.lblPlz.Size = new System.Drawing.Size(61, 15);
            this.lblPlz.TabIndex = 6;
            this.lblPlz.Text = "PLZ suche";
            // 
            // pgbVortschrit
            // 
            this.pgbVortschrit.Location = new System.Drawing.Point(23, 386);
            this.pgbVortschrit.Name = "pgbVortschrit";
            this.pgbVortschrit.Size = new System.Drawing.Size(229, 23);
            this.pgbVortschrit.Step = 1;
            this.pgbVortschrit.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbVortschrit.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.pgbVortschrit);
            this.Controls.Add(this.lblPlz);
            this.Controls.Add(this.lblBund);
            this.Controls.Add(this.txtPlz);
            this.Controls.Add(this.btAugaben);
            this.Controls.Add(this.btEinlessen);
            this.Controls.Add(this.cbbLaender);
            this.Controls.Add(this.dgvDaten);
            this.Name = "Form1";
            this.Text = "KML Sotirumg";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDaten;
        private System.Windows.Forms.ComboBox cbbLaender;
        private System.Windows.Forms.Button btEinlessen;
        private System.Windows.Forms.Button btAugaben;
        private System.Windows.Forms.TextBox txtPlz;
        private System.Windows.Forms.Label lblBund;
        private System.Windows.Forms.Label lblPlz;
        public System.Windows.Forms.ProgressBar pgbVortschrit;
    }
}

