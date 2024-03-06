namespace Parking
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            humBtn = new PictureBox();
            sidebar = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            menu = new Button();
            panel1 = new Panel();
            parkin = new Button();
            panel3 = new Panel();
            parkout = new Button();
            button1 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            section1 = new section();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)humBtn).BeginInit();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(humBtn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1862, 46);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // humBtn
            // 
            humBtn.Image = (Image)resources.GetObject("humBtn.Image");
            humBtn.Location = new Point(3, 3);
            humBtn.Name = "humBtn";
            humBtn.Size = new Size(63, 52);
            humBtn.TabIndex = 1;
            humBtn.TabStop = false;
            humBtn.Click += humBtn_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 28, 75);
            sidebar.BackgroundImageLayout = ImageLayout.None;
            sidebar.Controls.Add(menuContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 46);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(66, 932);
            sidebar.TabIndex = 1;
            sidebar.Paint += sidebar_Paint;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel1);
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(button1);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(248, 308);
            menuContainer.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(menu);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 59);
            panel2.TabIndex = 4;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(31, 28, 75);
            menu.BackgroundImageLayout = ImageLayout.None;
            menu.Cursor = Cursors.Hand;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(0, -12);
            menu.Name = "menu";
            menu.Size = new Size(245, 87);
            menu.TabIndex = 3;
            menu.Text = "Menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(parkin);
            panel1.Location = new Point(3, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 59);
            panel1.TabIndex = 2;
            // 
            // parkin
            // 
            parkin.BackColor = Color.FromArgb(31, 28, 75);
            parkin.BackgroundImageLayout = ImageLayout.None;
            parkin.Cursor = Cursors.Hand;
            parkin.FlatAppearance.BorderSize = 0;
            parkin.FlatStyle = FlatStyle.Flat;
            parkin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkin.ForeColor = Color.White;
            parkin.Image = (Image)resources.GetObject("parkin.Image");
            parkin.ImageAlign = ContentAlignment.MiddleLeft;
            parkin.Location = new Point(0, -12);
            parkin.Name = "parkin";
            parkin.Size = new Size(245, 87);
            parkin.TabIndex = 3;
            parkin.Text = "Parkin";
            parkin.UseVisualStyleBackColor = false;
            parkin.Click += parkin_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(parkout);
            panel3.Location = new Point(3, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 59);
            panel3.TabIndex = 5;
            // 
            // parkout
            // 
            parkout.BackColor = Color.FromArgb(31, 28, 75);
            parkout.BackgroundImageLayout = ImageLayout.None;
            parkout.Cursor = Cursors.Hand;
            parkout.FlatAppearance.BorderSize = 0;
            parkout.FlatStyle = FlatStyle.Flat;
            parkout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkout.ForeColor = Color.White;
            parkout.Image = (Image)resources.GetObject("parkout.Image");
            parkout.ImageAlign = ContentAlignment.MiddleLeft;
            parkout.Location = new Point(0, -12);
            parkout.Name = "parkout";
            parkout.Size = new Size(245, 87);
            parkout.TabIndex = 3;
            parkout.Text = "Parkout";
            parkout.UseVisualStyleBackColor = false;
            parkout.Click += parkout_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 28, 75);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 198);
            button1.Name = "button1";
            button1.Size = new Size(245, 63);
            button1.TabIndex = 4;
            button1.Text = "section";
            button1.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // section1
            // 
            section1.BackColor = Color.FromArgb(22, 19, 64);
            section1.BackgroundImageLayout = ImageLayout.None;
            section1.Dock = DockStyle.Fill;
            section1.Location = new Point(66, 46);
            section1.Name = "section1";
            section1.Size = new Size(1796, 932);
            section1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 978);
            Controls.Add(section1);
            Controls.Add(sidebar);
            Controls.Add(flowLayoutPanel1);
            Cursor = Cursors.Hand;
            IsMdiContainer = true;
            MinimumSize = new Size(1874, 1025);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)humBtn).EndInit();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox humBtn;
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button parkin;
        private Panel panel2;
        private Button menu;
        private Panel panel3;
        private Button parkout;
        private FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button button1;
        private section section1;
    }
}
