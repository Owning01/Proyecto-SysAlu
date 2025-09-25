using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace SistemaParcial2OctavioGonzalez
{
    internal class Notas
    {
        private List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica)> nota = new List<(double, double, double, double, double)>();
        private List<(string codigo, string materia)> colum= new List<(string, string)>(); //para el datagrid
        private List<(string codigo, string )> estadistica= new List<(string, string)>();   //para el datagrid
        private void notas()
        {
            nota.Add((7.5, 4.0, 6.5, 9.0, 8.5)); // Juan Pérez
            nota.Add((8.0, 7.0, 8.5, 6.5, 7.5)); // María López
            nota.Add((6.5, 9.0, 4.0, 8.0, 6.0)); // Pedro Gómez
            nota.Add((9.0, 8.5, 7.5, 6.0, 8.0)); // Ana Torres
            nota.Add((7.0, 6.5, 8.0, 5.0, 7.5)); // Lucas Díaz
            nota.Add((8.5, 7.5, 6.0, 8.0, 9.0)); // Carla Méndez
            nota.Add((6.0, 5.0, 9.0, 7.5, 6.5)); // Mateo Ruiz
            nota.Add((7.5, 6.0, 5.5, 9.0, 7.0)); // Julieta Paz
            nota.Add((8.0, 9.0, 7.0, 6.5, 8.5)); // Sofía Ríos
            nota.Add((6.5, 7.5, 4.0, 9.0, 6.0)); // Martín Silva
            nota.Add((9.0, 8.0, 6.5, 7.5, 8.0)); // Camila Vega
            nota.Add((7.5, 6.5, 2.0, 8.0, 7.0)); // Diego Castro
            nota.Add((8.0, 9.0, 5.5, 6.0, 8.5)); // Valentina Gil
            nota.Add((6.5, 7.0, 8.0, 9.0, 6.5)); // Nicolás Soto
            nota.Add((7.0, 8.5, 6.0, 7.5, 5.0)); // Florencia Arias
            nota.Add((8.5, 6.5, 9.0, 8.0, 7.5)); // Ezequiel Ramos
            nota.Add((6.0, 7.5, 8.0, 9.0, 6.5)); // Agustina Peña
            nota.Add((9.0, 8.0, 6.5, 7.0, 8.5)); // Franco Molina
            nota.Add((7.5, 9.0, 6.0, 6.5, 7.0)); // Micaela Ortiz
            nota.Add((8.0, 6.5, 2.5, 9.0, 4.0)); // Joaquín Herrera
            nota.Add((6.5, 8.0, 9.0, 7.5, 6.0)); // Paula Roldán
            nota.Add((7.0, 9.0, 6.5, 8.0, 7.5)); // Rodrigo Funes
            nota.Add((8.5, 7.0, 8.0, 6.5, 9.0)); // Bianca Luna
            nota.Add((6.0, 8.5, 7.5, 9.0, 2.5)); // Emiliano Cruz
            nota.Add((9.0, 3.5, 8.0, 7.5, 8.0)); // Lucía Campos
            nota.Add((7.5, 8.0, 6.5, 9.0, 7.0)); // Federico Vela
            nota.Add((8.0, 7.5, 5.0, 6.0, 8.5)); // Agustín Bravo
            nota.Add((6.5, 9.0, 7.0, 8.5, 6.0)); // Brenda Ochoa
            nota.Add((7.0, 6.5, 8.5, 7.5, 9.0)); // Tomás Paredes
            nota.Add((8.5, 7.0, 6.0, 9.0, 7.5)); // Daiana Medina
            estadistica.Add(("Media", "Media aritmetica (notas)"));
            estadistica.Add(("Probabilidad", "Probabilidad de aprobar"));
            estadistica.Add(("Asistencia", "Porcentaje de asistencia"));
            estadistica.Add(("Participacion", "Participacion en clases"));
            colum.Add(("Nombre", "Nombre"));
            colum.Add(("Lengua", "Lengua"));
            colum.Add(("Ingles", "Ingles"));
            colum.Add(("Matematica", "Matematica"));
            colum.Add(("Economia", "Economia"));
            colum.Add(("Politica", "Politica"));
        
        }
        public Notas()
        {
            notas();
        }

        public List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica)> N()
        {
            return nota;
        }
        public List<(string codigo, string materia)> colu ()
        {
            return colum;
        }

    }
}
