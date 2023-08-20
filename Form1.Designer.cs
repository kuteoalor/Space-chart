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
            SuspendLayout();
            // 
            // diagram
            // 
            diagram.AutoSize = true;
            diagram.Location = new Point(489, 13);
            diagram.Margin = new Padding(5, 4, 5, 4);
            diagram.Name = "diagram";
            diagram.Size = new Size(939, 780);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 775);
            Controls.Add(ReadFromFileButton);
            Controls.Add(diagram);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.FormsPlot diagram;
        private Button ReadFromFileButton;
        private OpenFileDialog openFileDialog1;
    }
}