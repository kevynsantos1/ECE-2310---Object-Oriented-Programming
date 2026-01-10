namespace number_to_letter_grade_calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumGrade = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLetGrade = new System.Windows.Forms.TextBox();
            this.buttonSWCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Numerical Grade Please";
            // 
            // textBoxNumGrade
            // 
            this.textBoxNumGrade.Location = new System.Drawing.Point(385, 65);
            this.textBoxNumGrade.Name = "textBoxNumGrade";
            this.textBoxNumGrade.Size = new System.Drawing.Size(204, 20);
            this.textBoxNumGrade.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(190, 167);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(115, 67);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert to Letter Grade";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Letter Grade:";
            // 
            // textBoxLetGrade
            // 
            this.textBoxLetGrade.Location = new System.Drawing.Point(385, 306);
            this.textBoxLetGrade.Name = "textBoxLetGrade";
            this.textBoxLetGrade.Size = new System.Drawing.Size(204, 20);
            this.textBoxLetGrade.TabIndex = 4;
            // 
            // buttonSWCase
            // 
            this.buttonSWCase.Location = new System.Drawing.Point(426, 167);
            this.buttonSWCase.Name = "buttonSWCase";
            this.buttonSWCase.Size = new System.Drawing.Size(122, 67);
            this.buttonSWCase.TabIndex = 5;
            this.buttonSWCase.Text = "Convert using Switch case";
            this.buttonSWCase.UseVisualStyleBackColor = true;
            this.buttonSWCase.Click += new System.EventHandler(this.buttonSWCase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSWCase);
            this.Controls.Add(this.textBoxLetGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxNumGrade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumGrade;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLetGrade;
        private System.Windows.Forms.Button buttonSWCase;
    }
}

