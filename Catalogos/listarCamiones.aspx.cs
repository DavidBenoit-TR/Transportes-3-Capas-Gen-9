using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Transportes_3_Capas_Gen_9.Catalogos
{
    public partial class listarCamiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //la varaible IsPostBack representa la primera vez que carga la página
            if (!IsPostBack)
            {
                try
                {
                    CargarGrid();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public void CargarGrid()
        {
            //Cargar la ifnormación desde la BLL al GV
            GVCamiones.DataSource = BLL_Camiones.get_Camiones();
            //Mostramos los resultados renderizando la información
            GVCamiones.DataBind();
        }

        protected void Insertar_Click(object sender, EventArgs e)
        {

        }

        protected void GVCamiones_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GVCamiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GVCamiones_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GVCamiones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GVCamiones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}