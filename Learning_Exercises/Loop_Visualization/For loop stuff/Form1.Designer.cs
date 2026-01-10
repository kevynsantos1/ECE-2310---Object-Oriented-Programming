namespace For_loop_stuff
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
            this.button1 = new System.Windows.Forms.Button();
            this.listOutput1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listOutput2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listOutput3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Loops";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOutput1
            // 
            this.listOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOutput1.FormattingEnabled = true;
            this.listOutput1.ItemHeight = 24;
            this.listOutput1.Location = new System.Drawing.Point(34, 154);
            this.listOutput1.Name = "listOutput1";
            this.listOutput1.Size = new System.Drawing.Size(219, 196);
            this.listOutput1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add loop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listOutput2
            // 
            this.listOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOutput2.FormattingEnabled = true;
            this.listOutput2.ItemHeight = 24;
            this.listOutput2.Location = new System.Drawing.Point(297, 154);
            this.listOutput2.Name = "listOutput2";
            this.listOutput2.Size = new System.Drawing.Size(219, 196);
            this.listOutput2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(551, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "Factorial Loop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listOutput3
            // 
            this.listOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOutput3.FormattingEnabled = true;
            this.listOutput3.ItemHeight = 24;
            this.listOutput3.Location = new System.Drawing.Point(551, 154);
            this.listOutput3.Name = "listOutput3";
            this.listOutput3.Size = new System.Drawing.Size(219, 196);
            this.listOutput3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listOutput3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listOutput2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listOutput1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listOutput1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listOutput2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listOutput3;
    }
}

