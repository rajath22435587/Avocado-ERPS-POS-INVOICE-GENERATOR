using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static Avocado_ERPS_POS_INVOICE_GENERATOR.DBclient;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Avocado_ERPS_POS_INVOICE_GENERATOR
{
    public partial class Form1 : MaterialForm
    {
        DBclient Dbclient = new DBclient();

        public Form1()
        {
            InitializeComponent();
           
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );

            if (Dbclient.CheckConnection())
            {
                Status_Lable_NonEdit.Text = "Online";
            }
            else Status_Lable_NonEdit.Text = "Offline";
            Dbclient.CloseConnection();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Password_Input_TextField_Click(object sender, EventArgs e)
        {

        }

        private void Username_Input_TextField_Click(object sender, EventArgs e)
        {

        }

        private void Login_Input_Button_Click(object sender, EventArgs e)
        {
            Dbclient.DoLogin(Username_Input_TextField.Text, Password_Input_TextField.Text);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
