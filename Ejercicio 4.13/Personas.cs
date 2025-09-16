using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4._13
{
    internal class Personas
    {
        private string apellido;
        private string nombre;
        private string tipoDoc;
        private int documento;
        private string estadoCivil;
        private string sexo;
        private string fallecido;


        public string pApellido
        { get { return apellido; } set { apellido = value; } }

        public string pNombre
        { get { return nombre; } set { nombre = value; } }

        public string pTipoDoc
        { get { return tipoDoc; } set { tipoDoc = value; } }

        public int pDocumento
        { get { return documento; } set { documento = value; } }

        public string pEstadoCivil
        { get { return estadoCivil; } set { estadoCivil = value; } }

        public string pSexo
        { get { return sexo; } set { sexo = value; } }

        public string pFallecido
        { get { return fallecido; } set { fallecido = value; }
        }

        public Personas(string apellido, string nombre, string tipoDoc, int documento, string estadoCivil, 
            string sexo, string fallecido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.tipoDoc = tipoDoc;
            this.documento = documento;
            this.estadoCivil = estadoCivil;
            this.sexo = sexo;
            this.fallecido = fallecido;

        }
        public Personas()
        {
            apellido = string.Empty;
            nombre = string.Empty;
            tipoDoc = string.Empty;
            documento = 0;
            estadoCivil = string.Empty;
            sexo = string.Empty;
            fallecido = string.Empty;

        }
        public override string ToString()
        {
            return "Apellido/s: " + apellido +
                " |\nNombre/s: " + nombre +
                " |\nTipo Documento: " + tipoDoc +
                " |\nDocumento: " + documento +
                " |\nEstado Civil: " + estadoCivil +
                " |\nSexo: " + sexo + " "
                  + fallecido;

        }
    }
}
