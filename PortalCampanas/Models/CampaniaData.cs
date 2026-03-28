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
                }
            };
        }
    }
}