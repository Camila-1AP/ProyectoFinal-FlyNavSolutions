using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Drawing;



namespace FlyNavSolutions.Tour
{
    public class TourInfo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Destino { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Precio { get; set; }
        public decimal ITBIS => Precio * 0.18m;
        public TimeSpan Duracion { get; set; }
       

        public string Estado => (FechaHora + Duracion) >= DateTime.Now ? "Vigente" : "Vencido";
      

  
        public string RolOrigen { get; set; }

        // ADICIONALES
        public string Telefono { get; set; }
        public string Cedula { get; set; }
// ---------------------------------------------
        public int CupoMaximo { get; set; }
        public int CupoActual { get; set; }
        public TipoTour Tipo { get; set; }

       
  


    }


    public static class GestorDeTours
    {
        
    }
    public enum TipoTour
    {
        Nacional,
        Internacional
    }

    public class RegistroDeTour
    {

       

       
    }



    public static class TourRepositorio
    {
        public static List<TourInfo> Tours { get; } = new List<TourInfo>();


        
    }
    public static class CatalogoDestinos
    {
        public static Dictionary<string, List<string>> DestinosPorPais { get; } = new Dictionary<string, List<string>>();
        public static Dictionary<string, decimal> PreciosPorDestino { get; } = new Dictionary<string, decimal>();
        public static Dictionary<string, TimeSpan> DuracionesPorDestino { get; } = new Dictionary<string, TimeSpan>();
        public static Dictionary<string, decimal> PreciosPorDestinoNacional { get; } = new Dictionary<string, decimal>();

        public static Dictionary<string, TimeSpan> DuracionesPorDestinoNacional { get; } = new Dictionary<string, TimeSpan>();


        // Nacionales
        public static List<string> destinosRD = new List<string>
        {
            "Samaná", "Santiago", "Puerto Plata", "La Romana", "Punta Cana"
        };
        
        public static decimal ObtenerPrecio(string destino)
        {
            if (PreciosPorDestino.ContainsKey(destino))
                return PreciosPorDestino[destino];
            else
                return 0m;
        }

        public static TimeSpan ObtenerDuracion(string destino)
        {
            if (DuracionesPorDestino.ContainsKey(destino))
                return DuracionesPorDestino[destino];
            else
                return TimeSpan.Zero;

        }

        public static decimal ObtenerPreciosNacional(string destino)
        {
            if (PreciosPorDestinoNacional.ContainsKey(destino))
                return PreciosPorDestinoNacional[destino];
            else
                return 0m;
        }
        public static TimeSpan ObtenerDuracionNacional(string destino)
        {
            if (DuracionesPorDestinoNacional.ContainsKey(destino))
                return DuracionesPorDestinoNacional[destino];
            else
                return TimeSpan.Zero;

        }



        public static void Inicializar()
        {
            DestinosPorPais.Add("Reino Unido", new List<string> { "Londres" });
            DestinosPorPais.Add("España", new List<string> { "Madrid", "Barcelona", "Sevilla" });
            DestinosPorPais.Add("Francia", new List<string> { "París", "Marsella", "Burdeos" });

            PreciosPorDestino.Add("Londres", 8500m);
            PreciosPorDestino.Add("Madrid", 15000m);
            PreciosPorDestino.Add("Barcelona", 14500m);
            PreciosPorDestino.Add("Sevilla", 13800m);
            PreciosPorDestino.Add("París", 9500m);
            PreciosPorDestino.Add("Marsella", 8700m);
            PreciosPorDestino.Add("Burdeos", 8900m);

            DuracionesPorDestino.Add("Londres", new TimeSpan(2, 6, 0, 0));
            DuracionesPorDestino.Add("Madrid", new TimeSpan(3, 0, 0, 0));
            DuracionesPorDestino.Add("Barcelona", new TimeSpan(2, 18, 0, 0));
            DuracionesPorDestino.Add("Sevilla", new TimeSpan(2, 12, 0, 0));
            DuracionesPorDestino.Add("París", new TimeSpan(2, 0, 0, 0));
            DuracionesPorDestino.Add("Marsella", new TimeSpan(1, 18, 0, 0));
            DuracionesPorDestino.Add("Burdeos", new TimeSpan(1, 20, 0, 0));


            // Inicializar destinos nacionales
            PreciosPorDestinoNacional.Add("Samaná", 12000m);
            PreciosPorDestinoNacional.Add("Punta Cana", 13000m);
            PreciosPorDestinoNacional.Add("Santiago", 11000m);
            PreciosPorDestinoNacional.Add("Puerto Plata", 11500m);
            PreciosPorDestinoNacional.Add("La Romana", 12500m);

            DuracionesPorDestinoNacional.Add("Santiago", new TimeSpan(1, 6, 0, 0));
            DuracionesPorDestinoNacional.Add("Puerto Plata", new TimeSpan(1, 18, 0, 0));
            DuracionesPorDestinoNacional.Add("La Romana", new TimeSpan(1, 12, 0, 0));
            DuracionesPorDestinoNacional.Add("Samaná", new TimeSpan(1, 12, 0, 0));
            DuracionesPorDestinoNacional.Add("Punta Cana", new TimeSpan(1, 18, 0, 0));

            

        }

        public static void CargarPaises(System.Windows.Forms.ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (var pais in DestinosPorPais.Keys)
            {
                cmb.Items.Add(pais);
            }
        }

        public static void CargarDestinos(System.Windows.Forms.ComboBox cmb, string pais)
        {
            cmb.Items.Clear();
            if (DestinosPorPais.ContainsKey(pais))
            {
                foreach (var destino in DestinosPorPais[pais])
                {
                    cmb.Items.Add(destino);
                }
            }
        }
        public static void CargarDestinosNacionales(System.Windows.Forms.ComboBox cmb)
        {
            cmb.Items.Clear();

            foreach (var destino in destinosRD)
            {
                cmb.Items.Add(destino);
            }

           
        }
        public static void Secuencialidad()
        {
            if (!File.Exists("id-secuencial.json"))
            {
                var objeto = new Dictionary<string, int> { { "ultimoId", 0 } };
                var json = JsonSerializer.Serialize(objeto, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("id-secuencial.json", json);
            }
        }
    }
    public class IdGeneradorSecuencial
    {
        private const string RutaJson = "id-secuencial.json";
        private const string Prefijo = "T";

        public static string GenerarNuevoId()
        {
            int ultimoId = LeerUltimoId();
            int nuevoId = ultimoId + 1;

            GuardarUltimoId(nuevoId);
            return $"{Prefijo}{nuevoId:D5}";  
        }

        private static int LeerUltimoId()
        {
            if (!File.Exists(RutaJson))
                return 0;

            var json = File.ReadAllText(RutaJson);
            var objeto = JsonSerializer.Deserialize<Dictionary<string, int>>(json);
            return objeto.ContainsKey("ultimoId") ? objeto["ultimoId"] : 0;
        }

        private static void GuardarUltimoId(int id)
        {
            var objeto = new Dictionary<string, int> { { "ultimoId", id } };
            var json = JsonSerializer.Serialize(objeto, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(RutaJson, json);
        }
    }

    public static class ConstructorDeTours
    {
        
        public static TourInfo CrearTourInternacional(
        string nombre,
        string pais,
        string telefono,
        string cedula,
        string destino,
        DateTime fecha,
        TimeSpan hora,
        string rolOrigen
        )
        {
           
            DateTime fechaHora = fecha + hora;

            decimal precio = CatalogoDestinos.PreciosPorDestino.ContainsKey(destino)
                             ? CatalogoDestinos.PreciosPorDestino[destino]
                             : 0;

            TimeSpan duracion = CatalogoDestinos.DuracionesPorDestino.ContainsKey(destino)
                                ? CatalogoDestinos.DuracionesPorDestino[destino]
                                : TimeSpan.Zero;

            return new TourInfo
            {
               
                Id = IdGeneradorSecuencial.GenerarNuevoId(),
                Nombre = nombre,
                Pais = pais,
                Telefono = telefono,
                Cedula = cedula,
                Destino = destino,
                FechaHora = fechaHora,
               
               
                Precio = precio,
                Duracion = duracion, 
                RolOrigen = rolOrigen,
                Tipo = TipoTour.Internacional

            };
        }

        public static TourInfo CrearTourNacional(
            string nombre,
            string destino,
            string telefono,
            string cedula,
            DateTime fecha,
            TimeSpan hora,
            string rolOrigen
            )
        {
            DateTime fechaHora = fecha + hora;

            decimal precio = CatalogoDestinos.PreciosPorDestinoNacional.ContainsKey(destino)
                             ? CatalogoDestinos.PreciosPorDestinoNacional[destino]
                             : 0;

            TimeSpan duracion = CatalogoDestinos.DuracionesPorDestinoNacional.ContainsKey(destino)
                                ? CatalogoDestinos.DuracionesPorDestinoNacional[destino]
                                : TimeSpan.Zero;

            return new TourInfo
            {
                
                Id = IdGeneradorSecuencial.GenerarNuevoId(), 
                Nombre = nombre,
                Pais = null, // Nacional, no requiere país
                Destino = destino,
                Telefono = telefono,
                Cedula = cedula,
                FechaHora = fechaHora,
              
             
                Precio = precio,
                Duracion = duracion,
                RolOrigen = rolOrigen,
                Tipo = TipoTour.Nacional

            };
        }
    }

    public static class TourValidador
    {
        


        private const int MaximoPorCombinacion = 20;
        private const int MinutosPorBloque = 30;

        private static DateTime ObtenerInicioBloque(DateTime fecha)
        {
            int minutos = fecha.Minute < MinutosPorBloque ? 0 : MinutosPorBloque;
            return new DateTime(fecha.Year, fecha.Month, fecha.Day, fecha.Hour, minutos, 0);
        }

        public static bool PuedeCrearNuevoTour(DateTime fechaHora, string destino, TipoTour tipo, string pais )
        {





            DateTime inicioBloque = ObtenerInicioBloque(fechaHora);

            int cantidadExistente = TourRepositorio.Tours.Count(t =>
            {
                DateTime bloqueTour = ObtenerInicioBloque(t.FechaHora);
                return bloqueTour == inicioBloque &&
                       t.Destino == destino &&
                       t.Tipo == tipo &&
                       t.Pais == pais;
            });

            return cantidadExistente < MaximoPorCombinacion;



        }

        public static int ObtenerCupoRestante(DateTime fechaHora, string destino, string rolOrigen, TipoTour tipo, string pais)
        {
           


            DateTime inicioBloque = ObtenerInicioBloque(fechaHora);

            int cantidadExistente = TourRepositorio.Tours.Count(t =>
            {
                DateTime bloqueTour = ObtenerInicioBloque(t.FechaHora);
                return bloqueTour == inicioBloque &&
                       t.Destino == destino &&
                       t.Tipo == tipo &&
                       t.Pais == pais &&
                       t.RolOrigen == rolOrigen;
            });

            return MaximoPorCombinacion - cantidadExistente;
        }
    }




    public static class PersistenciaLocal
    {
        private static readonly string rutaArchivo = System.IO.Path.Combine(Application.StartupPath, "tours.json");

        public static void Guardar()
        {
            var json = JsonSerializer.Serialize(TourRepositorio.Tours);
            File.WriteAllText(rutaArchivo, json);
  

        }

        public static void Cargar()
        {
            if (!File.Exists(rutaArchivo)) return;

            var json = File.ReadAllText(rutaArchivo);
            var datos = JsonSerializer.Deserialize<List<TourInfo>>(json);

            if (datos != null)
            {
                TourRepositorio.Tours.Clear();
                TourRepositorio.Tours.AddRange(datos);
            }
        }
    }
    public static class PreparadorEntrega
    {
        public static void ResetearDatos()
        {
            
            TourRepositorio.Tours.Clear();

           
            File.WriteAllText("tours.json", "[]");

            // Reiniciar el ID secuencial
            var objetoId = new Dictionary<string, int> { { "ultimoId", 0 } };
            var jsonId = JsonSerializer.Serialize(objetoId, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("id-secuencial.json", jsonId);
        }
    }






}
