
namespace ExercicioProfLedonBandeiras
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
            this.Brasil = new System.Windows.Forms.RadioButton();
            this.Chile = new System.Windows.Forms.RadioButton();
            this.México = new System.Windows.Forms.RadioButton();
            this.Argentina = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Brasil
            // 
            this.Brasil.AutoSize = true;
            this.Brasil.Location = new System.Drawing.Point(115, 45);
            this.Brasil.Name = "Brasil";
            this.Brasil.Size = new System.Drawing.Size(78, 29);
            this.Brasil.TabIndex = 0;
            this.Brasil.TabStop = true;
            this.Brasil.Text = "Brasil";
            this.Brasil.UseVisualStyleBackColor = true;
            this.Brasil.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Chile
            // 
            this.Chile.AutoSize = true;
            this.Chile.Location = new System.Drawing.Point(115, 92);
            this.Chile.Name = "Chile";
            this.Chile.Size = new System.Drawing.Size(75, 29);
            this.Chile.TabIndex = 1;
            this.Chile.TabStop = true;
            this.Chile.Text = "Chile";
            this.Chile.UseVisualStyleBackColor = true;
            this.Chile.CheckedChanged += new System.EventHandler(this.Chile_CheckedChanged);
            // 
            // México
            // 
            this.México.AutoSize = true;
            this.México.Location = new System.Drawing.Point(115, 137);
            this.México.Name = "México";
            this.México.Size = new System.Drawing.Size(93, 29);
            this.México.TabIndex = 2;
            this.México.TabStop = true;
            this.México.Text = "México";
            this.México.UseVisualStyleBackColor = true;
            this.México.CheckedChanged += new System.EventHandler(this.México_CheckedChanged);
            // 
            // Argentina
            // 
            this.Argentina.AutoSize = true;
            this.Argentina.Location = new System.Drawing.Point(115, 182);
            this.Argentina.Name = "Argentina";
            this.Argentina.Size = new System.Drawing.Size(114, 29);
            this.Argentina.TabIndex = 3;
            this.Argentina.TabStop = true;
            this.Argentina.Text = "Argentina";
            this.Argentina.UseVisualStyleBackColor = true;
            this.Argentina.CheckedChanged += new System.EventHandler(this.Argentina_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(402, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 201);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Argentina);
            this.Controls.Add(this.México);
            this.Controls.Add(this.Chile);
            this.Controls.Add(this.Brasil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geografia Latino Americana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Brasil;
        private System.Windows.Forms.RadioButton Chile;
        private System.Windows.Forms.RadioButton México;
        private System.Windows.Forms.RadioButton Argentina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

