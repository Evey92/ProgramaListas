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
        public List<string> integrantes = new List<string>();
        //public string[] integrantes = new string[3];

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public string getNombre()
        {
            return this.Nombre;   
        }

        public void mostrarIntegrantes(ListBox listBox, int tamano)
        {
            listBox.Items.Add("Equipo: " + getNombre());
            for(int i = 0; i < tamano; i++)
                listBox.Items.Add(integrantes[i]);
        }
    }
}
