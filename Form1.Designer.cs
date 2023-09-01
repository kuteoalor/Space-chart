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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            WhiteDwarfsBox = new CheckBox();
            redGiantsBox = new CheckBox();
            BrightGiantsBox = new CheckBox();
            SuperGiantsBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)starScroll).BeginInit();
            SuspendLayout();
            // 
            // diagram
            // 
            diagram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            diagram.AutoSize = true;
            diagram.Location = new Point(458, 13);
            diagram.Margin = new Padding(5, 4, 5, 4);
            diagram.MaximumSize = new Size(1080, 1080);
            diagram.Name = "diagram";
            diagram.Size = new Size(970, 749);
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
            openFileDialog1.FileName = "openFileDialog1";
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
            MainSequenceBox.Location = new Point(12, 189);
            MainSequenceBox.Name = "MainSequenceBox";
            MainSequenceBox.Size = new Size(234, 24);
            MainSequenceBox.TabIndex = 8;
            MainSequenceBox.Text = "Главная последовательность";
            MainSequenceBox.UseVisualStyleBackColor = true;
            MainSequenceBox.Visible = false;
            MainSequenceBox.CheckedChanged += MainSequenceBox_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(121, 539);
            button1.Name = "button1";
            button1.Size = new Size(221, 29);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 603);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 605);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(93, 665);
            button2.Name = "button2";
            button2.Size = new Size(249, 36);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // WhiteDwarfsBox
            // 
            WhiteDwarfsBox.AutoSize = true;
            WhiteDwarfsBox.CheckAlign = ContentAlignment.MiddleRight;
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
            SuperGiantsBox.Location = new Point(307, 219);
            SuperGiantsBox.Name = "SuperGiantsBox";
            SuperGiantsBox.Size = new Size(127, 24);
            SuperGiantsBox.TabIndex = 16;
            SuperGiantsBox.Text = "Сверхгиганты";
            SuperGiantsBox.UseVisualStyleBackColor = true;
            SuperGiantsBox.Visible = false;
            SuperGiantsBox.CheckedChanged += SuperGiantsBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 775);
            Controls.Add(SuperGiantsBox);
            Controls.Add(BrightGiantsBox);
            Controls.Add(redGiantsBox);
            Controls.Add(WhiteDwarfsBox);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
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
            Text = "Form1";
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
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private CheckBox WhiteDwarfsBox;
        private CheckBox redGiantsBox;
        private CheckBox BrightGiantsBox;
        private CheckBox SuperGiantsBox;
    }
}