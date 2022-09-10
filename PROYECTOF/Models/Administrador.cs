namespace PROYECTOF.Models
{
    public class Administrador : Entidad
    {
        public int identificacion { get; private set; }

        public string nombre { get; private set; }

        public string tipo { get; private set; }

        public List<Vendedor> Vendedores { get; private set; }

        private Administrador(): base()
        {

        }

        public Administrador(Guid id,int identificacion, string nombre, string tipo): base(id)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public static Administrador Build(Guid id, int identificacion, string nombre, string tipo)
        {
            return new Administrador(id,identificacion,nombre,tipo);
        
        }
    }
}
