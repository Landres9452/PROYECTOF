namespace PROYECTOF.Models
{
    public abstract class Entidad
    {
        public Guid Id { get; protected set; }

        protected Entidad()
        { 
        
        }
        protected Entidad(Guid id)
        {
            Id = id;
        }
    }
}
