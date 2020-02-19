namespace OOPDraw
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NextShape = new System.Windows.Forms.Button();
            this.PreviousShape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Draw Triangle",
            "Draw Rectangle",
            "Draw House",
            "Move Shape",
            "Resize Shape"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // NextShape
            // 
            this.NextShape.Location = new System.Drawing.Point(13, 40);
            this.NextShape.Name = "NextShape";
            this.NextShape.Size = new System.Drawing.Size(75, 23);
            this.NextShape.TabIndex = 1;
            this.NextShape.Text = "Next";
            this.NextShape.UseVisualStyleBackColor = true;
            this.NextShape.Click += new System.EventHandler(this.NextShape_Click);
            // 
            // PreviousShape
            // 
            this.PreviousShape.Location = new System.Drawing.Point(94, 40);
            this.PreviousShape.Name = "PreviousShape";
            this.PreviousShape.Size = new System.Drawing.Size(75, 23);
            this.PreviousShape.TabIndex = 2;
            this.PreviousShape.Text = "Prev";
            this.PreviousShape.UseVisualStyleBackColor = true;
            this.PreviousShape.Click += new System.EventHandler(this.PreviousShape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PreviousShape);
            this.Controls.Add(this.NextShape);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button NextShape;
        private System.Windows.Forms.Button PreviousShape;
    }
}

