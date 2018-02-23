using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaListas
{
    class ConstructorEquipos : InputDatos
    {
        public List<Equipo> Equipos = new List<Equipo>();
        public List<string> Nombres = new List<string>();
        public Equipo tempEquipo = new Equipo();

        public ConstructorEquipos()
        {

        }

        public void leerArchivo()
        {

        }

        public void leerTextBox(string name)
        {
            Nombres.Add(name);
        }

        public void formarEquipos(int tamano, int numEquipos) // para evitar problemas con la letra ñ
        {
           
            Random r = new Random();
            int index = r.Next(Nombres.Count);

            for (int i = 0; i < numEquipos; i++)
            {
                for (int j = 0; j < tamano; j++)
                    tempEquipo.integrantes[j] = Nombres[index];


                Equipos.Add(tempEquipo);
            }
        }

        public void mostrarEquipos(ListBox listbox, int numEquipos)
        {
            for (int i = 0; i < numEquipos; i++)
                Equipos[i].mostrarIntegrantes(listbox);


        }


    }
}
