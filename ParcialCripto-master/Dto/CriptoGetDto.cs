using WebApiCripto2.Models;

namespace WebApiCripto2.Dto
{
    public class CriptoGetDto
    {
        public string Nombre { get; set; }

        public string Simbolo { get; set; }

        public double ValorActual { get; set; }

        public DateTime UltimaActualizacion { get; set; }

        public string Categoria { get; set; }

        public string Estado { get; set; }       

    }
}
