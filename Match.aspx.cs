using System;
using System.Collections.Generic;

namespace Exercice
{
    public partial class Match : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["matchs"] == null)
            {
                ViewState["matchs"] = new List<ClassMatch>()
                {
                    new ClassMatch(new DateTime(),"selectionner le match"),
                    new ClassMatch(new DateTime(2021, 02, 02), "maroc vs usa"),
                    new ClassMatch(new DateTime(2021, 02, 22), "france vs canada")
                };
            }
            
            if (!IsPostBack)
            {
                List<ClassMatch> matches = (List<ClassMatch>)ViewState["matchs"];
                matches.ForEach((matche) => DropDownList1.Items.Add(matche.NomMatch));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                Calendar1.Visible = false;
                return;
            }
            Calendar1.Visible = true;
            Afficher();
        }
        protected void Afficher()
        {
            List<ClassMatch> matches = (List<ClassMatch>)ViewState["matchs"];
            ClassMatch matche=matches[DropDownList1.SelectedIndex];
            Calendar1.SelectedDate = matche.Date;
            Calendar1.VisibleDate = Calendar1.SelectedDate;
            Label1.Text = $"Match : {matche.NomMatch}<br/>Le : {Calendar1.SelectedDate}";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ((List<ClassMatch>)ViewState["matchs"])[DropDownList1.SelectedIndex].Date = Calendar1.SelectedDate;
            Afficher();
        }
    }
    [Serializable]
    class ClassMatch
    {
        DateTime _date;
        string _nomMatch;
        public DateTime Date { get=>_date; set=>_date=value; }
        public string NomMatch { get => _nomMatch; set => _nomMatch = value; }
        public ClassMatch()
        {

        }
        public ClassMatch(DateTime date,string nom_match)
        {
            this._date = date;
            this._nomMatch = nom_match;
        }
    }
}