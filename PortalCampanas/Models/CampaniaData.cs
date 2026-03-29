namespace PortalCampanas.Models
{
    public static class CampaniaData
    {
        public static List<Campania> ObtenerCampanias()
        {
            return new List<Campania>
            {
                new Campania
                {
                    Id = 1,
                    Nombre = "Electro Sale",
                    Categoria = "Electro",
                    Estado = "Vigente",
                    FechaInicio = DateTime.Today.AddDays(-2),
                    FechaFin = DateTime.Today.AddDays(5),
                    DescuentoPct = 20,
                    Canal = "Web",
                    Descripcion = "Descuentos en electrodomésticos"
                },
                new Campania
                {
                    Id = 2,
                    Nombre = "Moda Otoño",
                    Categoria = "Moda",
                    Estado = "Próxima",
                    FechaInicio = DateTime.Today.AddDays(3),
                    FechaFin = DateTime.Today.AddDays(10),
                    DescuentoPct = 15,
                    Canal = "Tienda",
                    Descripcion = "Nueva temporada de ropa"
                },
                new Campania
{
    Id = 3,
    Nombre = "Electro Verano",
    Categoria = "Electro",
    Estado = "Vigente",
    FechaInicio = DateTime.Today.AddDays(-5),
    FechaFin = DateTime.Today.AddDays(5),
    DescuentoPct = 20,
    Canal = "Online",
    Descripcion = "Descuentos especiales en línea blanca"
},

new Campania
{
    Id = 4,
    Nombre = "Regalos Día de la Madre",
    Categoria = "Moda",
    Estado = "Próxima",
    FechaInicio = DateTime.Today.AddDays(15),
    FechaFin = DateTime.Today.AddDays(25),
    DescuentoPct = 10,
    Canal = "Mixto",
    Descripcion = "Campaña especial por el Día de la Madre"
},

new Campania
{
    Id = 5,
    Nombre = "Vuelta a Clases",
    Categoria = "Moda",
    Estado = "Finalizada",
    FechaInicio = DateTime.Today.AddDays(-40),
    FechaFin = DateTime.Today.AddDays(-25),
    DescuentoPct = 18,
    Canal = "Tienda",
    Descripcion = "Útiles escolares y mochilas"
},

new Campania
{
    Id = 6,
    Nombre = "Black Friday",
    Categoria = "Modas",
    Estado = "Próxima",
    FechaInicio = new DateTime(DateTime.Today.Year, 11, 25),
    FechaFin = new DateTime(DateTime.Today.Year, 11, 30),
    DescuentoPct = 35,
    Canal = "Online",
    Descripcion = "Los mayores descuentos del año"
},

new Campania
{
    Id = 7,
    Nombre = "Navidad Corporativa",
    Categoria = "Tecnologia",
    Estado = "Próxima",
    FechaInicio = new DateTime(DateTime.Today.Year, 12, 1),
    FechaFin = new DateTime(DateTime.Today.Year, 12, 20),
    DescuentoPct = 25,
    Canal = "B2B",
    Descripcion = "Regalos corporativos y canastas navideñas"
},
 new Campania
                {
                    Id = 8,
                    Nombre = "Moda Otoño",
                    Categoria = "Moda",
                    Estado = "Próxima",
                    FechaInicio = DateTime.Today.AddDays(3),
                    FechaFin = DateTime.Today.AddDays(10),
                    DescuentoPct = 15,
                    Canal = "Tienda",
                    Descripcion = "Nueva temporada de ropa"
                },
                new Campania              
{
    Id = 9,
    Nombre = "Electro Verano",
    Categoria = "Electro",
    Estado = "Vigente",
    FechaInicio = DateTime.Today.AddDays(-5),
    FechaFin = DateTime.Today.AddDays(5),
    DescuentoPct = 20,
    Canal = "Online",
    Descripcion = "Descuentos especiales en línea blanca"
},

new Campania
{
    Id = 10,
    Nombre = "Regalos Día de la Madre",
    Categoria = "Moda",
    Estado = "Próxima",
    FechaInicio = DateTime.Today.AddDays(15),
    FechaFin = DateTime.Today.AddDays(25),
    DescuentoPct = 10,
    Canal = "Mixto",
    Descripcion = "Campaña especial por el Día de la Madre"
},

new Campania
{
    Id = 11,
    Nombre = "Vuelta a Clases",
    Categoria = "Moda",
    Estado = "Finalizada",
    FechaInicio = DateTime.Today.AddDays(-40),
    FechaFin = DateTime.Today.AddDays(-25),
    DescuentoPct = 18,
    Canal = "Tienda",
    Descripcion = "Útiles escolares y mochilas"
},

new Campania
{
    Id = 12,
    Nombre = "Black Friday",
    Categoria = "Modas",
    Estado = "Próxima",
    FechaInicio = new DateTime(DateTime.Today.Year, 11, 25),
    FechaFin = new DateTime(DateTime.Today.Year, 11, 30),
    DescuentoPct = 35,
    Canal = "Online",
    Descripcion = "Los mayores descuentos del año"
},

new Campania
{
    Id = 13,
    Nombre = "Navidad Corporativa",
    Categoria = "Tecnologia",
    Estado = "Próxima",
    FechaInicio = new DateTime(DateTime.Today.Year, 12, 1),
    FechaFin = new DateTime(DateTime.Today.Year, 12, 20),
    DescuentoPct = 25,
    Canal = "B2B",
    Descripcion = "Regalos corporativos y canastas navideñas"
}
            };
        }
    }
}