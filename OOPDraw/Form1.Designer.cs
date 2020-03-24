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
            this.ActionCombo = new System.Windows.Forms.ComboBox();
            this.NextShape = new System.Windows.Forms.Button();
            this.PriorShape = new System.Windows.Forms.Button();
            this.OrientationSpin = new System.Windows.Forms.NumericUpDown();
            this.OrientationLabel = new System.Windows.Forms.Label();
            this.DegreesLabel = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColourBtn = new System.Windows.Forms.Button();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.PenSizeSpin = new System.Windows.Forms.NumericUpDown();
            this.PenSizeLabel = new System.Windows.Forms.Label();
            this.SideLengthLabel = new System.Windows.Forms.Label();
            this.SideLengthSpin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.OrientationSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenSizeSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideLengthSpin)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionCombo
            // 
            this.ActionCombo.FormattingEnabled = true;
            this.ActionCombo.Items.AddRange(new object[] {
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
            this.ActionCombo.Location = new System.Drawing.Point(108, 6);
            this.ActionCombo.Name = "ActionCombo";
            this.ActionCombo.Size = new System.Drawing.Size(156, 21);
            this.ActionCombo.TabIndex = 0;
            this.ActionCombo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
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
            // PriorShape
            // 
            this.PriorShape.Location = new System.Drawing.Point(189, 33);
            this.PriorShape.Name = "PriorShape";
            this.PriorShape.Size = new System.Drawing.Size(75, 23);
            this.PriorShape.TabIndex = 2;
            this.PriorShape.Text = "Prior";
            this.PriorShape.UseVisualStyleBackColor = true;
            this.PriorShape.Click += new System.EventHandler(this.PreviousShape_Click);
            // 
            // OrientationSpin
            // 
            this.OrientationSpin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OrientationSpin.Location = new System.Drawing.Point(108, 117);
            this.OrientationSpin.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.OrientationSpin.Name = "OrientationSpin";
            this.OrientationSpin.Size = new System.Drawing.Size(41, 20);
            this.OrientationSpin.TabIndex = 3;
            this.OrientationSpin.ValueChanged += new System.EventHandler(this.OrientationSpin_ValueChanged);
            // 
            // OrientationLabel
            // 
            this.OrientationLabel.AutoSize = true;
            this.OrientationLabel.Location = new System.Drawing.Point(41, 119);
            this.OrientationLabel.Name = "OrientationLabel";
            this.OrientationLabel.Size = new System.Drawing.Size(61, 13);
            this.OrientationLabel.TabIndex = 4;
            this.OrientationLabel.Text = "Orientation:";
            // 
            // DegreesLabel
            // 
            this.DegreesLabel.AutoSize = true;
            this.DegreesLabel.Location = new System.Drawing.Point(155, 119);
            this.DegreesLabel.Name = "DegreesLabel";
            this.DegreesLabel.Size = new System.Drawing.Size(45, 13);
            this.DegreesLabel.TabIndex = 5;
            this.DegreesLabel.Text = "degrees";
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Location = new System.Drawing.Point(12, 9);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(90, 13);
            this.ActionLabel.TabIndex = 6;
            this.ActionLabel.Text = "Action to perform:";
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(16, 38);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(86, 13);
            this.SelectionLabel.TabIndex = 7;
            this.SelectionLabel.Text = "Object to Select:";
            // 
            // ColourBtn
            // 
            this.ColourBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ColourBtn.Location = new System.Drawing.Point(108, 62);
            this.ColourBtn.Name = "ColourBtn";
            this.ColourBtn.Size = new System.Drawing.Size(75, 23);
            this.ColourBtn.TabIndex = 8;
            this.ColourBtn.Text = "Colour";
            this.ColourBtn.UseVisualStyleBackColor = true;
            this.ColourBtn.Click += new System.EventHandler(this.colourBtn_Click);
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.Location = new System.Drawing.Point(23, 67);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(79, 13);
            this.ColourLabel.TabIndex = 9;
            this.ColourLabel.Text = "Objects Colour:";
            // 
            // PenSizeSpin
            // 
            this.PenSizeSpin.Location = new System.Drawing.Point(233, 91);
            this.PenSizeSpin.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.PenSizeSpin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PenSizeSpin.Name = "PenSizeSpin";
            this.PenSizeSpin.Size = new System.Drawing.Size(31, 20);
            this.PenSizeSpin.TabIndex = 10;
            this.PenSizeSpin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // PenSizeLabel
            // 
            this.PenSizeLabel.AutoSize = true;
            this.PenSizeLabel.Location = new System.Drawing.Point(175, 93);
            this.PenSizeLabel.Name = "PenSizeLabel";
            this.PenSizeLabel.Size = new System.Drawing.Size(52, 13);
            this.PenSizeLabel.TabIndex = 11;
            this.PenSizeLabel.Text = "Pen Size:";
            // 
            // SideLengthLabel
            // 
            this.SideLengthLabel.AutoSize = true;
            this.SideLengthLabel.Location = new System.Drawing.Point(35, 93);
            this.SideLengthLabel.Name = "SideLengthLabel";
            this.SideLengthLabel.Size = new System.Drawing.Size(67, 13);
            this.SideLengthLabel.TabIndex = 13;
            this.SideLengthLabel.Text = "Side Length:";
            // 
            // SideLengthSpin
            // 
            this.SideLengthSpin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SideLengthSpin.Location = new System.Drawing.Point(108, 91);
            this.SideLengthSpin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SideLengthSpin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SideLengthSpin.Name = "SideLengthSpin";
            this.SideLengthSpin.Size = new System.Drawing.Size(48, 20);
            this.SideLengthSpin.TabIndex = 12;
            this.SideLengthSpin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.SideLengthLabel);
            this.Controls.Add(this.SideLengthSpin);
            this.Controls.Add(this.PenSizeLabel);
            this.Controls.Add(this.PenSizeSpin);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.ColourBtn);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.DegreesLabel);
            this.Controls.Add(this.OrientationLabel);
            this.Controls.Add(this.OrientationSpin);
            this.Controls.Add(this.PriorShape);
            this.Controls.Add(this.NextShape);
            this.Controls.Add(this.ActionCombo);
            this.Name = "Form1";
            this.Text = "Drawing App";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.OrientationSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenSizeSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideLengthSpin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ActionCombo;
        private System.Windows.Forms.Button NextShape;
        private System.Windows.Forms.Button PriorShape;
        private System.Windows.Forms.NumericUpDown OrientationSpin;
        private System.Windows.Forms.Label OrientationLabel;
        private System.Windows.Forms.Label DegreesLabel;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColourBtn;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.NumericUpDown PenSizeSpin;
        private System.Windows.Forms.Label PenSizeLabel;
        private System.Windows.Forms.Label SideLengthLabel;
        private System.Windows.Forms.NumericUpDown SideLengthSpin;
    }
}

