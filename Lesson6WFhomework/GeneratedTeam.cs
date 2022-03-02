using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6WFhomework
{
    public partial class GeneratedTeam : MaterialForm
    {
        public GeneratedTeam()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme =
                new ColorScheme(Primary.BlueGrey900,
                                Primary.BlueGrey900,
                                Primary.BlueGrey500,
                                Accent.LightBlue200,
                                TextShade.WHITE);

            player11.Visible = false;
            player12.Visible = false;
            player13.Visible = false;
            player14.Visible = false;
            player15.Visible = false;
            player16.Visible = false;

            player21.Visible = false;
            player22.Visible = false;
            player23.Visible = false;
            player24.Visible = false;
            player25.Visible = false;
            player26.Visible = false;

            player31.Visible = false;
            player32.Visible = false;
            player33.Visible = false;
            player34.Visible = false;
            player35.Visible = false;
            player36.Visible = false;

        }

        public GeneratedTeam(string txt)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme =
                new ColorScheme(Primary.BlueGrey900,
                                Primary.BlueGrey900,
                                Primary.BlueGrey500,
                                Accent.LightBlue200,
                                TextShade.WHITE);

            player11.Visible = false;
            player12.Visible = false;
            player13.Visible = false;
            player14.Visible = false;
            player15.Visible = false;
            player16.Visible = false;

            player21.Visible = false;
            player22.Visible = false;
            player23.Visible = false;
            player24.Visible = false;
            player25.Visible = false;
            player26.Visible = false;

            player31.Visible = false;
            player32.Visible = false;
            player33.Visible = false;
            player34.Visible = false;
            player35.Visible = false;
            player36.Visible = false;

            if (txt == "4-3-3")
            {
                player12.Visible = true;
                player13.Visible = true;
                player14.Visible = true;
                player15.Visible = true;

                player21.Visible = true;
                player24.Visible = true;
                player26.Visible = true;

                player31.Visible = true;
                player34.Visible = true;
                player36.Visible = true;
            }
            if (txt == "3-4-3")
            {
                player11.Visible = true;
                player14.Visible = true;
                player16.Visible = true;

                player22.Visible = true;
                player23.Visible = true;
                player24.Visible = true;
                player25.Visible = true;

                player31.Visible = true;
                player34.Visible = true;
                player36.Visible = true;
            }
            if (txt == "3-3-4")
            {
                player11.Visible = true;
                player14.Visible = true;
                player16.Visible = true;

                player21.Visible = true;
                player24.Visible = true;
                player26.Visible = true;

                player32.Visible = true;
                player33.Visible = true;
                player34.Visible = true;
                player35.Visible = true;
            }
            if (txt == "2-4-4")
            {
                player12.Visible = true;
                player15.Visible = true;

                player22.Visible = true;
                player23.Visible = true;
                player24.Visible = true;
                player25.Visible = true;

                player32.Visible = true;
                player33.Visible = true;
                player34.Visible = true;
                player35.Visible = true;
            }
            if (txt == "4-2-4")
            {
                player12.Visible = true;
                player13.Visible = true;
                player14.Visible = true;
                player15.Visible = true;

                player22.Visible = true;
                player25.Visible = true;

                player32.Visible = true;
                player33.Visible = true;
                player34.Visible = true;
                player35.Visible = true;
            }
            if (txt == "4-4-2")
            {
                player12.Visible = true;
                player13.Visible = true;
                player14.Visible = true;
                player15.Visible = true;

                player22.Visible = true;
                player23.Visible = true;
                player24.Visible = true;
                player25.Visible = true;

                player32.Visible = true;
                player35.Visible = true;
            }
        }

        public void setter()
        {
            pictureBox3.Visible = true;
        }

        private void GeneratedTeam_Load(object sender, EventArgs e)
        {
            
        }

    }
}
