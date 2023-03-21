using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Documento
{
    public string Codice { get; set; }
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public string? Scaffale { get; set; }
    public string? AutoreNome { get; set; }
    public string AutoreCognome { get; set; }


    public Documento(string codice, string titolo, int anno, string settore, string scaffale, string autoreNome, string autoreCognome)
    {
        Codice = codice;
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Scaffale = scaffale;
        AutoreNome = autoreNome;
        AutoreCognome = autoreCognome;
    }
}

public class Libro : Documento
{
    public int Pagine { get; set; }

    public Libro(string codice, string titolo, int anno, string settore, string scaffale, string autoreNome, string autoreCognome, int pagine)
    : base(codice, titolo, anno, settore, scaffale, autoreNome, autoreCognome)
    {
        Pagine = pagine;
    }
}

public class DVD : Documento
{
    public string Durata { get; set; }

    public DVD(string codice, string titolo, int anno, string settore, string scaffale, string autoreNome, string autoreCognome, string durata)
    : base(codice, titolo, anno, settore, scaffale, autoreNome, autoreCognome)
    {
        Durata = durata;
    }
}