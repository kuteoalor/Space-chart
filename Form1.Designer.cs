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
            SuspendLayout();
            // 
            // diagram
            // 
            diagram.Location = new Point(523, 13);
            diagram.Margin = new Padding(5, 4, 5, 4);
            diagram.Name = "diagram";
            diagram.Size = new Size(668, 576);
            diagram.TabIndex = 0;
            diagram.Load += diagram_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 594);
            Controls.Add(diagram);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.FormsPlot diagram;
    }
}