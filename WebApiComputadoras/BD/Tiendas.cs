namespace WebApicomputadoras.BD
{
    public class Tiendas
    {
        public int Id { get ; set; }
        
        public string Nombre { get; set; }
        
        public string Direccion { get; set;}
        
        public int Precio { get; set; }
        
        public int ComputadoraID { get; set; }
        public Computadoras Computadoras { get; set; }
    }
}
