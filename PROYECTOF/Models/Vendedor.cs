namespace PROYECTOF.Models
{
    public class Vendedor : Entidad
    {
        public int identificacion { get; private set; }

        public string nombre { get; private set; }

        public Guid AdministradorId { get; private set; }

        public Administrador Administrador { get; private set; }

        private Vendedor()
        { 
        
        }

        private Vendedor (Guid id, int identificacion, string nombre, Guid administradorId) : base(id)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            AdministradorId = administradorId;
        }

        public Vendedor Build(Guid id, int identificacion, string nombre, Guid administradorId)
        {
            return new Vendedor(id, identificacion, nombre, administradorId);

        }
    }
}
