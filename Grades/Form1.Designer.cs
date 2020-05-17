namespace Grades
{
    partial class Form1
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
            this.txtgrades = new System.Windows.Forms.TextBox();
            this.txtnames = new System.Windows.Forms.TextBox();
            this.buttoncalculate = new System.Windows.Forms.Button();
            this.lbxGrade = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtgrades
            // 
            this.txtgrades.Location = new System.Drawing.Point(421, 91);
            this.txtgrades.Name = "txtgrades";
            this.txtgrades.Size = new System.Drawing.Size(129, 20);
            this.txtgrades.TabIndex = 0;
            // 
            // txtnames
            // 
            this.txtnames.Location = new System.Drawing.Point(421, 117);
            this.txtnames.Name = "txtnames";
            this.txtnames.Size = new System.Drawing.Size(129, 20);
            this.txtnames.TabIndex = 1;
            // 
            // buttoncalculate
            // 
            this.buttoncalculate.Location = new System.Drawing.Point(240, 91);
            this.buttoncalculate.Name = "buttoncalculate";
            this.buttoncalculate.Size = new System.Drawing.Size(120, 53);
            this.buttoncalculate.TabIndex = 2;
            this.buttoncalculate.Text = "CalculateGrade";
            this.buttoncalculate.UseVisualStyleBackColor = true;
            this.buttoncalculate.Click += new System.EventHandler(this.buttoncalculate_Click);
            // 
            // lbxGrade
            // 
            this.lbxGrade.FormattingEnabled = true;
            this.lbxGrade.Location = new System.Drawing.Point(240, 234);
            this.lbxGrade.Name = "lbxGrade";
            this.lbxGrade.Size = new System.Drawing.Size(297, 95);
            this.lbxGrade.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxGrade);
            this.Controls.Add(this.buttoncalculate);
            this.Controls.Add(this.txtnames);
            this.Controls.Add(this.txtgrades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgrades;
        private System.Windows.Forms.TextBox txtnames;
        private System.Windows.Forms.Button buttoncalculate;
        private System.Windows.Forms.ListBox lbxGrade;
    }
}

