using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HistorialService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string getHistorial(string usuario, string dpi)
        {
            // if (usuario ... bdd)
            // search(...)
            string nombre = "Juan Cristian Elizardi Roches";
            string tipoSangre = "AB+";
            string peso = "80 kg";
            string alergias = "Mariscos";
            string genero = "Hombre";
            string edad = "27 años";

            return "Nombre: " + nombre + " Género: " + genero + " Edad: " + edad + " Peso: " + peso + " Tipo de Sangre: " + tipoSangre + " Alergias: " + alergias;
        }
    }
}
