using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{

    public partial class sectionForm : Form
    {
        private FlowLayoutPanel flowLayoutPanel1;

        public sectionForm(FlowLayoutPanel flowLayout)
        {
            InitializeComponent();
            flowLayoutPanel1 = flowLayout;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SectionDB secDb = new SectionDB(flowLayoutPanel1);
            string newSecName = secName.Text;
            int NumCapacity = (int)capacity.Value;
            secDb.AddSection(new Section(newSecName, NumCapacity, 0, 0));


            foreach (var section in secDb.Sections)
            {
                // Create a new instance of SectionList for each section
                SectionList sectionList = new SectionList();

                // Update the labels with the details of the current section
                sectionList.UpdateLabels(section);

                // Add the current SectionList to the flowLayoutPanel1
                flowLayoutPanel1.Controls.Add(sectionList);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
