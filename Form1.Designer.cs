namespace SpaceChart
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
            diagram = new ScottPlot.FormsPlot();
            ReadFromFileButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            starScroll = new TrackBar();
            label1 = new Label();
            starBox = new TextBox();
            clearButton = new Button();
            SunCheckBox = new CheckBox();
            MainSequenceBox = new CheckBox();
            WhiteDwarfsBox = new CheckBox();
            redGiantsBox = new CheckBox();
            BrightGiantsBox = new CheckBox();
            SuperGiantsBox = new CheckBox();
            textBox1 = new TextBox();
            InfoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)starScroll).BeginInit();
            SuspendLayout();
            // 
            // diagram
            // 
            diagram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            diagram.AutoSize = true;
            diagram.ForeColor = Color.White;
            diagram.Location = new Point(458, 13);
            diagram.Margin = new Padding(5, 4, 5, 4);
            diagram.MaximumSize = new Size(1080, 1080);
            diagram.Name = "diagram";
            diagram.Size = new Size(970, 877);
            diagram.TabIndex = 0;
            diagram.Load += diagram_Load;
            // 
            // ReadFromFileButton
            // 
            ReadFromFileButton.Location = new Point(12, 125);
            ReadFromFileButton.Name = "ReadFromFileButton";
            ReadFromFileButton.Size = new Size(407, 53);
            ReadFromFileButton.TabIndex = 1;
            ReadFromFileButton.Text = "Прочесть данные из файла";
            ReadFromFileButton.UseVisualStyleBackColor = true;
            ReadFromFileButton.Click += ReadFromFileButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "dataset";
            // 
            // starScroll
            // 
            starScroll.LargeChange = 10000;
            starScroll.Location = new Point(12, 70);
            starScroll.Maximum = 200000;
            starScroll.Name = "starScroll";
            starScroll.Size = new Size(407, 56);
            starScroll.SmallChange = 5000;
            starScroll.TabIndex = 3;
            starScroll.Value = 1000;
            starScroll.Scroll += starScroll_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(258, 31);
            label1.TabIndex = 4;
            label1.Text = "Сколько звезд считать?";
            // 
            // starBox
            // 
            starBox.Location = new Point(276, 37);
            starBox.Name = "starBox";
            starBox.Size = new Size(125, 27);
            starBox.TabIndex = 5;
            starBox.Text = "1000";
            starBox.TextChanged += starBox_TextChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 289);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(407, 53);
            clearButton.TabIndex = 6;
            clearButton.Text = "Очистить диаграмму";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Visible = false;
            clearButton.Click += clearButton_Click;
            // 
            // SunCheckBox
            // 
            SunCheckBox.AutoSize = true;
            SunCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            SunCheckBox.ForeColor = Color.White;
            SunCheckBox.Location = new Point(12, 249);
            SunCheckBox.Name = "SunCheckBox";
            SunCheckBox.Size = new Size(167, 24);
            SunCheckBox.TabIndex = 7;
            SunCheckBox.Text = "Подсветить Солнце";
            SunCheckBox.UseVisualStyleBackColor = true;
            SunCheckBox.Visible = false;
            SunCheckBox.CheckedChanged += SunCheckBox_CheckedChanged;
            // 
            // MainSequenceBox
            // 
            MainSequenceBox.AutoSize = true;
            MainSequenceBox.CheckAlign = ContentAlignment.MiddleRight;
            MainSequenceBox.ForeColor = Color.White;
            MainSequenceBox.Location = new Point(12, 189);
            MainSequenceBox.Name = "MainSequenceBox";
            MainSequenceBox.Size = new Size(234, 24);
            MainSequenceBox.TabIndex = 8;
            MainSequenceBox.Text = "Главная последовательность";
            MainSequenceBox.UseVisualStyleBackColor = true;
            MainSequenceBox.Visible = false;
            MainSequenceBox.CheckedChanged += MainSequenceBox_CheckedChanged;
            // 
            // WhiteDwarfsBox
            // 
            WhiteDwarfsBox.AutoSize = true;
            WhiteDwarfsBox.CheckAlign = ContentAlignment.MiddleRight;
            WhiteDwarfsBox.ForeColor = Color.White;
            WhiteDwarfsBox.Location = new Point(263, 189);
            WhiteDwarfsBox.Name = "WhiteDwarfsBox";
            WhiteDwarfsBox.Size = new Size(138, 24);
            WhiteDwarfsBox.TabIndex = 13;
            WhiteDwarfsBox.Text = "Белые Карлики";
            WhiteDwarfsBox.UseVisualStyleBackColor = true;
            WhiteDwarfsBox.Visible = false;
            WhiteDwarfsBox.CheckedChanged += WhiteDwarfsBox_CheckedChanged;
            // 
            // redGiantsBox
            // 
            redGiantsBox.AutoSize = true;
            redGiantsBox.CheckAlign = ContentAlignment.MiddleRight;
            redGiantsBox.ForeColor = Color.White;
            redGiantsBox.Location = new Point(12, 219);
            redGiantsBox.Name = "redGiantsBox";
            redGiantsBox.Size = new Size(152, 24);
            redGiantsBox.TabIndex = 14;
            redGiantsBox.Text = "Красные Гиганты";
            redGiantsBox.UseVisualStyleBackColor = true;
            redGiantsBox.Visible = false;
            redGiantsBox.CheckedChanged += redGiantsBox_CheckedChanged;
            // 
            // BrightGiantsBox
            // 
            BrightGiantsBox.AutoSize = true;
            BrightGiantsBox.CheckAlign = ContentAlignment.MiddleRight;
            BrightGiantsBox.ForeColor = Color.White;
            BrightGiantsBox.Location = new Point(168, 219);
            BrightGiantsBox.Name = "BrightGiantsBox";
            BrightGiantsBox.Size = new Size(133, 24);
            BrightGiantsBox.TabIndex = 15;
            BrightGiantsBox.Text = "Яркие Гиганты";
            BrightGiantsBox.UseVisualStyleBackColor = true;
            BrightGiantsBox.Visible = false;
            BrightGiantsBox.CheckedChanged += BrightGiants_CheckedChanged;
            // 
            // SuperGiantsBox
            // 
            SuperGiantsBox.AutoSize = true;
            SuperGiantsBox.CheckAlign = ContentAlignment.MiddleRight;
            SuperGiantsBox.ForeColor = Color.White;
            SuperGiantsBox.Location = new Point(307, 219);
            SuperGiantsBox.Name = "SuperGiantsBox";
            SuperGiantsBox.Size = new Size(127, 24);
            SuperGiantsBox.TabIndex = 16;
            SuperGiantsBox.Text = "Сверхгиганты";
            SuperGiantsBox.UseVisualStyleBackColor = true;
            SuperGiantsBox.Visible = false;
            SuperGiantsBox.CheckedChanged += SuperGiantsBox_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.BackColor = Color.FromArgb(29, 36, 60);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 396);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(407, 454);
            textBox1.TabIndex = 17;
            textBox1.Visible = false;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InfoLabel.ForeColor = Color.White;
            InfoLabel.Location = new Point(12, 359);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(240, 25);
            InfoLabel.TabIndex = 18;
            InfoLabel.Text = "Справочная информация:";
            InfoLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 33, 56);
            ClientSize = new Size(1442, 903);
            Controls.Add(InfoLabel);
            Controls.Add(textBox1);
            Controls.Add(SuperGiantsBox);
            Controls.Add(BrightGiantsBox);
            Controls.Add(redGiantsBox);
            Controls.Add(WhiteDwarfsBox);
            Controls.Add(MainSequenceBox);
            Controls.Add(SunCheckBox);
            Controls.Add(clearButton);
            Controls.Add(starBox);
            Controls.Add(label1);
            Controls.Add(starScroll);
            Controls.Add(ReadFromFileButton);
            Controls.Add(diagram);
            MinimumSize = new Size(1200, 700);
            Name = "Form1";
            Text = "Диаграмма Герцшпрунга-Рассела";
            ((System.ComponentModel.ISupportInitialize)starScroll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.FormsPlot diagram;
        private Button ReadFromFileButton;
        private OpenFileDialog openFileDialog1;
        private TrackBar starScroll;
        private Label label1;
        private TextBox starBox;
        private Button clearButton;
        private CheckBox SunCheckBox;
        private CheckBox MainSequenceBox;
        private CheckBox WhiteDwarfsBox;
        private CheckBox redGiantsBox;
        private CheckBox BrightGiantsBox;
        private CheckBox SuperGiantsBox;
        private TextBox textBox1;
        private Label InfoLabel;
    }
}