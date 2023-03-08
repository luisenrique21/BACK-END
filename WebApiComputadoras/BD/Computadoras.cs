namespace WebApicomputadoras.BD
{
    public class Computadoras
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public int TiendaID { get; set; }

        public int Precio { get; set; }
        public List<Tiendas> Tienda { get; set; }
    }
}
