using System.Windows.Forms;

namespace Receptsnurran
{
    partial class Receptsnurran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastPrescriptionDate = new System.Windows.Forms.TextBox();
            this.textBoxTotalTablets = new System.Windows.Forms.TextBox();
            this.textBoxDailyDosage = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.itkalle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senaste receptdatum (ÅÅMMDD)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antal tabletter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dosering per dag";
            // 
            // textBoxLastPrescriptionDate
            // 
            this.textBoxLastPrescriptionDate.Location = new System.Drawing.Point(202, 12);
            this.textBoxLastPrescriptionDate.Name = "textBoxLastPrescriptionDate";
            this.textBoxLastPrescriptionDate.Size = new System.Drawing.Size(82, 20);
            this.textBoxLastPrescriptionDate.TabIndex = 4;
            // 
            // textBoxTotalTablets
            // 
            this.textBoxTotalTablets.Location = new System.Drawing.Point(202, 38);
            this.textBoxTotalTablets.Name = "textBoxTotalTablets";
            this.textBoxTotalTablets.Size = new System.Drawing.Size(82, 20);
            this.textBoxTotalTablets.TabIndex = 5;
            // 
            // textBoxDailyDosage
            // 
            this.textBoxDailyDosage.Location = new System.Drawing.Point(202, 64);
            this.textBoxDailyDosage.Name = "textBoxDailyDosage";
            this.textBoxDailyDosage.Size = new System.Drawing.Size(82, 20);
            this.textBoxDailyDosage.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(115, 84);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Beräkna";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // itkalle
            // 
            this.itkalle.AutoSize = true;
            this.itkalle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.itkalle.Location = new System.Drawing.Point(250, 97);
            this.itkalle.Name = "itkalle";
            this.itkalle.Size = new System.Drawing.Size(34, 13);
            this.itkalle.TabIndex = 8;
            this.itkalle.Text = "itkalle";
            // 
            // Receptsnurran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 119);
            this.Controls.Add(this.itkalle);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxDailyDosage);
            this.Controls.Add(this.textBoxTotalTablets);
            this.Controls.Add(this.textBoxLastPrescriptionDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Receptsnurran";
            this.Text = "Receptsnurran";
            this.Load += new System.EventHandler(this.Receptsnurran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLastPrescriptionDate;
        private System.Windows.Forms.TextBox textBoxTotalTablets;
        private System.Windows.Forms.TextBox textBoxDailyDosage;
        private Button buttonCalculate;
        private System.Windows.Forms.Button ButtonCalculate;
        private Label itkalle;
    }
}

