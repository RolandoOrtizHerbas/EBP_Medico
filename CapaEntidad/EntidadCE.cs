using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntidadCE
    {
        public class UsuarioCE
        {
            public string Usuario { get; set; }
            public string Perfil { get; set; }
            public string PAssword { get; set; }
            public string Comentario { get; set; }
            public string RespuestaComentario { get; set; }
            public DateTime Fecha { get; set; }
            public string Estatus { get; set; }
            public DateTime FechaFinal { get; set; }
            public string UsuarioMod { get; set; }

        }


    }
}
