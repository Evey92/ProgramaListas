using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace ProgramaListas
{
    class Equipo
    {
        int num = 0;
        public List<string> integrantes = new List<string>();
        //public string[] integrantes = new string[3];

       /* public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }*/
        public int getNum()
        {
            num++;
            return this.num;   
        }

        public void mostrarIntegrantes(ListBox listBox, int tamano)
        {
            listBox.Items.Add("Equipo: " + getNum());
            for(int i = 0; i < tamano; i++)
            listBox.Items.Add(integrantes[i]);
        }
    }
}
