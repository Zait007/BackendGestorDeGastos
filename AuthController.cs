using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BackendGestorDeGastos.Models; // Asegúrate de tener este namespace correcto

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly BackendGestorDeGastosContext _context;

    public AuthController(BackendGestorDeGastosContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel login)
    {
        var user = _context.Usuario.SingleOrDefault(u => u.correo == login.Correo && u.clave == login.Clave);

        if (user == null)
            return Unauthorized("Credenciales incorrectas");

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.rutusuario),
            new Claim(ClaimTypes.Name, user.correo),
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("tu_clave_secreta"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer: "TuAplicacionBackend",
            audience: "TuAplicacionFrontend",
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds
        );

        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
        return Ok(new { Token = tokenString });
    }
}
