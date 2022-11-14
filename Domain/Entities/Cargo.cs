namespace Domain.Entities;

public partial class Cargo
{
    public Cargo()
    {
        Usuarios = new HashSet<Usuario>();
    }

    public int Id { get; set; }
    public string Codigo { get; set; }
    public string Nombre { get; set; } 
    public bool? Activo { get; set; }
    public virtual ICollection<Usuario> Usuarios { get; set; }
}
