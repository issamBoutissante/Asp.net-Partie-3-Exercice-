using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice
{
    public partial class Match : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
            switch (((DropDownList)DropDownList1).SelectedIndex)
            {
                case 1:
                    Calendar1.SelectedDate = new DateTime(2021, 02, 20);
                    Calendar1.VisibleDate = Calendar1.SelectedDate;
                    Label1.Text=$"Match : {DropDownList1.Text}<br/>Le : {Calendar1.SelectedDate}";
                    break;
                case 2:
                    Calendar1.SelectedDate = new DateTime(2021, 03, 20);
                    Calendar1.VisibleDate = Calendar1.SelectedDate;
                    Label1.Text = $"Match : {DropDownList1.Text}<br/>Le : {Calendar1.SelectedDate}";
                    break;
                    Calendar1.SelectedDate = new DateTime(2021, 04, 20);
                    Calendar1.VisibleDate = Calendar1.SelectedDate;
                    Label1.Text = $"Match : {DropDownList1.Text}<br/>Le : {Calendar1.SelectedDate}";
                case 3:
                    break;
                default:
                    Calendar1.Visible = false;
                    Label1.Text = "aucun match selectione";
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.SelectedDate = new DateTime(2023, 10, 02);
            Calendar1.VisibleDate = Calendar1.SelectedDate;
            Label1.Text = $"Match : {DropDownList1.Text}<br/>Le : {Calendar1.SelectedDate}";
        }
    }
}