namespace Business.Models.Request;

public class RegisterDto
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Password { get; set; } = default!;
 
    public string SurName { get; set; } = default!;
    public string Adress { get; set; }
    public string Gsm { get; set; }
}