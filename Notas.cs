using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace SistemaParcial2OctavioGonzalez
{
    internal class Notas:Alumnos 
    {
        
       
        private void notas()
        {
            comision1.Add((7.5, 4.0, 6.5, 9.0, 8.5, 90)); 
            comision1.Add((8.0, 7.0, 8.5, 6.5, 7.5, 80)); 
            comision1.Add((6.5, 9.0, 4.0, 8.0, 6.0, 70)); 
            comision1.Add((9.0, 8.5, 7.5, 6.0, 8.0, 70)); 
            comision1.Add((7.0, 6.5, 8.0, 5.0, 7.5, 70)); 
            comision1.Add((8.5, 7.5, 6.0, 8.0, 9.0, 80)); 
            comision1.Add((6.0, 5.0, 9.0, 7.5, 6.5, 80)); 
            comision1.Add((7.5, 6.0, 5.5, 9.0, 7.0, 80)); 
            comision1.Add((8.0, 9.0, 7.0, 6.5, 8.5, 80)); 
            comision1.Add((6.5, 7.5, 4.0, 9.0, 6.0, 80)); 
            comision1.Add((9.0, 8.0, 6.5, 7.5, 8.0, 75)); 
            comision1.Add((7.5, 6.5, 2.0, 8.0, 7.0, 75)); 
            comision1.Add((8.0, 9.0, 5.5, 6.0, 8.5, 75)); 
            comision1.Add((6.5, 7.0, 8.0, 9.0, 6.5, 75)); 
            comision1.Add((7.0, 8.5, 6.0, 7.5, 5.0, 75)); 
            comision1.Add((8.5, 6.5, 9.0, 8.0, 7.5, 50)); 
            comision1.Add((6.0, 7.5, 8.0, 9.0, 6.5, 50)); 
            comision1.Add((9.0, 8.0, 6.5, 7.0, 8.5, 50)); 
            comision1.Add((7.5, 9.0, 6.0, 6.5, 7.0, 50)); 
            comision1.Add((8.0, 6.5, 2.5, 9.0, 4.0, 50)); 
            comision1.Add((6.5, 8.0, 9.0, 7.5, 6.0, 80)); 
            comision1.Add((7.0, 9.0, 6.5, 8.0, 7.5, 100)); 
            comision1.Add((8.5, 7.0, 8.0, 6.5, 9.0, 100)); 
            comision1.Add((6.0, 8.5, 7.5, 9.0, 2.5, 100)); 
            comision1.Add((9.0, 3.5, 8.0, 7.5, 8.0, 100)); 
            comision1.Add((7.5, 8.0, 6.5, 9.0, 7.0, 100)); 
            comision1.Add((8.0, 7.5, 5.0, 6.0, 8.5, 80)); 
            comision1.Add((6.5, 9.0, 7.0, 8.5, 6.0, 80)); 
            comision1.Add((7.0, 6.5, 8.5, 7.5, 9.0, 80)); 
            comision1.Add((8.5, 7.0, 6.0, 9.0, 7.5, 80));

            // Comisión 2 (25 alumnos)
            comision2.Add((7.5, 4.0, 6.5, 9.0, 8.5, 85));
            comision2.Add((8.0, 7.0, 3.5, 6.5, 7.5, 92));
            comision2.Add((6.5, 9.0, 4.0, 8.0, 2.5, 78));
            comision2.Add((9.0, 8.5, 7.5, 6.0, 8.0, 95));
            comision2.Add((3.0, 6.5, 8.0, 5.0, 7.5, 60));
            comision2.Add((8.5, 7.5, 6.0, 8.0, 4.5, 88));
            comision2.Add((6.0, 5.0, 9.0, 3.5, 6.5, 75));
            comision2.Add((7.5, 6.0, 5.5, 9.0, 7.0, 90));
            comision2.Add((8.0, 2.5, 7.0, 6.5, 8.5, 82));
            comision2.Add((6.5, 7.5, 4.0, 9.0, 6.0, 70));
            comision2.Add((9.0, 8.0, 6.5, 3.0, 8.0, 87));
            comision2.Add((7.5, 6.5, 2.0, 8.0, 7.0, 65));
            comision2.Add((8.0, 9.0, 5.5, 6.0, 4.5, 93));
            comision2.Add((6.5, 7.0, 8.0, 9.0, 6.5, 80));
            comision2.Add((7.0, 3.5, 6.0, 7.5, 5.0, 76));
            comision2.Add((8.5, 6.5, 9.0, 4.0, 7.5, 89));
            comision2.Add((6.0, 7.5, 3.0, 9.0, 6.5, 72));
            comision2.Add((9.0, 8.0, 6.5, 7.0, 8.5, 94));
            comision2.Add((7.5, 4.0, 6.0, 6.5, 7.0, 68));
            comision2.Add((8.0, 6.5, 2.5, 9.0, 4.0, 77));
            comision2.Add((6.5, 8.0, 9.0, 3.5, 6.0, 91));
            comision2.Add((7.0, 9.0, 6.5, 8.0, 7.5, 83));
            comision2.Add((8.5, 3.0, 8.0, 6.5, 9.0, 79));
            comision2.Add((6.0, 8.5, 7.5, 4.0, 2.5, 86));
            comision2.Add((9.0, 3.5, 8.0, 7.5, 8.0, 90));
              
            // isionComisión 3 (30 alumnos)
            comision3.Add((7.5, 8.0, 6.5, 9.0, 4.0, 88));
            comision3.Add((8.0, 3.5, 7.5, 6.0, 8.5, 92));
            comision3.Add((6.5, 9.0, 4.0, 8.0, 6.0, 75));
            comision3.Add((9.0, 8.5, 3.0, 6.5, 8.0, 90));
            comision3.Add((7.0, 6.5, 8.0, 4.5, 7.5, 80));
            comision3.Add((8.5, 7.5, 6.0, 8.0, 3.0, 85));
            comision3.Add((6.0, 5.0, 9.0, 7.5, 6.5, 70));
            comision3.Add((7.5, 6.0, 2.5, 9.0, 7.0, 93));
            comision3.Add((8.0, 9.0, 7.0, 3.5, 8.5, 78));
            comision3.Add((6.5, 7.5, 4.0, 9.0, 6.0, 87));
            comision3.Add((9.0, 8.0, 6.5, 7.5, 4.0, 82));
            comision3.Add((7.5, 6.5, 2.0, 8.0, 7.0, 76));
            comision3.Add((8.0, 9.0, 5.5, 6.0, 8.5, 91));
            comision3.Add((6.5, 3.0, 8.0, 9.0, 6.5, 69));
            comision3.Add((7.0, 8.5, 6.0, 4.5, 5.0, 94));
            comision3.Add((8.5, 6.5, 9.0, 8.0, 7.5, 81));
            comision3.Add((6.0, 7.5, 3.0, 9.0, 6.5, 88));
            comision3.Add((9.0, 8.0, 6.5, 7.0, 4.0, 90));
            comision3.Add((7.5, 4.0, 6.0, 6.5, 7.0, 73));
            comision3.Add((8.0, 6.5, 2.5, 9.0, 8.5, 85));
            comision3.Add((6.5, 8.0, 9.0, 3.5, 6.0, 92));
            comision3.Add((7.0, 9.0, 6.5, 8.0, 7.5, 79));
            comision3.Add((8.5, 3.0, 8.0, 6.5, 9.0, 86));
            comision3.Add((6.0, 8.5, 7.5, 4.0, 2.5, 90));
   

            // isionComisión 4 (22 alumnos)
            comision4.Add((7.5, 4.0, 6.5, 9.0, 8.5, 87));
            comision4.Add((8.0, 7.0, 3.5, 6.5, 7.5, 90));
            comision4.Add((6.5, 9.0, 4.0, 8.0, 2.5, 76));
            comision4.Add((9.0, 8.5, 7.5, 3.0, 8.0, 92));
            comision4.Add((3.0, 6.5, 8.0, 5.0, 7.5, 65));
            comision4.Add((8.5, 7.5, 6.0, 8.0, 4.5, 88));
            comision4.Add((6.0, 5.0, 9.0, 3.5, 6.5, 70));
            comision4.Add((7.5, 6.0, 2.5, 9.0, 7.0, 93));
            comision4.Add((8.0, 2.5, 7.0, 6.5, 8.5, 78));
            comision4.Add((6.5, 7.5, 4.0, 9.0, 6.0, 85));
            comision4.Add((9.0, 8.0, 6.5, 3.0, 8.0, 91));
            comision4.Add((7.5, 6.5, 2.0, 8.0, 7.0, 74));
            comision4.Add((8.0, 9.0, 5.5, 6.0, 4.5, 89));
            comision4.Add((6.5, 3.0, 8.0, 9.0, 6.5, 82));
            comision4.Add((7.0, 8.5, 6.0, 4.5, 5.0, 90));
            comision4.Add((8.5, 6.5, 9.0, 8.0, 7.5, 77));
            comision4.Add((6.0, 7.5, 3.0, 9.0, 6.5, 85));
            comision4.Add((9.0, 8.0, 6.5, 7.0, 4.0, 91));
            comision4.Add((7.5, 4.0, 6.0, 6.5, 7.0, 69));
            comision4.Add((8.0, 6.5, 2.5, 9.0, 8.5, 88));
            comision4.Add((6.5, 8.0, 9.0, 3.5, 6.0, 92));
            comision4.Add((7.0, 9.0, 6.5, 8.0, 7.5, 80));
              
            // isionComisión 5 (35 alumnos)
            comision5.Add((7.5, 8.0, 6.5, 3.0, 8.5, 90));
            comision5.Add((8.0, 3.5, 7.5, 6.0, 8.5, 85));
            comision5.Add((6.5, 9.0, 4.0, 8.0, 2.5, 78));
            comision5.Add((9.0, 8.5, 3.0, 6.5, 8.0, 92));
            comision5.Add((7.0, 6.5, 8.0, 4.5, 7.5, 70));
            comision5.Add((8.5, 7.5, 6.0, 8.0, 3.0, 88));
            comision5.Add((6.0, 5.0, 9.0, 3.5, 6.5, 75));
            comision5.Add((7.5, 6.0, 2.5, 9.0, 7.0, 91));
            comision5.Add((8.0, 2.5, 7.0, 6.5, 8.5, 80));
            comision5.Add((6.5, 7.5, 4.0, 9.0, 6.0, 87));
            comision5.Add((9.0, 8.0, 6.5, 3.0, 8.0, 93));
            comision5.Add((7.5, 6.5, 2.0, 8.0, 7.0, 76));
            comision5.Add((8.0, 9.0, 5.5, 6.0, 4.5, 89));
            comision5.Add((6.5, 3.0, 8.0, 9.0, 6.5, 82));
            comision5.Add((7.0, 8.5, 6.0, 4.5, 5.0, 90));
            comision5.Add((8.5, 6.5, 9.0, 8.0, 7.5, 77));
            comision5.Add((6.0, 7.5, 3.0, 9.0, 6.5, 85));
            comision5.Add((9.0, 8.0, 6.5, 7.0, 4.0, 91));
            comision5.Add((7.5, 4.0, 6.0, 6.5, 7.0, 69));
            comision5.Add((8.0, 6.5, 2.5, 9.0, 8.5, 88));
            comision5.Add((6.5, 8.0, 9.0, 3.5, 6.0, 92));
            comision5.Add((7.0, 9.0, 6.5, 8.0, 7.5, 80));
            comision5.Add((8.5, 3.0, 8.0, 6.5, 9.0, 86));
            comision5.Add((6.0, 8.5, 7.5, 4.0, 2.5, 90));
            comision5.Add((9.0, 3.5, 8.0, 7.5, 8.0, 77));
            comision5.Add((7.5, 8.0, 6.5, 9.0, 4.0, 83));

               
            // isionComisión 6 (28 alumnos)
            comision6.Add((7.5, 4.0, 6.5, 9.0, 3.0, 88));
            comision6.Add((8.0, 7.0, 3.5, 6.5, 8.5, 92));
            comision6.Add((6.5, 9.0, 4.0, 8.0, 2.5, 75));
            comision6.Add((9.0, 8.5, 3.0, 6.5, 8.0, 90));
            comision6.Add((3.0, 6.5, 8.0, 4.5, 7.5, 80));
            comision6.Add((8.5, 7.5, 6.0, 8.0, 3.0, 85));
            comision6.Add((6.0, 5.0, 9.0, 3.5, 6.5, 70));
            comision6.Add((7.5, 6.0, 2.5, 9.0, 7.0, 93));
            comision6.Add((8.0, 2.5, 7.0, 6.5, 8.5, 78));
            comision6.Add((6.5, 7.5, 4.0, 9.0, 6.0, 87));
            comision6.Add((9.0, 8.0, 6.5, 3.0, 8.0, 91));
            comision6.Add((7.5, 6.5, 2.0, 8.0, 7.0, 74));
            comision6.Add((8.0, 9.0, 5.5, 6.0, 4.5, 89));
            comision6.Add((6.5, 3.0, 8.0, 9.0, 6.5, 82));
            comision6.Add((7.0, 8.5, 6.0, 4.5, 5.0, 90));
            comision6.Add((8.5, 6.5, 9.0, 8.0, 7.5, 77));
            comision6.Add((6.0, 7.5, 3.0, 9.0, 6.5, 85));
            comision6.Add((9.0, 8.0, 6.5, 7.0, 4.0, 91));
            comision6.Add((7.5, 4.0, 6.0, 6.5, 7.0, 69));
            comision6.Add((8.0, 6.5, 2.5, 9.0, 8.5, 88));
            comision6.Add((6.5, 8.0, 9.0, 3.5, 6.0, 92));
            comision6.Add((7.0, 9.0, 6.5, 8.0, 7.5, 80));
            comision6.Add((8.5, 3.0, 8.0, 6.5, 9.0, 86));
            comision6.Add((6.0, 8.5, 7.5, 4.0, 2.5, 90));
            comision6.Add((9.0, 3.5, 8.0, 7.5, 8.0, 77));
            comision6.Add((7.5, 8.0, 6.5, 9.0, 4.0, 83));
            comision6.Add((8.0, 7.5, 3.0, 6.0, 8.5, 88));
            comision6.Add((6.5, 9.0, 7.0, 8.5, 6.0, 91));
              
            // isionComisión 7 (32 alumnos)
            comision7.Add((7.5, 8.0, 6.5, 3.0, 8.5, 90));
            comision7.Add((8.0, 3.5, 7.5, 6.0, 8.5, 85));
            comision7.Add((6.5, 9.0, 4.0, 8.0, 2.5, 78));
            comision7.Add((9.0, 8.5, 3.0, 6.5, 8.0, 92));
            comision7.Add((7.0, 6.5, 8.0, 4.5, 7.5, 70));
            comision7.Add((8.5, 7.5, 6.0, 8.0, 3.0, 88));
            comision7.Add((6.0, 5.0, 9.0, 3.5, 6.5, 75));
            comision7.Add((7.5, 6.0, 2.5, 9.0, 7.0, 91));
            comision7.Add((8.0, 2.5, 7.0, 6.5, 8.5, 80));
            comision7.Add((6.5, 7.5, 4.0, 9.0, 6.0, 87));
            comision7.Add((9.0, 8.0, 6.5, 3.0, 8.0, 93));
            comision7.Add((7.5, 6.5, 2.0, 8.0, 7.0, 76));
            comision7.Add((8.0, 9.0, 5.5, 6.0, 4.5, 89));
            comision7.Add((6.5, 3.0, 8.0, 9.0, 6.5, 82));
            comision7.Add((7.0, 8.5, 6.0, 4.5, 5.0, 90));
            comision7.Add((8.5, 6.5, 9.0, 8.0, 7.5, 77));
            comision7.Add((6.0, 7.5, 3.0, 9.0, 6.5, 85));
            comision7.Add((9.0, 8.0, 6.5, 7.0, 4.0, 91));
            comision7.Add((7.5, 4.0, 6.0, 6.5, 7.0, 69));
            comision7.Add((8.0, 6.5, 2.5, 9.0, 8.5, 88));
            comision7.Add((6.5, 8.0, 9.0, 3.5, 6.0, 92));
            comision7.Add((7.0, 9.0, 6.5, 8.0, 7.5, 80));
            comision7.Add((8.5, 3.0, 8.0, 6.5, 9.0, 86));
            comision7.Add((6.0, 8.5, 7.5, 4.0, 2.5, 90));
            comision7.Add((9.0, 3.5, 8.0, 7.5, 8.0, 77));
      

            //estadistica.Add(("Media", "Media aritmetica (notas)"));
            //estadistica.Add(("Probabilidad", "Probabilidad de aprobar"));
            //estadistica.Add(("Asistencia", "Porcentaje de asistencia"));
            //estadistica.Add(("Participacion", "Participacion en clases"));
            
        
        }
        public Notas()
        {
            notas();
        }

        public List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica, int Asistencia)> Nota(int nro)
        {
            switch (nro)
            {
                case 1:
                    return comision1;
                case 2:
                    return comision2;
                case 3:
                    return comision3;
                case 4:
                    return comision4;
                case 5:
                    return comision5;
                case 6:
                    return comision6;
                case 7:
                    return comision7;

                default:
                    return null;
            }
           
        }
        //Sobrescribo el metodo alu paraponer columnas nuevas en el datagridview para el boton notas. 
        protected override void Alu()
        {
            
            columnaalumno.Add(("Nombre", "Nombre"));
            columnaalumno.Add(("Lengua", "Lengua"));
            columnaalumno.Add(("Ingles", "Ingles"));
            columnaalumno.Add(("Matematica", "Matematica"));
            columnaalumno.Add(("Economia", "Economia"));
            columnaalumno.Add(("Politica", "Politica"));
            columnaalumno.Add(("Asistencia", "Porcentaje Asistencia"));
        }
        public List<(string codigo, string campo)> colu ()
        {
            return columnaalumno;
        }

    }
}
