using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParcial2OctavioGonzalez
{
    internal class Alumnos
    {
        protected List<(string Nombre, int edad, int Legajo, int DNI, string Correo)> com1 = new List<(string, int, int, int, string)>();
        protected List<(string Nombre, int edad, int Legajo, int DNI, string Correo)> com2 = new List<(string, int, int, int, string)>();
        protected List<(string Nombre, int edad, int Legajo, int DNI, string Correo)> com3 = new List<(string, int, int, int, string)>();
        protected List<(string Nombre, int edad, int Legajo, int DNI, string Correo)> com4 = new List<(string, int, int, int, string)>();
        protected List<(string Nombre, int edad, int Legajo, int DNI, string Correo)> com5 = new List<(string, int, int, int, string)>();
        protected List<(string Nombre, int edad, int Legajo, int DNI, string Correo)> com6 = new List<(string, int, int, int, string)>();
        protected List<(string Nombre, int edad, int Legajo, int DNI, string Correo)> com7 = new List<(string, int, int, int, string)>();
        protected List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica, int asistencia)> comision1 = new List<(double, double, double, double, double, int)>();
        protected List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica, int asistencia)> comision2 = new List<(double, double, double, double, double, int)>();
        protected List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica, int asistencia)> comision3 = new List<(double, double, double, double, double, int)>();
        protected List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica, int asistencia)> comision4 = new List<(double, double, double, double, double, int)>();
        protected List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica, int asistencia)> comision5 = new List<(double, double, double, double, double, int)>();
        protected List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica, int asistencia)> comision6 = new List<(double, double, double, double, double, int)>();
        protected List<(double Lengua, double Ingles, double Matematica, double Economia, double Politica, int asistencia)> comision7 = new List<(double, double, double, double, double, int)>();
        protected List<(string codigo, string campo)> columnaalumno = new List<(string, string)>();
        public virtual int edad { get; set; }
        
        public Alumnos()
        {
            Alu();
        }
        public void añadir(List<(int comision, string nombre, int edad, int legajo, int DNI, string correo)> devolver)
        {
            switch (devolver[0].comision)
            {
                case 1:
                    com1.Add((devolver[0].nombre, devolver[0].edad, devolver[0].legajo, devolver[0].DNI, devolver[0].correo));
                    break;                       
                case 2:                           
                    com2.Add((devolver[0].nombre, devolver[0].edad, devolver[0].legajo, devolver[0].DNI, devolver[0].correo));
                    break;                        
                case 3:                           
                    com3.Add((devolver[0].nombre, devolver[0].edad, devolver[0].legajo, devolver[0].DNI, devolver[0].correo));
                    break;                        
                case 4:                           
                    com4.Add((devolver[0].nombre, devolver[0].edad, devolver[0].legajo, devolver[0].DNI, devolver[0].correo));
                    break;                        
                case 5:                           
                    com5.Add((devolver[0].nombre, devolver[0].edad, devolver[0].legajo, devolver[0].DNI, devolver[0].correo));
                    break;                         
                case 6:                           
                    com6.Add((devolver[0].nombre, devolver[0].edad, devolver[0].legajo, devolver[0].DNI, devolver[0].correo));
                    break;                       
                case 7:                            
                    com7.Add((devolver[0].nombre, devolver[0].edad, devolver[0].legajo, devolver[0].DNI, devolver[0].correo));
                    break;
                default:
                    break;
            }
           
        }
        protected virtual void Alu ()
        {
            // Comisión 1
            com1.Add(("Juan Pérez", 25, 12345, 40123456, "juanperez@mail.com"));
            
          
            com1.Add(("María López", 19, 23456, 38987654, "marialopez@mail.com"));
            com1.Add(("Pedro Gómez", 30, 34567, 42765432, "pedrogomez@mail.com"));
            com1.Add(("Ana Torres", 21, 45678, 37891234, "anatorres@mail.com"));
            com1.Add(("Lucas Díaz", 27, 56789, 39876543, "lucasdiaz@mail.com"));
            com1.Add(("Carla Méndez", 24, 67890, 41239876, "carlamendez@mail.com"));
            com1.Add(("Mateo Ruiz", 18, 11223, 37981234, "mateoruiz@mail.com"));
            com1.Add(("Julieta Paz", 29, 22334, 42659873, "julietapaz@mail.com"));
            com1.Add(("Sofía Ríos", 26, 33445, 39458712, "sofiarios@mail.com"));
            com1.Add(("Martín Silva", 23, 44556, 40876521, "martinsilva@mail.com"));
            com1.Add(("Camila Vega", 20, 55667, 38765419, "camilavega@mail.com"));
            com1.Add(("Diego Castro", 28, 66778, 41329876, "diegocastro@mail.com"));
            com1.Add(("Valentina Gil", 19, 77889, 40198576, "valentinagil@mail.com"));
            com1.Add(("Nicolás Soto", 25, 88990, 38965234, "nicolassoto@mail.com"));
            com1.Add(("Florencia Arias", 22, 99001, 42761234, "florenciaarias@mail.com"));
            com1.Add(("Ezequiel Ramos", 30, 10112, 39874561, "ezequielramos@mail.com"));
            com1.Add(("Agustina Peña", 21, 11223, 37892145, "agustinapena@mail.com"));
            com1.Add(("Franco Molina", 27, 12334, 40981234, "francomolina@mail.com"));
            com1.Add(("Micaela Ortiz", 24, 13445, 38659871, "micaelaortiz@mail.com"));
            com1.Add(("Joaquín Herrera", 18, 14556, 40213456, "joaquinherrera@mail.com"));
            com1.Add(("Paula Roldán", 29, 15667, 38976542, "paularoldan@mail.com"));
            com1.Add(("Rodrigo Funes", 26, 16778, 41785632, "rodrigofunes@mail.com"));
            com1.Add(("Bianca Luna", 23, 17889, 39567412, "biancaluna@mail.com"));
            com1.Add(("Emiliano Cruz", 20, 18990, 42876541, "emilianocruz@mail.com"));
            com1.Add(("Lucía Campos", 28, 19001, 39981234, "luciacampos@mail.com"));
            com1.Add(("Federico Vela", 19, 20112, 37765489, "federicovela@mail.com"));
            com1.Add(("Agustín Bravo", 25, 21223, 40893214, "agustinbravo@mail.com"));
            com1.Add(("Brenda Ochoa", 22, 22334, 39287456, "brendaochoa@mail.com"));
            com1.Add(("Tomás Paredes", 30, 23445, 41827654, "tomasparedes@mail.com"));
            com1.Add(("Daiana Medina", 21, 24556, 39674512, "daianamedina@mail.com"));

            // Comisión 2
            com2.Add(("Santiago Morales", 26, 30001, 43012345, "santiagomorales@mail.com"));
            com2.Add(("Clara Fernández", 23, 31112, 41876543, "clarafernandez@mail.com"));
            com2.Add(("Matías Acosta", 20, 32223, 39765432, "matiasacosta@mail.com"));
            com2.Add(("Emma Sánchez", 28, 33334, 42598761, "emmasanchez@mail.com"));
            com2.Add(("Benjamín Ortiz", 19, 34445, 40321654, "benjaminortiz@mail.com"));
            com2.Add(("Victoria Pérez", 25, 35556, 38965412, "victoriaperez@mail.com"));
            com2.Add(("Gabriel López", 22, 36667, 41654321, "gabriellopez@mail.com"));
            com2.Add(("Isabella Gómez", 30, 37778, 39432156, "isabellagomez@mail.com"));
            com2.Add(("Sebastián Torres", 21, 38889, 42987654, "sebastiantorres@mail.com"));
            com2.Add(("Valeria Díaz", 27, 39990, 40712345, "valeriadiaz@mail.com"));
            com2.Add(("Julián Méndez", 24, 40112, 39543218, "julianmendez@mail.com"));
            com2.Add(("Catalina Ruiz", 18, 41223, 42865432, "catalinaruiz@mail.com"));
            com2.Add(("Thiago Paz", 29, 42334, 40698765, "thiagopaz@mail.com"));
            com2.Add(("Renata Ríos", 26, 43445, 39487612, "renatarios@mail.com"));
            com2.Add(("Facundo Silva", 23, 44556, 41987654, "facundosilva@mail.com"));
            com2.Add(("Candela Vega", 20, 45667, 39754321, "candelavega@mail.com"));
            com2.Add(("Lautaro Castro", 28, 46778, 42654321, "lautarocastro@mail.com"));
            com2.Add(("Abril Gil", 19, 47889, 40498765, "abrilgil@mail.com"));
            com2.Add(("Ignacio Soto", 25, 48990, 39265431, "ignaciosoto@mail.com"));
            com2.Add(("Delfina Arias", 22, 49112, 42712345, "delfinaarias@mail.com"));
            com2.Add(("Bautista Ramos", 30, 50223, 40543218, "bautistaramos@mail.com"));
            com2.Add(("Pilar Peña", 21, 51334, 39387654, "pilarpena@mail.com"));
            com2.Add(("Simón Molina", 27, 52445, 41854321, "simonmolina@mail.com"));
            com2.Add(("Martina Ortiz", 24, 53556, 39698765, "martinaortiz@mail.com"));
            com2.Add(("Leandro Herrera", 18, 54667, 42432156, "leandroherrera@mail.com"));
            com2.Add(("Milagros Roldán", 29, 55778, 40265487, "milagrosroldan@mail.com"));
            com2.Add(("Felipe Funes", 26, 56889, 42987612, "felipefunes@mail.com"));
            com2.Add(("Celeste Luna", 23, 57990, 40754321, "celesteluna@mail.com"));
            com2.Add(("Jeremías Cruz", 20, 58112, 39598764, "jeremiascruz@mail.com"));
            com2.Add(("Amalia Campos", 28, 59223, 42612345, "amaliacampos@mail.com"));

            // Comisión 3
            com3.Add(("Luciano Vela", 19, 60001, 43123456, "lucianovela@mail.com"));
            com3.Add(("Alma Bravo", 25, 61112, 41987654, "almabravo@mail.com"));
            com3.Add(("Elías Ochoa", 22, 62223, 39876543, "eliasochoa@mail.com"));
            com3.Add(("Mía Paredes", 30, 63334, 42698765, "miaparedes@mail.com"));
            com3.Add(("Jazmín Medina", 21, 64445, 40432156, "jazminmedina@mail.com"));
            com3.Add(("Santino Morales", 27, 65556, 39065432, "santinomorales@mail.com"));
            com3.Add(("Lola Fernández", 24, 66667, 41754321, "lolafernandez@mail.com"));
            com3.Add(("Valentino Acosta", 18, 67778, 39543218, "valentinoacosta@mail.com"));
            com3.Add(("Malena Sánchez", 29, 68889, 43087654, "malenasanchez@mail.com"));
            com3.Add(("Dante Ortiz", 26, 69990, 40812345, "danteortiz@mail.com"));
            com3.Add(("Clara Pérez", 23, 70112, 39643218, "claraperez@mail.com"));
            com3.Add(("Bruno López", 20, 71223, 42965432, "brunolopez@mail.com"));
            com3.Add(("Emilia Gómez", 28, 72334, 40798765, "emiliagomez@mail.com"));
            com3.Add(("Mateo Torres", 19, 73445, 39587612, "mateotorres@mail.com"));
            com3.Add(("Juana Díaz", 25, 74556, 42087654, "juanadiaz@mail.com"));
            com3.Add(("Tomás Méndez", 22, 75667, 39854321, "tomasmendez@mail.com"));
            com3.Add(("Sol Ruiz", 30, 76778, 42754321, "solruiz@mail.com"));
            com3.Add(("Benicio Paz", 21, 77889, 40598765, "beniciopaz@mail.com"));
            com3.Add(("Azul Ríos", 27, 78990, 39365431, "azulrios@mail.com"));
            com3.Add(("Santino Silva", 24, 79112, 42812345, "santinosilva@mail.com"));
            com3.Add(("Vera Vega", 18, 80223, 40643218, "veravega@mail.com"));
            com3.Add(("Máximo Castro", 29, 81334, 39487654, "maximocastro@mail.com"));
            com3.Add(("Alina Gil", 26, 82445, 41954321, "alinagil@mail.com"));
            com3.Add(("Bautista Soto", 23, 83556, 39798765, "bautistasoto@mail.com"));
            com3.Add(("Ciro Arias", 20, 84667, 42532156, "ciroarias@mail.com"));


            // Comisión 4
            com4.Add(("Renzo Roldán", 21, 90001, 43234567, "renzoroldan@mail.com"));
            com4.Add(("Elena Funes", 27, 91112, 42098765, "elenafunes@mail.com"));
            com4.Add(("Thiago Luna", 24, 92223, 39987654, "thiagoluna@mail.com"));
            com4.Add(("Irina Cruz", 18, 93334, 42798765, "irinacruz@mail.com"));
            com4.Add(("Felipe Campos", 29, 94445, 40532156, "felipecampos@mail.com"));
            com4.Add(("Lila Vela", 26, 95556, 39165432, "lilavela@mail.com"));
            com4.Add(("Ezequiel Bravo", 23, 96667, 41854321, "ezequielbravo@mail.com"));
            com4.Add(("Violeta Ochoa", 20, 97778, 39643218, "violetaochoa@mail.com"));
            com4.Add(("Julián Paredes", 28, 98889, 43187654, "julianparedes@mail.com"));
            com4.Add(("Zoe Medina", 19, 99990, 40912345, "zoemedina@mail.com"));
            com4.Add(("Santino Morales", 25, 100112, 39743218, "santinomorales2@mail.com"));
            com4.Add(("Clara Fernández", 22, 101223, 43065432, "clarafernandez2@mail.com"));
            com4.Add(("Matías Acosta", 30, 102334, 40898765, "matiasacosta2@mail.com"));
            com4.Add(("Emma Sánchez", 21, 103445, 39687612, "emmasanchez2@mail.com"));
            com4.Add(("Benjamín Ortiz", 27, 104556, 42187654, "benjaminortiz2@mail.com"));
            com4.Add(("Victoria Pérez", 24, 105667, 39954321, "victoriaperez2@mail.com"));
            com4.Add(("Gabriel López", 18, 106778, 42854321, "gabriellopez2@mail.com"));
            com4.Add(("Isabella Gómez", 29, 107889, 40698765, "isabellagomez2@mail.com"));
            com4.Add(("Sebastián Torres", 26, 108990, 39465431, "sebastiantorres2@mail.com"));
            com4.Add(("Valeria Díaz", 23, 110112, 42912345, "valeriadiaz2@mail.com"));
            com4.Add(("Julián Méndez", 20, 111223, 40743218, "julianmendez2@mail.com"));
            com4.Add(("Catalina Ruiz", 28, 112334, 39587654, "catalinaruiz2@mail.com"));
            com4.Add(("Thiago Paz", 19, 113445, 42054321, "thiagopaz2@mail.com"));
           

            // Comisión 5
            com5.Add(("Bautista Ramos", 29, 130001, 43345678, "bautistaramos2@mail.com"));
            com5.Add(("Pilar Peña", 26, 131112, 42198765, "pilarpena2@mail.com"));
            com5.Add(("Simón Molina", 23, 132223, 40087654, "simonmolina2@mail.com"));
            com5.Add(("Martina Ortiz", 20, 133334, 42898765, "martinaortiz2@mail.com"));
            com5.Add(("Leandro Herrera", 28, 134445, 40632156, "leandroherrera2@mail.com"));
            com5.Add(("Milagros Roldán", 19, 135556, 39265432, "milagrosroldan2@mail.com"));
            com5.Add(("Felipe Funes", 25, 136667, 41954321, "felipefunes2@mail.com"));
            com5.Add(("Celeste Luna", 22, 137778, 39743218, "celesteluna2@mail.com"));
            com5.Add(("Jeremías Cruz", 30, 138889, 43287654, "jeremiascruz2@mail.com"));
            com5.Add(("Amalia Campos", 21, 139990, 41012345, "amaliacampos2@mail.com"));
            com5.Add(("Luciano Vela", 27, 140112, 39843218, "lucianovela2@mail.com"));
            com5.Add(("Alma Bravo", 24, 141223, 43165432, "almabravo2@mail.com"));
            com5.Add(("Elías Ochoa", 18, 142334, 40998765, "eliasochoa2@mail.com"));
            com5.Add(("Mía Paredes", 29, 143445, 39787612, "miaparedes2@mail.com"));
            com5.Add(("Jazmín Medina", 26, 144556, 42287654, "jazminmedina2@mail.com"));
            com5.Add(("Santino Morales", 23, 145667, 40054321, "santinomorales3@mail.com"));
            com5.Add(("Lola Fernández", 20, 146778, 42954321, "lolafernandez2@mail.com"));
            com5.Add(("Valentino Acosta", 28, 147889, 40798765, "valentinoacosta2@mail.com"));
            com5.Add(("Malena Sánchez", 19, 148990, 39565431, "malenasanchez2@mail.com"));
            com5.Add(("Dante Ortiz", 25, 150112, 43012345, "danteortiz2@mail.com"));
            com5.Add(("Clara Pérez", 22, 151223, 40843218, "claraperez2@mail.com"));
            com5.Add(("Bruno López", 30, 152334, 39687654, "brunolopez2@mail.com"));
            com5.Add(("Emilia Gómez", 21, 153445, 42154321, "emiliagomez2@mail.com"));
            com5.Add(("Mateo Torres", 27, 154556, 39998765, "mateotorres2@mail.com"));
            com5.Add(("Juana Díaz", 24, 155667, 42732156, "juanadiaz2@mail.com"));
            com5.Add(("Tomás Méndez", 18, 156778, 40565487, "tomasmendez2@mail.com"));
            com5.Add(("Sol Ruiz", 29, 157889, 43287612, "solruiz2@mail.com"));
       

            // Comisión 6
            com6.Add(("Vera Vega", 28, 170001, 43456789, "veravega2@mail.com"));
            com6.Add(("Máximo Castro", 19, 171112, 42298765, "maximocastro2@mail.com"));
            com6.Add(("Alina Gil", 25, 172223, 40187654, "alinagil2@mail.com"));
            com6.Add(("Bautista Soto", 22, 173334, 42998765, "bautistasoto2@mail.com"));
            com6.Add(("Ciro Arias", 30, 174445, 40732156, "ciroarias2@mail.com"));
            com6.Add(("Ambar Ramos", 21, 175556, 39365432, "ambarramos2@mail.com"));
            com6.Add(("Ulises Peña", 27, 176667, 42054321, "ulisespena2@mail.com"));
            com6.Add(("Maia Molina", 24, 177778, 39843218, "maiamolina2@mail.com"));
            com6.Add(("Damián Ortiz", 18, 178889, 43387654, "damianortiz2@mail.com"));
            com6.Add(("Luz Herrera", 29, 179990, 41112345, "luzherrera2@mail.com"));
            com6.Add(("Renzo Roldán", 26, 180112, 39943218, "renzoroldan2@mail.com"));
            com6.Add(("Elena Funes", 23, 181223, 43265432, "elenafunes2@mail.com"));
            com6.Add(("Thiago Luna", 20, 182334, 41098765, "thiagoluna2@mail.com"));
            com6.Add(("Irina Cruz", 28, 183445, 39887612, "irinacruz2@mail.com"));
            com6.Add(("Felipe Campos", 19, 184556, 42387654, "felipecampos2@mail.com"));
            com6.Add(("Lila Vela", 25, 185667, 40154321, "lilavela2@mail.com"));
            com6.Add(("Ezequiel Bravo", 22, 186778, 43054321, "ezequielbravo2@mail.com"));
            com6.Add(("Violeta Ochoa", 30, 187889, 40898765, "violetaochoa2@mail.com"));
            com6.Add(("Julián Paredes", 21, 188990, 39665431, "julianparedes2@mail.com"));
            com6.Add(("Zoe Medina", 27, 190112, 43112345, "zoemedina2@mail.com"));
            com6.Add(("Santino Morales", 24, 191223, 40943218, "santinomorales4@mail.com"));
            com6.Add(("Clara Fernández", 18, 192334, 39787654, "clarafernandez3@mail.com"));
            com6.Add(("Matías Acosta", 29, 193445, 42254321, "matiasacosta3@mail.com"));
            com6.Add(("Emma Sánchez", 26, 194556, 40098765, "emmasanchez3@mail.com"));
            com6.Add(("Benjamín Ortiz", 23, 195667, 42832156, "benjaminortiz3@mail.com"));
            com6.Add(("Victoria Pérez", 20, 196778, 40665487, "victoriaperez3@mail.com"));
            com6.Add(("Gabriel López", 28, 197889, 43387612, "gabriellopez3@mail.com"));
            com6.Add(("Isabella Gómez", 19, 198990, 41154321, "isabellagomez3@mail.com"));
 

            // Comisión 7
            com7.Add(("Julián Méndez", 30, 210001, 43567890, "julianmendez3@mail.com"));
            com7.Add(("Catalina Ruiz", 21, 211112, 42398765, "catalinaruiz3@mail.com"));
            com7.Add(("Thiago Paz", 27, 212223, 40287654, "thiagopaz3@mail.com"));
            com7.Add(("Renata Ríos", 24, 213334, 43098765, "renatarios3@mail.com"));
            com7.Add(("Facundo Silva", 18, 214445, 40832156, "facundosilva3@mail.com"));
            com7.Add(("Candela Vega", 29, 215556, 39465432, "candelavega3@mail.com"));
            com7.Add(("Lautaro Castro", 26, 216667, 42154321, "lautarocastro3@mail.com"));
            com7.Add(("Abril Gil", 23, 217778, 39943218, "abrilgil3@mail.com"));
            com7.Add(("Ignacio Soto", 20, 218889, 43487654, "ignaciosoto3@mail.com"));
            com7.Add(("Delfina Arias", 28, 219990, 41212345, "delfinaarias3@mail.com"));
            com7.Add(("Bautista Ramos", 19, 220112, 40043218, "bautistaramos3@mail.com"));
            com7.Add(("Pilar Peña", 25, 221223, 43365432, "pilarpena3@mail.com"));
            com7.Add(("Simón Molina", 22, 222334, 41198765, "simonmolina3@mail.com"));
            com7.Add(("Martina Ortiz", 30, 223445, 39987612, "martinaortiz3@mail.com"));
            com7.Add(("Leandro Herrera", 21, 224556, 42487654, "leandroherrera3@mail.com"));
            com7.Add(("Milagros Roldán", 27, 225667, 40254321, "milagrosroldan3@mail.com"));
            com7.Add(("Felipe Funes", 24, 226778, 43154321, "felipefunes3@mail.com"));
            com7.Add(("Celeste Luna", 18, 227889, 40998765, "celesteluna3@mail.com"));
            com7.Add(("Jeremías Cruz", 29, 228990, 39765431, "jeremiascruz3@mail.com"));
            com7.Add(("Amalia Campos", 26, 230112, 43212345, "amaliacampos3@mail.com"));
            com7.Add(("Luciano Vela", 23, 231223, 41043218, "lucianovela3@mail.com"));
            com7.Add(("Alma Bravo", 20, 232334, 39887654, "almabravo3@mail.com"));
            com7.Add(("Elías Ochoa", 28, 233445, 42354321, "eliasochoa3@mail.com"));
            com7.Add(("Mía Paredes", 19, 234556, 40198765, "miaparedes3@mail.com"));
            com7.Add(("Jazmín Medina", 25, 235667, 42932156, "jazminmedina3@mail.com"));

            columnaalumno.Add(("Nombre", "Nombre"));
            columnaalumno.Add(("Edad", "Edad"));
            columnaalumno.Add(("Legajo", "Legajo"));
            columnaalumno.Add(("DNI", "DNI"));
            columnaalumno.Add(("Correo", "Correo"));
        } 
        public List<(string Nombre, int edad, int Legajo, int DNI, string Correo)> Obcomision(int nrocomision)
        {
            switch (nrocomision)
            {
                case 1:
                    return com1;
                case 2:
                    return com2;
                case 3:
                    return com3;
                case 4:
                    return com4;
                case 5:
                    return com5;
                case 6:
                    return com6;
                case 7:
                    return com7;
                default: return null;
            }
      
        }
        public List<(string codigo, string campo)> Ob8()
        {
            return columnaalumno;
        }

 
    }
}