using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Parking
{
    public partial class section : UserControl
    {
        public section()
        {
            InitializeComponent();
            SectionDB secDb = new SectionDB(flowLayoutPanel1);
            secDb.DisplaySections();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SectionMain sectionManager = new SectionMain();
            sectionForm secForm = new sectionForm(flowLayoutPanel1);
            secForm.Show();


        }

        private void section_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int borderRadius = 20; // You can adjust the value to change the roundness of the corners
            int width = panel2.Width;
            int height = panel2.Height;
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Top-left corner
            path.AddArc(width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Top-right corner
            path.AddArc(width - borderRadius, height - borderRadius, borderRadius, borderRadius, 0, 90); // Bottom-right corner
            path.AddArc(0, height - borderRadius, borderRadius, borderRadius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the region of the panel to the rounded rectangle shape
            panel2.Region = new Region(path);

            // Optionally, you can set a background color or add other painting code here
            panel2.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void section_Load_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           

        }
    }
}
