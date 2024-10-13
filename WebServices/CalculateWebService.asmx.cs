using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")] //WebService Attribute Tells Below Implementations is for WebServices
    [WebServiceBinding(ConformsTo = WsiProfiles.None)] //Using webmethod Overloading need top change this 
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculateWebService : System.Web.Services.WebService
    {
        [WebMethod(MessageName ="Add3Numbers")] //WebMethodOverloading
        public int Add(int FirstNumber,int SecondNumber,int ThirdNumber)
        {
            return FirstNumber + SecondNumber + ThirdNumber;
        }
        
        
        [WebMethod(EnableSession = true,Description="This Method Adds 2 Numbers",CacheDuration = 20)] //Using Session We've to List Out the Previous Transactions That User Has been Made 
        public int Add(int FirstNumber, int SecondNumber)
        {

            List<string> calculations;
            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }
            string strRecentCalculations = FirstNumber.ToString() + "+" + SecondNumber.ToString() +
                " = " + (FirstNumber + SecondNumber).ToString();
            calculations.Add(strRecentCalculations);
            Session["CALCULATIONS"] = calculations;

            return FirstNumber + SecondNumber;
        }


        [WebMethod(EnableSession = true)]
        public List<string> GetAll()
        {
            foreach (string key in Session.Contents)
            {
                string value = "Key:" + key + ",Value:" + Session[key].ToString();
                Console.WriteLine(value);
            }


            //using Null-Coalescing operator we've checking Null values
            return Session["CALCULATIONS"] as List<string> ?? new List<string> { "You Have Not Performed any Calculations" };

        }
    }
}
