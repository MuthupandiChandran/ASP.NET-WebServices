using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculateWebServiceSoapClient client = new CalculatorService.CalculateWebServiceSoapClient();
            int result = client.Add(Convert.ToInt32(txtFirstNumber.Text),Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
           
             gvCalculations.DataSource = client.GetAll();
             gvCalculations.DataBind();
             gvCalculations.HeaderRow.Cells[0].Text = "Recent Calculations";
        }
    }
}