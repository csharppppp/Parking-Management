namespace Parking
{
    partial class sectionForm
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
            panel1 = new Panel();
            capacity = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            secName = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)capacity).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(capacity);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(secName);
            panel1.Location = new Point(50, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 220);
            panel1.TabIndex = 0;
            // 
            // capacity
            // 
            capacity.Location = new Point(221, 134);
            capacity.Name = "capacity";
            capacity.Size = new Size(253, 27);
            capacity.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 127);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 3;
            label2.Text = "Capacity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 47);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // secName
            // 
            secName.Location = new Point(221, 53);
            secName.Name = "secName";
            secName.Size = new Size(253, 27);
            secName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(264, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 63);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(20, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 46);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(0, -15);
            button1.Name = "button1";
            button1.Size = new Size(140, 70);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Location = new Point(163, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(124, 46);
            panel4.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(0, -15);
            button2.Name = "button2";
            button2.Size = new Size(140, 70);
            button2.TabIndex = 0;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(22, 19, 70);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(646, 34);
            panel5.TabIndex = 2;
            // 
            // sectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 19, 64);
            ClientSize = new Size(646, 457);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "sectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sectionForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)capacity).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox secName;
        private Label label2;
        private NumericUpDown capacity;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Button button2;
        private Panel panel5;
    }
}