using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)3;
            lblSports.Text = selectedSports + "(을)를 선택했습니다.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var font = FontFamily.Families;

            foreach(FontFamily f in font)
            {
                comFont.Items.Add(f.Name);
            }
        }

        enum Sports : int
        {
            축구, 야구, 농구, 태권도
        }

        private Sports selectedSports;

        void ChangeFont()
        {
            if(comFont.SelectedIndex < 0)
            {
                return;
            }

            FontStyle fs = FontStyle.Regular;

            if (chkBold.Checked)
            {
                fs |= FontStyle.Bold;
            }

            if (chkItalic.Checked)
            {
                fs |= FontStyle.Italic;
            }

            txtMessage.Font = new Font((string)comFont.SelectedItem, 10, fs);
        }

        private void comFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void rdoSoccer_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)0;
            lblSports.Text = selectedSports + "(을)를 선택했습니다.";
        }

        private void rdoBaseball_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)1;
            lblSports.Text = selectedSports + "(을)를 선택했습니다.";
        }

        private void rdoBasketball_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)2;
            lblSports.Text = selectedSports + "(을)를 선택했습니다.";
        }
    }
}
