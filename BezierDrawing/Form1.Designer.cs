namespace BezierDrawing
{
    partial class LinesDrawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinesDrawing));
            toolStrip1 = new ToolStrip();
            closedLineButton = new ToolStripButton();
            unclosedLineButton = new ToolStripButton();
            closedCurveButton = new ToolStripButton();
            unclosedCurveButton = new ToolStripButton();
            oneBezier = new ToolStripButton();
            closedBezier = new ToolStripButton();
            unclosedBezier = new ToolStripButton();
            drawBox = new PictureBox();
            label1 = new Label();
            clicksLabel = new Label();
            cleanClickButton = new Button();
            unclosedLinePanel = new Panel();
            elasticityField = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drawBox).BeginInit();
            unclosedLinePanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AllowDrop = true;
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.ControlLightLight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { closedLineButton, unclosedLineButton, closedCurveButton, unclosedCurveButton, oneBezier, closedBezier, unclosedBezier });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1042, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // closedLineButton
            // 
            closedLineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            closedLineButton.Font = new Font("Times New Roman", 12F);
            closedLineButton.Image = (Image)resources.GetObject("closedLineButton.Image");
            closedLineButton.ImageTransparentColor = Color.Magenta;
            closedLineButton.Name = "closedLineButton";
            closedLineButton.Size = new Size(142, 31);
            closedLineButton.Text = "Замкнутая ломаная";
            closedLineButton.Click += closedLineButton_Click;
            // 
            // unclosedLineButton
            // 
            unclosedLineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            unclosedLineButton.Font = new Font("Times New Roman", 12F);
            unclosedLineButton.Image = (Image)resources.GetObject("unclosedLineButton.Image");
            unclosedLineButton.ImageTransparentColor = Color.Magenta;
            unclosedLineButton.Name = "unclosedLineButton";
            unclosedLineButton.Size = new Size(158, 31);
            unclosedLineButton.Text = "Незамкнутая ломаная";
            unclosedLineButton.Click += unclosedLineButton_Click;
            // 
            // closedCurveButton
            // 
            closedCurveButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            closedCurveButton.Font = new Font("Times New Roman", 12F);
            closedCurveButton.Image = (Image)resources.GetObject("closedCurveButton.Image");
            closedCurveButton.ImageTransparentColor = Color.Magenta;
            closedCurveButton.Name = "closedCurveButton";
            closedCurveButton.Size = new Size(141, 31);
            closedCurveButton.Text = "Замкнутый сплайн";
            closedCurveButton.Click += closedCurveButton_Click;
            // 
            // unclosedCurveButton
            // 
            unclosedCurveButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            unclosedCurveButton.Font = new Font("Times New Roman", 12F);
            unclosedCurveButton.Image = (Image)resources.GetObject("unclosedCurveButton.Image");
            unclosedCurveButton.ImageTransparentColor = Color.Magenta;
            unclosedCurveButton.Name = "unclosedCurveButton";
            unclosedCurveButton.Size = new Size(157, 31);
            unclosedCurveButton.Text = "Незамкнутый сплайн";
            unclosedCurveButton.Click += unclosedCurveButton_Click;
            // 
            // oneBezier
            // 
            oneBezier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            oneBezier.Font = new Font("Times New Roman", 12F);
            oneBezier.Image = (Image)resources.GetObject("oneBezier.Image");
            oneBezier.ImageTransparentColor = Color.Magenta;
            oneBezier.Name = "oneBezier";
            oneBezier.Size = new Size(139, 31);
            oneBezier.Text = "Одна кривая Безье";
            oneBezier.Click += oneBezier_Click;
            // 
            // closedBezier
            // 
            closedBezier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            closedBezier.Font = new Font("Times New Roman", 12F);
            closedBezier.Image = (Image)resources.GetObject("closedBezier.Image");
            closedBezier.ImageTransparentColor = Color.Magenta;
            closedBezier.Name = "closedBezier";
            closedBezier.Size = new Size(122, 31);
            closedBezier.Text = "Замкнутая Безье";
            closedBezier.Click += closedBezier_Click;
            // 
            // unclosedBezier
            // 
            unclosedBezier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            unclosedBezier.Font = new Font("Times New Roman", 12F);
            unclosedBezier.Image = (Image)resources.GetObject("unclosedBezier.Image");
            unclosedBezier.ImageTransparentColor = Color.Magenta;
            unclosedBezier.Name = "unclosedBezier";
            unclosedBezier.Size = new Size(138, 31);
            unclosedBezier.Text = "Незамкнутая Безье";
            unclosedBezier.Click += unclosedBezier_Click;
            // 
            // drawBox
            // 
            drawBox.BackColor = SystemColors.ControlLight;
            drawBox.Location = new Point(12, 50);
            drawBox.Name = "drawBox";
            drawBox.Size = new Size(705, 740);
            drawBox.TabIndex = 1;
            drawBox.TabStop = false;
            drawBox.MouseClick += pictureBox1_MouseClick;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(51, 17);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 2;
            label1.Text = "Текущие нажатия:";
            // 
            // clicksLabel
            // 
            clicksLabel.BackColor = SystemColors.AppWorkspace;
            clicksLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clicksLabel.Location = new Point(51, 76);
            clicksLabel.Name = "clicksLabel";
            clicksLabel.Size = new Size(156, 559);
            clicksLabel.TabIndex = 3;
            // 
            // cleanClickButton
            // 
            cleanClickButton.Font = new Font("Times New Roman", 12F);
            cleanClickButton.Location = new Point(51, 647);
            cleanClickButton.Name = "cleanClickButton";
            cleanClickButton.Size = new Size(156, 32);
            cleanClickButton.TabIndex = 4;
            cleanClickButton.Text = "Очистить";
            cleanClickButton.UseVisualStyleBackColor = true;
            cleanClickButton.Click += cleanClickButton_Click;
            // 
            // unclosedLinePanel
            // 
            unclosedLinePanel.Controls.Add(elasticityField);
            unclosedLinePanel.Controls.Add(clicksLabel);
            unclosedLinePanel.Controls.Add(cleanClickButton);
            unclosedLinePanel.Controls.Add(label1);
            unclosedLinePanel.Location = new Point(759, 53);
            unclosedLinePanel.Name = "unclosedLinePanel";
            unclosedLinePanel.Size = new Size(244, 737);
            unclosedLinePanel.TabIndex = 5;
            // 
            // elasticityField
            // 
            elasticityField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            elasticityField.Location = new Point(86, 695);
            elasticityField.Name = "elasticityField";
            elasticityField.PlaceholderText = "Упругость";
            elasticityField.Size = new Size(78, 26);
            elasticityField.TabIndex = 5;
            // 
            // LinesDrawing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 830);
            Controls.Add(unclosedLinePanel);
            Controls.Add(drawBox);
            Controls.Add(toolStrip1);
            Name = "LinesDrawing";
            Text = "LinesDrawing";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drawBox).EndInit();
            unclosedLinePanel.ResumeLayout(false);
            unclosedLinePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton closedLineButton;
        private ToolStripButton unclosedLineButton;
        private ToolStripButton closedCurveButton;
        private ToolStripButton unclosedCurveButton;
        private ToolStripButton oneBezier;
        private ToolStripButton closedBezier;
        private ToolStripButton unclosedBezier;
        private ToolStripButton clearButton;
        private PictureBox drawBox;
        private Label label1;
        private Label clicksLabel;
        private Button cleanClickButton;
        private Panel unclosedLinePanel;
        private TextBox elasticityField;
    }
}
