namespace BackendGestorDeGastos.Models
{
    public class LoginModel
    {
        public required string Usuario { get; set; }
        public required string Correo { get; set; }
        public required string Clave { get; set; }

    }
}
