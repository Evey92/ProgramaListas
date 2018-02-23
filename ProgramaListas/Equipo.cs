using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaListas
{
    class Equipo
    {
       string Nombre="numero";
       public string[] integrantes = new string[3];

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public string getNombre()
        {
            return this.Nombre;   
        }

        public void mostrarIntegrantes(ListBox listBox)
        {
            listBox.Items.Add("Equipo: " + getNombre());
            for(int i = 0; i<3; i++)
                listBox.Items.Add(integrantes[i]);
        }
    }
}
