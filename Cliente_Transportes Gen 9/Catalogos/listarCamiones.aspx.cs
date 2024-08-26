using Cliente_Transportes_Gen_9.Utilidades;
using Cliente_Transportes_Gen_9.WS_Camiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_Transportes_Gen_9.Catalogos
{
    public partial class listarCamiones : System.Web.UI.Page
    {
        ////Creando el Objeto del Servicios
        WS_CamionesSoapClient cliente_WS;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Instancio la referencia del servicio
            cliente_WS = new WS_CamionesSoapClient();

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
            GVCamiones.DataSource = cliente_WS.get_Camiones(new ArrayOfAnyType { });
            //Mostramos los resultados renderizando la información
            GVCamiones.DataBind();
        }

        protected void Insertar_Click(object sender, EventArgs e)
        {
            //Hago la redirección a mi formulario de crear un nuevo Camión
            Response.Redirect("FormularioCamion.aspx");
        }

        protected void GVCamiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //recupero el ID del renglón efectao
            int idcamion = int.Parse(GVCamiones.DataKeys[e.RowIndex].Values["Idcamion"].ToString());
            ////Invoco mi método para eliminar camiones desde la BLL
            string respuesta = cliente_WS.eliminar_Camion(idcamion);
            //Preparamos el Sweet Alert
            string titulo, msg, tipo;
            if (respuesta.ToUpper().Contains("ERROR"))
            {
                titulo = "Error";
                msg = respuesta;
                tipo = "error";
            }
            else
            {
                titulo = "Correcto!";
                msg = respuesta;
                tipo = "success";
            }
            //Sweet alert
            SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType());
            //Recargamos el Grid
            CargarGrid();
        }

        protected void GVCamiones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //defino si el comando (el click que se detecta) tiene la propiedad "Select")
            if (e.CommandName == "Select")
            {
                //recupero el índice en función de aquel elemento que haya detonado el evento
                int varIndex = int.Parse(e.CommandArgument.ToString());
                //recupero el ID en función del índice que recuperamos
                string id = GVCamiones.DataKeys[varIndex].Values["Idcamion"].ToString();
                //redirecciono al formulario de edición, pasando como parámetro el ID
                Response.Redirect("FormularioCamion.aspx?Id=" + id);
            }
        }

        protected void GVCamiones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Creamos un nuevo índice de Edición
            GVCamiones.EditIndex = e.NewEditIndex;
            CargarGrid();
        }

        protected void GVCamiones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Recupero el id en función del índice de aquel que detonó el evento
            int idcamion = int.Parse(GVCamiones.DataKeys[e.RowIndex].Values["Idcamion"].ToString());
            //Recupero y creo nuevos índices de edición en función de los campos que serán editables (las columnas existentes)
            string matricula = e.NewValues["Matricula"].ToString();
            string TipoCamion = e.NewValues["TipoCamion"].ToString();
            string Foto = e.NewValues["UrlFoto"].ToString();
            CheckBox chaux = (CheckBox)GVCamiones.Rows[e.RowIndex].FindControl("chkEditDisponible");
            bool disponibilidad = chaux.Checked;
            //Recupero el Objeto Original
            Camiones_VO _camion = cliente_WS.get_Camion_by_ID(idcamion);
            //creo un nuevo objeto para enviar con los datos modificados
            Camiones_VO _camionAux = new Camiones_VO();
            //asignamos los valores que vamos a actualizar
            _camionAux.Idcamion = idcamion;
            _camionAux.Matricula = matricula;
            _camionAux.Disponibilidad = disponibilidad;
            _camionAux.TipoCamion = TipoCamion;
            _camionAux.UrlFoto = Foto;
            //Asignamos los valores anteriores
            _camionAux.Marca = _camion.Marca;
            _camionAux.Modelo = _camion.Modelo;
            _camionAux.Capacidad = _camion.Capacidad;
            _camionAux.Kilometraje = _camion.Kilometraje;

            //Configurar el Sweet Alert
            string respuesta = "";
            string titulo, msg, tipo;

            try
            {
                //invoco mi método de actualizar desde la capa BLL pasándole el nuevo objeto
                respuesta = cliente_WS.actualizar_Camion(_camionAux);
                //Configuración para el Sweet Alert
                if (respuesta.ToUpper().Contains("ERROR"))
                {
                    titulo = "Ops...";
                    msg = respuesta;
                    tipo = "error";
                }
                else
                {
                    titulo = "Correcto!";
                    msg = respuesta;
                    tipo = "success";
                }
            }
            catch (Exception ex)
            {
                titulo = "Ops...";
                msg = ex.Message;
                tipo = "error";
            }
            //Sweet Alert
            SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType());
            //Reiniciar los ínidces de Edición
            GVCamiones.EditIndex = -1;
            //recargar el Grid
            CargarGrid();
        }

        protected void GVCamiones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reinicio los ínidices de Edición
            GVCamiones.EditIndex = -1;
            //Recargo el Grid
            CargarGrid();
        }

        protected void Sweet_Click(object sender, EventArgs e)
        {
            SweetAlert.Sweet_Alert("Hula", "Esto es una prueba de Sweet Alert", "success", this.Page, this.GetType());
        }
    }
}