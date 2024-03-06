using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{

    public class Section
    {
        // Properties
        public string SectionName { get; set; }
        public int Capacity { get; set; }
        public int Parked { get; set; }
        public int Cleared { get; set; }

        // Constructor
        public Section(string sectionName, int capacity, int parked, int cleared)
        {
            SectionName = sectionName;
            Capacity = capacity;
            Parked = parked;
            Cleared = cleared;
        }

        // Method to display section details
        public void DisplaySectionDetails()
        {
            Console.WriteLine($"Section: {SectionName}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Parked: {Parked}");
            Console.WriteLine($"Cleared: {Cleared}");
        }
    }



    public class SectionDB
    {

        private List<Section> sections;
        FlowLayoutPanel flowLayoutPanel1;
        // Constructor
        public SectionDB(FlowLayoutPanel flowLayoutPanel1)
        {
            sections = new List<Section>();
            this.flowLayoutPanel1 = flowLayoutPanel1;
        }

        // Method to add a section to the list
        public void AddSection(Section section)
        {
            sections.Add(section);
        }

        // Method to display all sections
        public void DisplayAllSections()
        {
            foreach (var section in sections)
            {
                section.DisplaySectionDetails();
                Console.WriteLine(); // Add a newline for better readability
            }
        }

        // Method to edit a section based on section name
        public void EditSection(string sectionName, Section updatedSection)
        {
            for (int i = 0; i < sections.Count; i++)
            {
                if (sections[i].SectionName == sectionName)
                {
                    sections[i] = updatedSection;
                    break;
                }
            }
        }

        // Method to delete a section based on section name
        public void DeleteSection(string sectionName)
        {
            sections.RemoveAll(section => section.SectionName == sectionName);
        }

        public List<Section> Sections
        {
            get { return sections; }
        }



        public void DisplaySections()
        {
            Section s1 = new Section("sectionName1", 2, 4, 3);
            Section s2 = new Section("sectionName2", 2, 4, 3);
            Section s3 = new Section("sectionName3", 2, 4, 3);

           
             AddSection(s1);
             AddSection(s2);
             AddSection(s3);

            foreach (var section in Sections)
            {
                // Create a new instance of SectionList for each section
                SectionList sectionList = new SectionList();

                // Update the labels with the details of the current section
                sectionList.UpdateLabels(section);

                // Add the current SectionList to the flowLayoutPanel1
                flowLayoutPanel1.Controls.Add(sectionList);
            }
        }
    }



    public class SectionMain
    {

         
       
    }
}
