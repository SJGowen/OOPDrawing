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
            this.actionCombo = new System.Windows.Forms.ComboBox();
            this.NextShape = new System.Windows.Forms.Button();
            this.PreviousShape = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.angleLabel = new System.Windows.Forms.Label();
            this.degreesLabel = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colourBtn = new System.Windows.Forms.Button();
            this.colourLabel = new System.Windows.Forms.Label();
            this.spinLineWidth = new System.Windows.Forms.NumericUpDown();
            this.lineWidthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // actionCombo
            // 
            this.actionCombo.FormattingEnabled = true;
            this.actionCombo.Items.AddRange(new object[] {
            "Draw Line",
            "Draw Circle",
            "Draw Isosceles Triangle",
            "Draw Equilateral Triangle",
            "Draw Square",
            "Draw Pentagon",
            "Draw Hexagon",
            "Draw Heptagon",
            "Draw Octagon",
            "Draw Rectangle",
            "Draw House",
            "Draw Arrow",
            "Move Shape",
            "Resize Shape"});
            this.actionCombo.Location = new System.Drawing.Point(108, 6);
            this.actionCombo.Name = "actionCombo";
            this.actionCombo.Size = new System.Drawing.Size(156, 21);
            this.actionCombo.TabIndex = 0;
            this.actionCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.angle.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(12, 9);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(90, 13);
            this.actionLabel.TabIndex = 6;
            this.actionLabel.Text = "Action to perform:";
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(16, 38);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(86, 13);
            this.selectionLabel.TabIndex = 7;
            this.selectionLabel.Text = "Object to Select:";
            // 
            // colourBtn
            // 
            this.colourBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.colourBtn.Location = new System.Drawing.Point(108, 62);
            this.colourBtn.Name = "colourBtn";
            this.colourBtn.Size = new System.Drawing.Size(75, 23);
            this.colourBtn.TabIndex = 8;
            this.colourBtn.Text = "Colour";
            this.colourBtn.UseVisualStyleBackColor = true;
            this.colourBtn.Click += new System.EventHandler(this.colourBtn_Click);
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(23, 67);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(79, 13);
            this.colourLabel.TabIndex = 9;
            this.colourLabel.Text = "Objects Colour:";
            // 
            // spinLineWidth
            // 
            this.spinLineWidth.Location = new System.Drawing.Point(108, 91);
            this.spinLineWidth.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.spinLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinLineWidth.Name = "spinLineWidth";
            this.spinLineWidth.Size = new System.Drawing.Size(31, 20);
            this.spinLineWidth.TabIndex = 10;
            this.spinLineWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lineWidthLabel
            // 
            this.lineWidthLabel.AutoSize = true;
            this.lineWidthLabel.Location = new System.Drawing.Point(41, 93);
            this.lineWidthLabel.Name = "lineWidthLabel";
            this.lineWidthLabel.Size = new System.Drawing.Size(61, 13);
            this.lineWidthLabel.TabIndex = 11;
            this.lineWidthLabel.Text = "Line Width:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lineWidthLabel);
            this.Controls.Add(this.spinLineWidth);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.colourBtn);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.degreesLabel);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.PreviousShape);
            this.Controls.Add(this.NextShape);
            this.Controls.Add(this.actionCombo);
            this.Name = "Form1";
            this.Text = "Drawing App";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLineWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox actionCombo;
        private System.Windows.Forms.Button NextShape;
        private System.Windows.Forms.Button PreviousShape;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.Label degreesLabel;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colourBtn;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.NumericUpDown spinLineWidth;
        private System.Windows.Forms.Label lineWidthLabel;
    }
}

