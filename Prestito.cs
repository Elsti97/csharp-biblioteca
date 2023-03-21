using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Prestito
{
    public Utente Utente { get; set; }
    public Documento Documento { get; set; }
    public DateTime DataInizio { get; set; }
    public DateTime DataFine { get; set; }

    public Prestito(Utente utente, Documento documento, DateTime dataInizio, DateTime dataFine)
    {
        Utente = utente;
        Documento = documento;
        DataInizio = dataInizio;
        DataFine = dataFine;
    }
}