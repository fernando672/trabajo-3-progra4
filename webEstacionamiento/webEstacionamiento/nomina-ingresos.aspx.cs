using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webEstacionamiento
{
    public partial class nomina_ingresos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (BDEstacionamientoEntities db = new BDEstacionamientoEntities())
            {
                gdvDatos.DataSource = db.patentes.ToList();
                gdvDatos.DataBind();
            }
        }
    }
}