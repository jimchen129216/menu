using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int total;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
           
         }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
          
    }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                int number1 = Convert.ToInt32(DropDownList1.SelectedValue);
                int food1 = Convert.ToInt32(TextBox1.Text);
           
                total += number1 * food1;
            }
            if (CheckBox2.Checked == true)
            {
                int food2 = Convert.ToInt32(TextBox3.Text);
                int number2 = Convert.ToInt32(DropDownList2.SelectedValue);
                total += food2 * number2;
            }
            if (CheckBox3.Checked == true)
            {
                int food3 = Convert.ToInt32(TextBox5.Text);
                int number3 = Convert.ToInt32(DropDownList3.SelectedValue);
                total += food3 * number3;
            }

           
          /*  for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if(ListBox1.Items[i].Selected)
                {
                    TextBox6.Text += ListBox1.Items[i].Text+"\r";
                }
            }*/
            price.Text = Convert.ToString(total);


        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBox6.Text = "";
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (ListBox1.Items[i].Selected)
                {
                    TextBox6.Text += ListBox1.Items[i].Text + "\r";
                }
            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*當更改熟度後 會立即更改並顯示 (未完成)*/
            string a = "";
            hot.Text= RadioButtonList1.SelectedItem.Text;


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Double a1,b1,c;
            a1 =Convert.ToInt32(DropDownList1.Text);
           
              if (a1>=6)
              {
              
                  TextBox1.Text = Convert.ToString(70);
              }
               else
            {

                TextBox1.Text = Convert.ToString(100);
            }
            b1 = Convert.ToInt32(TextBox1.Text);
            c = a1 * b1;
            Literal1.Text = Convert.ToString(c);
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double a1, b1, c;
            a1 = Convert.ToInt32(DropDownList2.Text);

            if (a1 >= 6)
            {

                TextBox3.Text = Convert.ToString(98);
            }
            else
            {

                TextBox3.Text = Convert.ToString(140);
            }
            b1 = Convert.ToInt32(TextBox3.Text);
            c = a1 * b1;
            Literal2.Text = Convert.ToString(c);
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double a1, b1, c;
            a1 = Convert.ToInt32(DropDownList3.Text);

            if (a1 >= 6)
            {

                TextBox5.Text = Convert.ToString(210);
            }
            else
            {

                TextBox5.Text = Convert.ToString(300);
            }
            b1 = Convert.ToInt32(TextBox5.Text);
            c = a1 * b1;
            Literal3.Text = Convert.ToString(c);
        }
    }
}