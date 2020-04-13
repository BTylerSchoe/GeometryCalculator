namespace NICE_SpaceEaters_WindowsForm
{
    partial class frmSpaceEatersGeometryCalculator
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
            this.components = new System.ComponentModel.Container();
            this.lblLengthPrompt = new System.Windows.Forms.Label();
            this.txtLegthValue = new System.Windows.Forms.TextBox();
            this.rdbRectangularCalculator = new System.Windows.Forms.RadioButton();
            this.rdbCircularCalculator = new System.Windows.Forms.RadioButton();
            this.txtWidthValue = new System.Windows.Forms.TextBox();
            this.lblWidthPrompt = new System.Windows.Forms.Label();
            this.lblRadiusPrompt = new System.Windows.Forms.Label();
            this.lblCircularArea = new System.Windows.Forms.Label();
            this.lblCircularCircumference = new System.Windows.Forms.Label();
            this.txtRadiusValue = new System.Windows.Forms.TextBox();
            this.lblCircularAreaDisplay = new System.Windows.Forms.Label();
            this.lblCircularCircumferenceDisplay = new System.Windows.Forms.Label();
            this.lblRectangularPerimeterDisplay = new System.Windows.Forms.Label();
            this.lblRectangularAreaDisplay = new System.Windows.Forms.Label();
            this.lblRectangularArea = new System.Windows.Forms.Label();
            this.lblRectangularPerimeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SpaceEatersToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblLengthPrompt
            // 
            this.lblLengthPrompt.AutoSize = true;
            this.lblLengthPrompt.Location = new System.Drawing.Point(132, 118);
            this.lblLengthPrompt.Name = "lblLengthPrompt";
            this.lblLengthPrompt.Size = new System.Drawing.Size(56, 17);
            this.lblLengthPrompt.TabIndex = 1;
            this.lblLengthPrompt.Text = "&Length:";
            // 
            // txtLegthValue
            // 
            this.txtLegthValue.Location = new System.Drawing.Point(277, 114);
            this.txtLegthValue.Name = "txtLegthValue";
            this.txtLegthValue.Size = new System.Drawing.Size(211, 22);
            this.txtLegthValue.TabIndex = 2;
            this.SpaceEatersToolTip.SetToolTip(this.txtLegthValue, "Please enter the length of the rectangle (Alt-L)");
            // 
            // rdbRectangularCalculator
            // 
            this.rdbRectangularCalculator.AutoSize = true;
            this.rdbRectangularCalculator.Location = new System.Drawing.Point(43, 25);
            this.rdbRectangularCalculator.Name = "rdbRectangularCalculator";
            this.rdbRectangularCalculator.Size = new System.Drawing.Size(106, 21);
            this.rdbRectangularCalculator.TabIndex = 17;
            this.rdbRectangularCalculator.TabStop = true;
            this.rdbRectangularCalculator.Text = "Rectangular";
            this.SpaceEatersToolTip.SetToolTip(this.rdbRectangularCalculator, "Click to calculate for rectangles.");
            this.rdbRectangularCalculator.UseVisualStyleBackColor = true;
            this.rdbRectangularCalculator.CheckedChanged += new System.EventHandler(this.rdbRectangularCalculator_CheckedChanged);
            // 
            // rdbCircularCalculator
            // 
            this.rdbCircularCalculator.AutoSize = true;
            this.rdbCircularCalculator.Location = new System.Drawing.Point(182, 25);
            this.rdbCircularCalculator.Name = "rdbCircularCalculator";
            this.rdbCircularCalculator.Size = new System.Drawing.Size(77, 21);
            this.rdbCircularCalculator.TabIndex = 18;
            this.rdbCircularCalculator.TabStop = true;
            this.rdbCircularCalculator.Text = "Circular";
            this.SpaceEatersToolTip.SetToolTip(this.rdbCircularCalculator, "Click to calculate for circles");
            this.rdbCircularCalculator.UseVisualStyleBackColor = true;
            this.rdbCircularCalculator.CheckedChanged += new System.EventHandler(this.rdbCircularCalculator_CheckedChanged);
            // 
            // txtWidthValue
            // 
            this.txtWidthValue.Location = new System.Drawing.Point(277, 181);
            this.txtWidthValue.Name = "txtWidthValue";
            this.txtWidthValue.Size = new System.Drawing.Size(211, 22);
            this.txtWidthValue.TabIndex = 4;
            this.SpaceEatersToolTip.SetToolTip(this.txtWidthValue, "Please enter the width of the rectangle (Alt-W)");
            // 
            // lblWidthPrompt
            // 
            this.lblWidthPrompt.AutoSize = true;
            this.lblWidthPrompt.Location = new System.Drawing.Point(140, 185);
            this.lblWidthPrompt.Name = "lblWidthPrompt";
            this.lblWidthPrompt.Size = new System.Drawing.Size(48, 17);
            this.lblWidthPrompt.TabIndex = 3;
            this.lblWidthPrompt.Text = "&Width:";
            // 
            // lblRadiusPrompt
            // 
            this.lblRadiusPrompt.AutoSize = true;
            this.lblRadiusPrompt.Location = new System.Drawing.Point(132, 250);
            this.lblRadiusPrompt.Name = "lblRadiusPrompt";
            this.lblRadiusPrompt.Size = new System.Drawing.Size(56, 17);
            this.lblRadiusPrompt.TabIndex = 5;
            this.lblRadiusPrompt.Text = "&Radius:";
            // 
            // lblCircularArea
            // 
            this.lblCircularArea.AutoSize = true;
            this.lblCircularArea.Location = new System.Drawing.Point(142, 448);
            this.lblCircularArea.Name = "lblCircularArea";
            this.lblCircularArea.Size = new System.Drawing.Size(42, 17);
            this.lblCircularArea.TabIndex = 11;
            this.lblCircularArea.Text = "Area:";
            // 
            // lblCircularCircumference
            // 
            this.lblCircularCircumference.AutoSize = true;
            this.lblCircularCircumference.Location = new System.Drawing.Point(81, 510);
            this.lblCircularCircumference.Name = "lblCircularCircumference";
            this.lblCircularCircumference.Size = new System.Drawing.Size(103, 17);
            this.lblCircularCircumference.TabIndex = 1412;
            this.lblCircularCircumference.Text = "Circumference:";
            // 
            // txtRadiusValue
            // 
            this.txtRadiusValue.Location = new System.Drawing.Point(277, 246);
            this.txtRadiusValue.Name = "txtRadiusValue";
            this.txtRadiusValue.Size = new System.Drawing.Size(211, 22);
            this.txtRadiusValue.TabIndex = 6;
            this.SpaceEatersToolTip.SetToolTip(this.txtRadiusValue, "Please enter the radius of the circle (Alt-R)");
            // 
            // lblCircularAreaDisplay
            // 
            this.lblCircularAreaDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCircularAreaDisplay.Location = new System.Drawing.Point(277, 447);
            this.lblCircularAreaDisplay.Name = "lblCircularAreaDisplay";
            this.lblCircularAreaDisplay.Size = new System.Drawing.Size(211, 17);
            this.lblCircularAreaDisplay.TabIndex = 12;
            this.SpaceEatersToolTip.SetToolTip(this.lblCircularAreaDisplay, "Displays the area of the given circle");
            // 
            // lblCircularCircumferenceDisplay
            // 
            this.lblCircularCircumferenceDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCircularCircumferenceDisplay.Location = new System.Drawing.Point(277, 509);
            this.lblCircularCircumferenceDisplay.Name = "lblCircularCircumferenceDisplay";
            this.lblCircularCircumferenceDisplay.Size = new System.Drawing.Size(211, 17);
            this.lblCircularCircumferenceDisplay.TabIndex = 13;
            this.SpaceEatersToolTip.SetToolTip(this.lblCircularCircumferenceDisplay, "Displays the circumference of the given circle");
            // 
            // lblRectangularPerimeterDisplay
            // 
            this.lblRectangularPerimeterDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRectangularPerimeterDisplay.Location = new System.Drawing.Point(277, 385);
            this.lblRectangularPerimeterDisplay.Name = "lblRectangularPerimeterDisplay";
            this.lblRectangularPerimeterDisplay.Size = new System.Drawing.Size(211, 17);
            this.lblRectangularPerimeterDisplay.TabIndex = 10;
            this.SpaceEatersToolTip.SetToolTip(this.lblRectangularPerimeterDisplay, "Displays the perimeter of the given rectangle");
            // 
            // lblRectangularAreaDisplay
            // 
            this.lblRectangularAreaDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRectangularAreaDisplay.Location = new System.Drawing.Point(277, 323);
            this.lblRectangularAreaDisplay.Name = "lblRectangularAreaDisplay";
            this.lblRectangularAreaDisplay.Size = new System.Drawing.Size(211, 17);
            this.lblRectangularAreaDisplay.TabIndex = 8;
            this.SpaceEatersToolTip.SetToolTip(this.lblRectangularAreaDisplay, "Displays the area of the given rectangle");
            // 
            // lblRectangularArea
            // 
            this.lblRectangularArea.AutoSize = true;
            this.lblRectangularArea.Location = new System.Drawing.Point(142, 324);
            this.lblRectangularArea.Name = "lblRectangularArea";
            this.lblRectangularArea.Size = new System.Drawing.Size(42, 17);
            this.lblRectangularArea.TabIndex = 7;
            this.lblRectangularArea.Text = "Area:";
            // 
            // lblRectangularPerimeter
            // 
            this.lblRectangularPerimeter.AutoSize = true;
            this.lblRectangularPerimeter.Location = new System.Drawing.Point(111, 386);
            this.lblRectangularPerimeter.Name = "lblRectangularPerimeter";
            this.lblRectangularPerimeter.Size = new System.Drawing.Size(73, 17);
            this.lblRectangularPerimeter.TabIndex = 9;
            this.lblRectangularPerimeter.Text = "Perimeter:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculate.Location = new System.Drawing.Point(61, 592);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 39);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "&Calculate";
            this.SpaceEatersToolTip.SetToolTip(this.btnCalculate, "Click to calculate (Alt-C)");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Location = new System.Drawing.Point(277, 592);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 39);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clea&r";
            this.SpaceEatersToolTip.SetToolTip(this.btnClear, "Click to clear the program back to default (Alt-R)");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(494, 592);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 39);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "&Exit";
            this.SpaceEatersToolTip.SetToolTip(this.btnExit, "Click to exit the application (Alt-E)");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SpaceEatersToolTip
            // 
            this.SpaceEatersToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmSpaceEatersGeometryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 701);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRectangularPerimeterDisplay);
            this.Controls.Add(this.lblRectangularAreaDisplay);
            this.Controls.Add(this.lblRectangularPerimeter);
            this.Controls.Add(this.lblRectangularArea);
            this.Controls.Add(this.lblCircularCircumferenceDisplay);
            this.Controls.Add(this.lblCircularAreaDisplay);
            this.Controls.Add(this.lblCircularCircumference);
            this.Controls.Add(this.lblCircularArea);
            this.Controls.Add(this.lblRadiusPrompt);
            this.Controls.Add(this.lblWidthPrompt);
            this.Controls.Add(this.txtRadiusValue);
            this.Controls.Add(this.txtWidthValue);
            this.Controls.Add(this.rdbCircularCalculator);
            this.Controls.Add(this.rdbRectangularCalculator);
            this.Controls.Add(this.txtLegthValue);
            this.Controls.Add(this.lblLengthPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmSpaceEatersGeometryCalculator";
            this.Text = "Space Eaters Geometry Calculator";
            this.Load += new System.EventHandler(this.frmSpaceEatersGeometryCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLengthPrompt;
        private System.Windows.Forms.TextBox txtLegthValue;
        private System.Windows.Forms.RadioButton rdbRectangularCalculator;
        private System.Windows.Forms.RadioButton rdbCircularCalculator;
        private System.Windows.Forms.TextBox txtWidthValue;
        private System.Windows.Forms.Label lblWidthPrompt;
        private System.Windows.Forms.Label lblRadiusPrompt;
        private System.Windows.Forms.Label lblCircularArea;
        private System.Windows.Forms.Label lblCircularCircumference;
        private System.Windows.Forms.TextBox txtRadiusValue;
        private System.Windows.Forms.Label lblCircularAreaDisplay;
        private System.Windows.Forms.Label lblCircularCircumferenceDisplay;
        private System.Windows.Forms.Label lblRectangularPerimeterDisplay;
        private System.Windows.Forms.Label lblRectangularAreaDisplay;
        private System.Windows.Forms.Label lblRectangularArea;
        private System.Windows.Forms.Label lblRectangularPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip SpaceEatersToolTip;
    }
}

