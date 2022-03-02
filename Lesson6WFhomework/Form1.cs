using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Lesson6WFhomework
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> cultureList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                }
            }

            m_cmb_countries.DataSource = cultureList;

            m_cmb_playerPosition.DataSource = new List<string>() { "4-3-3", "3-4-3", "3-3-4", "2-4-4", "4-2-4", "4-4-2" };
        }

        private void m_cmb_playerPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_cmb_playerPosition.Text == "4-3-3")
            {
                pos10.Text = "DD";
                pos9.Text = "DD";
                pos8.Text = "DD";
                pos7.Text = "DD";
                pos6.Text = "MD";
                pos5.Text = "MD";
                pos4.Text = "MD";
                pos3.Text = "F";
                pos2.Text = "F";
                pos1.Text = "F";
            }
            else if (m_cmb_playerPosition.Text == "3-4-3")
            {
                pos10.Text = "DD";
                pos9.Text = "DD";
                pos8.Text = "DD";
                pos7.Text = "MD";
                pos6.Text = "MD";
                pos5.Text = "MD";
                pos4.Text = "MD";
                pos3.Text = "F";
                pos2.Text = "F";
                pos1.Text = "F";
            }
            else if (m_cmb_playerPosition.Text == "3-3-4")
            {
                pos10.Text = "DD";
                pos9.Text = "DD";
                pos8.Text = "DD";
                pos7.Text = "MD";
                pos6.Text = "MD";
                pos5.Text = "MD";
                pos4.Text = "F";
                pos3.Text = "F";
                pos2.Text = "F";
                pos1.Text = "F";
            }
            else if (m_cmb_playerPosition.Text == "2-4-4")
            {
                pos10.Text = "DD";
                pos9.Text = "DD";
                pos8.Text = "MD";
                pos7.Text = "MD";
                pos6.Text = "MD";
                pos5.Text = "MD";
                pos4.Text = "F";
                pos3.Text = "F";
                pos2.Text = "F";
                pos1.Text = "F";
            }
            else if (m_cmb_playerPosition.Text == "4-2-4")
            {
                pos10.Text = "DD";
                pos9.Text = "DD";
                pos8.Text = "DD";
                pos7.Text = "DD";
                pos6.Text = "MD";
                pos5.Text = "MD";
                pos4.Text = "F";
                pos3.Text = "F";
                pos2.Text = "F";
                pos1.Text = "F";
            }
            else if (m_cmb_playerPosition.Text == "4-4-2")
            {
                pos10.Text = "DD";
                pos9.Text = "DD";
                pos8.Text = "DD";
                pos7.Text = "DD";
                pos6.Text = "MD";
                pos5.Text = "MD";
                pos4.Text = "MD";
                pos3.Text = "MD";
                pos2.Text = "F";
                pos1.Text = "F";
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (player1Num.Text.Length == 0 || player2Num.Text.Length == 0 ||
                player3Num.Text.Length == 0 || player4Num.Text.Length == 0 || player5Num.Text.Length == 0 ||
                player6Num.Text.Length == 0 || player7Num.Text.Length == 0 || player8Num.Text.Length == 0 ||
                player9Num.Text.Length == 0 || player10Num.Text.Length == 0 || player11Num.Text.Length == 0 ||

                player1Name.Text.Length == 0 || player2Name.Text.Length == 0 || player3Name.Text.Length == 0 ||
                player4Name.Text.Length == 0 || player5Name.Text.Length == 0 || player6Name.Text.Length == 0 ||
                player7Name.Text.Length == 0 || player8Name.Text.Length == 0 || player9Name.Text.Length == 0 ||
                player10Name.Text.Length == 0 || player11Name.Text.Length == 0
                )
                return;

            List<int> numbers = new List<int>();
            numbers.Add(int.Parse(player1Num.Text));
            numbers.Add(int.Parse(player2Num.Text));
            numbers.Add(int.Parse(player3Num.Text));
            numbers.Add(int.Parse(player4Num.Text));
            numbers.Add(int.Parse(player5Num.Text));
            numbers.Add(int.Parse(player6Num.Text));
            numbers.Add(int.Parse(player7Num.Text));
            numbers.Add(int.Parse(player8Num.Text));
            numbers.Add(int.Parse(player9Num.Text));
            numbers.Add(int.Parse(player10Num.Text));
            numbers.Add(int.Parse(player11Num.Text));

            bool check = true;

            foreach (var item in numbers)
                if (numbers.FindAll(num => num == item).Count > 1)
                    check = false;
            if (!check)
                return;


            GeneratedTeam generatedTeam = new GeneratedTeam(m_cmb_playerPosition.Text);
            generatedTeam.lbl_country.Text = m_cmb_countries.Text;
            Visible = false;
            var result = generatedTeam.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                generatedTeam.Close();
            }
            Visible = true;
        }
    }
}
