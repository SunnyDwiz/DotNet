using System;
using System.Collections.Generic;

namespace DotNet
{
    public partial class Home : System.Web.UI.Page
    {
        Dictionary<int, string> CityTel = new Dictionary<int, string>();
        Dictionary<int, string> CityBr = new Dictionary<int, string>();
        Dictionary<int, string> CityJhar = new Dictionary<int, string>();
        Dictionary<int, string> CityMp = new Dictionary<int, string>();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                StateList();
            } 
        }

        protected void StateList()
        {
            Dictionary<int, string> listState = new Dictionary<int, string>();
            listState.Add(0, "Select Any State");
            listState.Add(1, "Telangana");
            listState.Add(2, "Jharkhand");
            listState.Add(3, "MP");
            listState.Add(5, "Biahr");
            drpState.DataSource = listState;
            drpState.DataTextField = "Value";
            drpState.DataValueField = "Key";
            drpState.DataBind();
        }

        protected void TelCity()
        { // Dictionary<int, string> CityTel = new Dictionary<int, string>();
            CityTel.Add(0, "Select City");
            CityTel.Add(1, "hyderabad");
            CityTel.Add(2, "Secunderabad");
            CityTel.Add(3, "kazipet");
            CityTel.Add(4, "Suryapet");
            CityTel.Add(5, "Karimnagar");
            drpCity.DataSource = CityTel;
            drpCity.DataTextField = "Value";
            drpCity.DataValueField = "Key";
            drpCity.DataBind();

        }

        protected void MPCity()
        {
            // Dictionary<int, string> CityMp = new Dictionary<int, string>();
            CityMp.Add(0, "Select City");
            CityMp.Add(1, "Indor");
            CityMp.Add(2, "Bhopal");
            CityMp.Add(3, "Sagar");
            CityMp.Add(4, "Gwalior");
            CityMp.Add(5, "Rewa");
            drpCity.DataSource = CityMp;
            drpCity.DataTextField = "Value";
            drpCity.DataValueField = "Key";
            drpCity.DataBind();
        }

        protected void BrCity()
        {
            //  Dictionary<int, string> CityBr = new Dictionary<int, string>();
            CityBr.Add(0, "Select City");
            CityBr.Add(1, "Patna");
            CityBr.Add(2, "Begusarai");
            CityBr.Add(3, "Muzaffarpur");
            CityBr.Add(4, "Gaya");
            CityBr.Add(5, "Nalanda");
            drpCity.DataSource = CityBr;
            drpCity.DataTextField = "Value";
            drpCity.DataValueField = "Key";
            drpCity.DataBind();
        }

        protected void JHCity()
        {
            //Dictionary<int, string> CityJhar = new Dictionary<int, string>();
            CityJhar.Add(0, "Select City");
            CityJhar.Add(1, "Ranchi");
            CityJhar.Add(2, "Jamsedpur");
            CityJhar.Add(3, "Bokaro");
            CityJhar.Add(4, "Dhanbad");
            CityJhar.Add(5, "Devghar");
            drpCity.DataSource = CityJhar;
            drpCity.DataTextField = "Value";
            drpCity.DataValueField = "Key";
            drpCity.DataBind();

        }

        protected void drpState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpState.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Plaese Select State')</script>");
                drpCity.SelectedIndex = 0;
            }

            else if (drpState.SelectedIndex == 1)
            {
                TelCity();
            }
            else if (drpState.SelectedIndex == 2)
            {
                JHCity();
            }
            else if (drpState.SelectedIndex == 3)
            {
                MPCity();
            }

            else if (drpState.SelectedIndex == 4)
            {
                BrCity();
            }
            else
            {
                Response.Write("<script>alert('Plaese Select State')</script>");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool religion =false, skill=false, gen=false;
            if (txtName.Text != "" && txtMobile.Text != "" && txtMail.Text != "" && drpCity.SelectedIndex != 0 && drpState.SelectedIndex != 0)
            {
                if (rdChrist.Checked  || rdHindu.Checked || rdMuslim.Checked)
                {
                    religion = true;
                }
                else
                {
                    Response.Write("<script>alert('Please select any religion!');</script>");
                }
                if (rdMale.Checked || rdFemale.Checked)
                {
                    gen = true;
                }
                else
                {
                    Response.Write("<script>alert('Please select Gender!');</script>");
                }
                if (chkBoostrap.Checked || chkCsharp.Checked || chkSql.Checked || chkSql.Checked)
                {
                    skill = true;
                }
                else
                {
                    Response.Write("<script>alert('Please select from above Skill!');</script>");
                }
                if (religion == true && gen == true && skill == true)
                {
                    btnSubmit.CssClass = "btn btn-success col-sm-2 col-lg-push-4";
                    Response.Redirect("Welcome.aspx?Name=" + txtName.Text);
                }
            }
            else
            {
                btnSubmit.CssClass = "btn btn-danger col-sm-2 col-lg-push-4";
                Response.Write("<script>alert('Please Fill THe Form Correctly!');</script>");
            }
        }
    }
}