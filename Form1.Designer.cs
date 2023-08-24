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
            ((System.ComponentModel.ISupportInitialize)starScroll).BeginInit();
            SuspendLayout();
            // 
            // diagram
            // 
            diagram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            diagram.AutoSize = true;
            diagram.Location = new Point(771, 13);
            diagram.Margin = new Padding(5, 4, 5, 4);
            diagram.MaximumSize = new Size(1080, 1080);
            diagram.Name = "diagram";
            diagram.Size = new Size(657, 749);
            diagram.TabIndex = 0;
            diagram.Load += diagram_Load;
            // 
            // ReadFromFileButton
            // 
            ReadFromFileButton.Location = new Point(12, 45);
            ReadFromFileButton.Name = "ReadFromFileButton";
            ReadFromFileButton.Size = new Size(390, 53);
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
            starScroll.Location = new Point(12, 248);
            starScroll.Maximum = 200000;
            starScroll.Name = "starScroll";
            starScroll.Size = new Size(390, 56);
            starScroll.SmallChange = 5000;
            starScroll.TabIndex = 3;
            starScroll.Value = 1000;
            starScroll.Scroll += starScroll_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 198);
            label1.Name = "label1";
            label1.Size = new Size(258, 31);
            label1.TabIndex = 4;
            label1.Text = "Сколько звезд считать?";
            // 
            // starBox
            // 
            starBox.Location = new Point(277, 202);
            starBox.Name = "starBox";
            starBox.Size = new Size(125, 27);
            starBox.TabIndex = 5;
            starBox.Text = "1000";
            starBox.TextChanged += starBox_TextChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 310);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(390, 53);
            clearButton.TabIndex = 6;
            clearButton.Text = "Очистить диаграмму";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // SunCheckBox
            // 
            SunCheckBox.AutoSize = true;
            SunCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            SunCheckBox.Location = new Point(12, 131);
            SunCheckBox.Name = "SunCheckBox";
            SunCheckBox.Size = new Size(167, 24);
            SunCheckBox.TabIndex = 7;
            SunCheckBox.Text = "Подсветить Солнце";
            SunCheckBox.UseVisualStyleBackColor = true;
            SunCheckBox.Visible = false;
            SunCheckBox.CheckedChanged += SunCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 775);
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
    }
}