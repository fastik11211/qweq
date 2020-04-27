namespace SiemensProgram.ServisNastr
{
    partial class ServNastr2Conv1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SpeedTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Size = new System.Drawing.Size(327, 26);
            this.label2.Text = "Скорость ленты при 50гц [м/мин]";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(514, 144);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 144);
            this.label4.Size = new System.Drawing.Size(336, 26);
            this.label4.Text = "макс частота инвертора ленты [Гц]";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(514, 106);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Size = new System.Drawing.Size(330, 26);
            this.label3.Text = "мин частота инвертора ленты [Гц]";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 65);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(635, 254);
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 254);
            this.button3.Visible = false;
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Controls.Add(this.textBox4);
            this.SpeedTextBox.Controls.Add(this.label6);
            this.SpeedTextBox.Controls.Add(this.label5);
            this.SpeedTextBox.Controls.SetChildIndex(this.label5, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.label6, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.pictureBox3, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.label2, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.textBox1, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.label3, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.textBox2, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.label4, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.textBox3, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.button3, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.button4, 0);
            this.SpeedTextBox.Controls.SetChildIndex(this.textBox4, 0);
            // 
            // alBut
            // 
            this.alBut.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(294, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 38);
            this.label5.TabIndex = 90;
            this.label5.Text = "Конвеер 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 26);
            this.label6.TabIndex = 91;
            this.label6.Text = "задержка сраб пред опт датчика [сек] ";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Yellow;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(514, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 26);
            this.textBox4.TabIndex = 92;
            this.textBox4.Text = "50,00";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServNastr2Conv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Name = "ServNastr2Conv1";
            this.Load += new System.EventHandler(this.ServNastr2Conv1_Load);
            this.SpeedTextBox.ResumeLayout(false);
            this.SpeedTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox textBox4;
    }
}