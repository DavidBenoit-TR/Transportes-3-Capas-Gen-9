using Cliente_Transportes_Gen_9.Utilidades;
using Cliente_Transportes_Gen_9.WS_Camiones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_Transportes_Gen_9.Catalogos
{
    public partial class FormularioCamion : System.Web.UI.Page
    {
        WS_CamionesSoapClient cliente_WS;
        protected void Page_Load(object sender, EventArgs e)
        {
            cliente_WS = new WS_CamionesSoapClient();

            //Validar si es Postback
            if (!IsPostBack)
            {
                //Validar si deseo Insertar o Editar
                if (Request.QueryString["Id"] == null)
                {
                    //Voy a Insertar
                    Titulo.Text = "Agregar Camión";
                    Subtitulo.Text = "Registro de un nuevo camión";
                    lbldisponibilidad.Visible = false;
                    chkdisponibilidad.Visible = false;
                    imgfoto.Visible = false;
                    lblurlfoto.Visible = false;
                }
                else
                {
                    //Voy a Actualizar
                    //Recuperar el ID que proviene de la URL
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                    //Obtengo el Objeto Original de la BD y coloco los valores en sus campos correspondientes
                    Camiones_VO _camion_original = cliente_WS.get_Camion_by_ID(id);
                    //Valido, que realmente tenga un nuevo camión
                    if (_camion_original.Idcamion != 0)
                    {
                        //Quiere decir que tengo la información y procedo a colocar sus valores
                        Titulo.Text = "Actualizar Camión";
                        Subtitulo.Text = $"Modificar los datos del Camión #{id}";
                        txtmatricula.Text = _camion_original.Matricula;
                        txtcapacidad.Text = _camion_original.Capacidad.ToString();
                        txtkilometraje.Text = _camion_original.Kilometraje.ToString();
                        txtmarca.Text = _camion_original.Marca.ToString();
                        txtmodelo.Text = _camion_original.Modelo;
                        txttipo_camion.Text = _camion_original.TipoCamion;
                        chkdisponibilidad.Checked = _camion_original.Disponibilidad;
                        imgfoto.ImageUrl = _camion_original.UrlFoto;
                    }
                    else
                    {
                        //Voy pa' tras
                        Response.Redirect("listarCamiones2.aspx");
                    }
                }
            }

        }

        protected void btnsubeimagen_Click(object sender, EventArgs e)
        {
            //este método sirve para guardar y almacenar la imagen en el servidor y posteriormente recuperar la info necesaria para la BD
            //valido si realmente tengo una Imagen
            if (subeimagen.Value != "")
            {
                //recupero el nombre de mi archivo
                string filename = Path.GetFileName(subeimagen.Value);
                //valido la extención del archivo
                string fileext = Path.GetExtension(subeimagen.Value).ToLower();
                if ((fileext != ".jpg") && (fileext != ".png"))
                {
                    //Sweet Alert
                    SweetAlert.Sweet_Alert("Ops...", "Solo se admiten formatos .jpg y .png", "warning", this.Page, this.GetType());
                }
                else
                {
                    //verifico que existe el directorio en el servidor pára poder almacenar las imágenes, si es que no, lo creo
                    string pathdir = Server.MapPath("~/Imagenes/Camiones/");// ~ (virgulilla) hace referencia a la dirección completa del servidor, independientemenete de donde esté instalado, permitiendo que la validación funcione en diferentes entornos
                    //si no existe mi directorio, lo creamos
                    if (!Directory.Exists(pathdir))
                    {
                        //creo el directorio
                        Directory.CreateDirectory(pathdir);
                    }
                    //subimos la imiagen a la carpeta del server
                    subeimagen.PostedFile.SaveAs(pathdir + filename);
                    //recuperamos la ruta de la URL que almacenaremos en la BD
                    string urlfoto = "/Imagenes/Camiones/" + filename;
                    //mostramos en pantalla la URL creada
                    this.urlfoto.Text = urlfoto;
                    //Mostramos la imagen
                    imgcamion.ImageUrl = urlfoto;
                    //Sweet Alert
                }
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            string titulo = "", respuesta = "", tipo = "", salida = "";

            try
            {
                //Opción 1 de Llenado
                //Creamos el objeto que enviasremos para actualziar o insertar
                Camiones_VO _camion_aux = new Camiones_VO();
                //darle los valores de mis controles
                _camion_aux.Matricula = txtmatricula.Text;
                _camion_aux.TipoCamion = txttipo_camion.Text;
                _camion_aux.Marca = txtmarca.Text;
                _camion_aux.Modelo = txtmodelo.Text;
                _camion_aux.Capacidad = int.Parse(txtcapacidad.Text);
                _camion_aux.Kilometraje = double.Parse(txtkilometraje.Text);
                _camion_aux.UrlFoto = imgcamion.ImageUrl;
                _camion_aux.Disponibilidad = chkdisponibilidad.Checked;
                //Opción 2
                Camiones_VO _camion_aux_2 = new Camiones_VO()
                {
                    Matricula = txtmatricula.Text,
                    TipoCamion = txttipo_camion.Text,
                    Marca = txtmarca.Text,
                    Modelo = txtmodelo.Text,
                    Capacidad = int.Parse(txtcapacidad.Text),
                    Kilometraje = double.Parse(txtkilometraje.Text),
                    UrlFoto = imgcamion.ImageUrl,
                    Disponibilidad = chkdisponibilidad.Checked
                };

                //decido si actualizo o insert
                if (Request.QueryString["Id"] == null)
                {
                    //Insertar
                    _camion_aux.Disponibilidad = true;
                    salida = cliente_WS.insertar_Camion(_camion_aux);
                }
                else
                {
                    //Actualizar
                    _camion_aux.Idcamion = int.Parse(Request.QueryString["Id"]);
                    salida = cliente_WS.actualizar_Camion(_camion_aux);
                }

                //Preparamos la salida para cachar un Error y mostrar un Sweet
                if (salida.ToUpper().Contains("ERROR"))
                {
                    titulo = "Ops...";
                    respuesta = salida;
                    tipo = "error";
                }
                else
                {
                    titulo = "Correcto";
                    respuesta = salida;
                    tipo = "success";
                }
            }
            catch (Exception ex)
            {
                titulo = "Error";
                respuesta = ex.Message;
                tipo = "error";
            }
            ////Sweet Alert
            SweetAlert.Sweet_Alert(titulo, respuesta, tipo, this.Page, this.GetType());
        }
    }
}