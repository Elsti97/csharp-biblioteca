using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Utente
{
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string? Password { get; set; }
    public string? Telefono { get; set; }

    public Utente(string cognome, string nome, string email, string? password, string? telefono)
    {
        Cognome = cognome;
        Nome = nome;
        Email = email;
        Password = password;
        Telefono = telefono;
    }
}
