namespace Domain.Dtos.Usuario
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public int IdDepartamento { get; set; }
        public int IdCargo { get; set; }
        public virtual DepartamentoDTO Departamento { get; set; }
        public virtual CargoDTO Cargo { get; set; }
    }
}
