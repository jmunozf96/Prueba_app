namespace Domain.Entities;

public partial class Usuario
{
    public int Id { get; set; }
    public string PrimerNombre { get; set; } = null!;
    public string? SegundoNombre { get; set; }
    public string PrimerApellido { get; set; } = null!;
    public string? SegundoApellido { get; set; }
    public int IdDepartamento { get; set; }
    public int IdCargo { get; set; }
    public virtual Departamento Departamento { get; set; }
    public virtual Cargo Cargo { get; set; }
}
