using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webEstacionamiento
{
    public partial class registro_egresos : System.Web.UI.Page
    {
        DateTime horaSalida = DateTime.Now;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            String patente = Request.Form["txtPatente"].ToString();
            
            using(BDEstacionamientoEntities BD = new BDEstacionamientoEntities())
            {
                var select = BD.patentes.Where(a => a.Patente == patente).FirstOrDefault();
                lblHora.Text = Convert.ToString(select.Fecha_Ingreso);

            }
            DateTime horaLlegada = Convert.ToDateTime(lblHora.Text);
            double abc = calculo(horaLlegada, horaSalida);
            int abcd = catolica(horaLlegada, horaSalida);
            lblMonto.Text = "$ " + Convert.ToString(abc);
            lblSegundos.Text = Convert.ToString(abcd);
        }

        public int calculo(DateTime horaLlegada, DateTime horaSalida)
        {
            TimeSpan duracion = horaSalida - horaLlegada;
            double segundosTotales = duracion.TotalSeconds;
            int montoCancelar = Convert.ToInt32(segundosTotales*0.2);

            return montoCancelar;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }

        protected void btnCobrar_Click(object sender, EventArgs e)
        {
            DateTime horaLlegada = Convert.ToDateTime(lblHora.Text);
            Int32 abc = Convert.ToInt32(calculo(horaLlegada, horaSalida));
            String patente = Request.Form["txtPatente"].ToString();
 
            using(BDEstacionamientoEntities BD2 = new BDEstacionamientoEntities())
            {
                var update = BD2.patentes.Where(a => a.Patente == patente).FirstOrDefault();
                update.Fecha_Egreso = DateTime.Now;
                update.Estado = "Cancelado";
                update.Monto = abc;

                BD2.SaveChanges();
                Response.Redirect("main.aspx");
            }
        }
        public int catolica(DateTime horaLlegada, DateTime horaSalida)
        {
            TimeSpan duracion = horaSalida - horaLlegada;
            double segundosTotales = duracion.TotalSeconds;
            int segundos = Convert.ToInt32(segundosTotales);

            return segundos;
        }
    }
}