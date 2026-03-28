using PortalCampanas.Models;

namespace PortalCampanas.Services
{
    public class CampanaService
    {
        public static List<Campana> ObtenerCampanas()
        {
            return new List<Campana>
            {
                new Campana {
                    Id = 1,
                    Nombre = "Cyber Electro",
                    Categoria = "Electro",
                    Estado = "Vigente",
                    FechaInicio = DateTime.Now.AddDays(-5),
                    FechaFin = DateTime.Now.AddDays(5),
                    DescuentoPct = 20,
                    Canal = "Web",
                    Descripcion = "Descuentos en productos electrónicos"
                },
                new Campana {
                    Id = 2,
                    Nombre = "Moda Verano",
                    Categoria = "Moda",
                    Estado = "Próxima",
                    FechaInicio = DateTime.Now.AddDays(10),
                    FechaFin = DateTime.Now.AddDays(20),
                    DescuentoPct = 30,
                    Canal = "App",
                    Descripcion = "Ofertas en ropa de verano"
                },
                new Campana {
                    Id = 3,
                    Nombre = "Hogar Feliz",
                    Categoria = "Hogar",
                    Estado = "Finalizada",
                    FechaInicio = DateTime.Now.AddDays(-20),
                    FechaFin = DateTime.Now.AddDays(-10),
                    DescuentoPct = 15,
                    Canal = "Tienda",
                    Descripcion = "Ofertas en muebles"
                }
            };
        }
    }
}