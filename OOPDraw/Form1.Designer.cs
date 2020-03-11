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
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.angleLabel = new System.Windows.Forms.Label();
            this.degreesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Draw Line",
            "Draw Circle",
            "Draw Triangle",
            "Draw Rectangle",
            "Draw House",
            "Draw Arrow",
            "Move Shape",
            "Resize Shape"});
            this.comboBox1.Location = new System.Drawing.Point(108, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NextShape
            // 
            this.NextShape.Location = new System.Drawing.Point(108, 33);
            this.NextShape.Name = "NextShape";
            this.NextShape.Size = new System.Drawing.Size(75, 23);
            this.NextShape.TabIndex = 1;
            this.NextShape.Text = "Next";
            this.NextShape.UseVisualStyleBackColor = true;
            this.NextShape.Click += new System.EventHandler(this.NextShape_Click);
            // 
            // PreviousShape
            // 
            this.PreviousShape.Location = new System.Drawing.Point(189, 33);
            this.PreviousShape.Name = "PreviousShape";
            this.PreviousShape.Size = new System.Drawing.Size(75, 23);
            this.PreviousShape.TabIndex = 2;
            this.PreviousShape.Text = "Prev";
            this.PreviousShape.UseVisualStyleBackColor = true;
            this.PreviousShape.Click += new System.EventHandler(this.PreviousShape_Click);
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(502, 7);
            this.angle.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(41, 20);
            this.angle.TabIndex = 3;
            this.angle.Visible = false;
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Location = new System.Drawing.Point(270, 9);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(226, 13);
            this.angleLabel.TabIndex = 4;
            this.angleLabel.Text = "The Angle that Lines and Arrows are drawn at:";
            this.angleLabel.Visible = false;
            // 
            // degreesLabel
            // 
            this.degreesLabel.AutoSize = true;
            this.degreesLabel.Location = new System.Drawing.Point(549, 9);
            this.degreesLabel.Name = "degreesLabel";
            this.degreesLabel.Size = new System.Drawing.Size(45, 13);
            this.degreesLabel.TabIndex = 5;
            this.degreesLabel.Text = "degrees";
            this.degreesLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Action to perform:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Object to Select:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.degreesLabel);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.PreviousShape);
            this.Controls.Add(this.NextShape);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Drawing App";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button NextShape;
        private System.Windows.Forms.Button PreviousShape;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.Label degreesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

