using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İnternetProgramalama3P
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        double tutar = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
          if(CheckBox1.Checked==true)
            {
                tutar+= 5;
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox2.Checked==true)
            {
                tutar+= 5;
            }
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                tutar+= 5;
            }
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                tutar+= 8;
            }
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                tutar+= 3;
            }
        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 8;
            }

        }

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 10;
            }
        }

        protected void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 15;
            }
        }

        protected void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 13;
            }
        }

        protected void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 10;
            }
        }

        protected void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 18;
            }
        }

        protected void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 10;
            }
        }

        protected void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 8;
            }
        }

        protected void CheckBox14_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 7;
            }
        }

        protected void CheckBox15_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 10;
            }
        }

        protected void CheckBox16_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 5;
            }
        }

        protected void CheckBox17_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 12;
            }
        }

        protected void CheckBox18_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 5;
            }
        }

        protected void CheckBox19_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {
                tutar+= 8;
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton1.Checked==true )
            {
                RadioButton2.Enabled = false;
                tutar+= 15;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(TextBox1.Text);
            tutar *= adet;
            Label17.Text = tutar.ToString();

        }

        protected void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton7.Checked==true )
            {
                RadioButton5.Enabled = false;
                RadioButton8.Enabled = false;

                tutar *= 0.90;
            }
        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton5.Checked==true )
            {
                RadioButton7.Enabled = false;
                RadioButton6.Enabled = false;
                tutar *= 0.85;
                
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton2.Checked==true )
            {
                RadioButton1.Enabled = false;
            }
        }

        protected void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton8.Checked==true)
            {
                RadioButton7.Enabled = false;
            }
        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton6.Checked==true )
            {
                RadioButton5.Enabled = false;
            }
        }
    }
}