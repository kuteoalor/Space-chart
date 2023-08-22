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
            SunButton = new Button();
            starScroll = new TrackBar();
            label1 = new Label();
            starBox = new TextBox();
            clearButton = new Button();
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
            // SunButton
            // 
            SunButton.Enabled = false;
            SunButton.Location = new Point(12, 117);
            SunButton.Name = "SunButton";
            SunButton.Size = new Size(390, 53);
            SunButton.TabIndex = 2;
            SunButton.Text = "Подсветить Солнце";
            SunButton.UseVisualStyleBackColor = true;
            SunButton.Visible = false;
            SunButton.Click += SunButton_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 775);
            Controls.Add(clearButton);
            Controls.Add(starBox);
            Controls.Add(label1);
            Controls.Add(starScroll);
            Controls.Add(SunButton);
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
        private Button SunButton;
        private TrackBar starScroll;
        private Label label1;
        private TextBox starBox;
        private Button clearButton;
    }
}