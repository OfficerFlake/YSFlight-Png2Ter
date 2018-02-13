namespace Png2Srf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DropLabel = new System.Windows.Forms.Label();
            this.textBox_MaxNodeHeight = new System.Windows.Forms.TextBox();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.label_MaxNodeHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DropLabel
            // 
            this.DropLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropLabel.ForeColor = System.Drawing.Color.White;
            this.DropLabel.Location = new System.Drawing.Point(0, 0);
            this.DropLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.DropLabel.Name = "DropLabel";
            this.DropLabel.Size = new System.Drawing.Size(284, 262);
            this.DropLabel.TabIndex = 1;
            this.DropLabel.Text = "Drop Input PNG Here!";
            this.DropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_MaxNodeHeight
            // 
            this.textBox_MaxNodeHeight.Location = new System.Drawing.Point(156, 0);
            this.textBox_MaxNodeHeight.Name = "textBox_MaxNodeHeight";
            this.textBox_MaxNodeHeight.Size = new System.Drawing.Size(128, 20);
            this.textBox_MaxNodeHeight.TabIndex = 2;
            this.textBox_MaxNodeHeight.Text = "255";
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(156, 26);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(128, 20);
            this.textBox_Width.TabIndex = 3;
            this.textBox_Width.Text = "?";
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(156, 52);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(128, 20);
            this.textBox_Height.TabIndex = 4;
            this.textBox_Height.Text = "?";
            // 
            // label_MaxNodeHeight
            // 
            this.label_MaxNodeHeight.AutoSize = true;
            this.label_MaxNodeHeight.BackColor = System.Drawing.Color.Black;
            this.label_MaxNodeHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaxNodeHeight.ForeColor = System.Drawing.Color.White;
            this.label_MaxNodeHeight.Location = new System.Drawing.Point(24, 3);
            this.label_MaxNodeHeight.Name = "label_MaxNodeHeight";
            this.label_MaxNodeHeight.Size = new System.Drawing.Size(126, 13);
            this.label_MaxNodeHeight.TabIndex = 5;
            this.label_MaxNodeHeight.Text = "Max Node Height(m):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grid Width(m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grid Length(m):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PROTIP: You can leave the Width/Length blank to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "auto-determine grid size.";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_MaxNodeHeight);
            this.Controls.Add(this.textBox_Height);
            this.Controls.Add(this.textBox_Width);
            this.Controls.Add(this.textBox_MaxNodeHeight);
            this.Controls.Add(this.DropLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Png2Ter - © Flake 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DropLabel;
        private System.Windows.Forms.TextBox textBox_MaxNodeHeight;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Label label_MaxNodeHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

