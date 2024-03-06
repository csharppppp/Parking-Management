namespace Parking
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 280)
                {
                    menuTransition.Stop();
                    menuExpand = true;

                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 65)
                {
                    menuTransition.Stop();
                    menuExpand = false;

                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;

                if (sidebar.Width <= 68)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;

                if (sidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();


                }
            }
        }

        private void humBtn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void parkout_Click(object sender, EventArgs e)
        {

        }

        private void parkin_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
