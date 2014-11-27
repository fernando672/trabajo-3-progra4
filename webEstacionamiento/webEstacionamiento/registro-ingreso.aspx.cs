using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webEstacionamiento
{
    public partial class registro_ingreso : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            lblHora.Text = Convert.ToString(hora); 

            if (IsPostBack)
            {
            string patente = Request.Form["txtPatente"].ToString();

            patentes est = new patentes()
            {
                Patente = patente,
                Fecha_Ingreso = DateTime.Now,
                Estado = "Activo"

            };
            using (BDEstacionamientoEntities agregar = new BDEstacionamientoEntities())
            {
                agregar.patentes.Add(est);
                agregar.SaveChanges();

            }
            lblResultado.Text = "Guardado con exito";
            }
        }
    }
}