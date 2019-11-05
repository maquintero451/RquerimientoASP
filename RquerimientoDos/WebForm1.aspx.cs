using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace RquerimientoDos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            ds.ReadXml(Server.MapPath("categoria.xml"));
            dpl.DataSource = ds;
            dpl.DataTextField = "NomCat";
            dpl.DataBind();
          
            ds2.ReadXml(Server.MapPath("producto.xml"));
            dv.DataSource = ds2.Tables[0];
            dv.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string json1 = JsonConvert.SerializeObject(ds, Formatting.Indented);
            lblUno.Text = json1;
            string json2 = JsonConvert.SerializeObject(ds2, Formatting.Indented);
            lbl2.Text = json2;
        }
    }
}