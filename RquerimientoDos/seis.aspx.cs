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
    public partial class seis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string produc = File.ReadAllText(Server.MapPath("categoria.json"));
            DataTable pro = new DataTable();
            productos listP = new productos();
            List<productos> product = (List<productos>)JsonConvert.DeserializeObject(produc, typeof(List<productos>));
            pro.Columns.Add("id", typeof(int));
            pro.Columns.Add("Nombre",typeof(string));
            pro.Columns.Add("idCat",typeof(string));

            pro.Rows.Add(listP.codProd,listP.nomPro,listP.codCat);
            dv.DataSource = pro;
            dv.DataBind();

        }
    }
}