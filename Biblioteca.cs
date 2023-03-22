using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Biblioteca
{
    readonly List<Utente> utenti;
    readonly List<Documento> documenti;
    readonly List<Prestito> prestiti;

    public Biblioteca()
    {
        utenti = new List<Utente>();
        documenti = new List<Documento>();
        prestiti = new List<Prestito>();
    }

    public void AggiungiUtente(Utente utente)
    {
        utenti.Add(utente);
    }

    public void AggiungiDocumento(Documento documento)
    {
        documenti.Add(documento);
    }

    public void AggiungiPrestito(Prestito prestito)
    {
        prestiti.Add(prestito);
    }

    public Documento? CercaDocumentoCodice(string codice)
    {
        return documenti.FirstOrDefault(d => d.Codice == codice);
    }

    public Documento? CercaDocumentoTitolo(string titolo)
    {
        return documenti.FirstOrDefault(d => d.Titolo == titolo);
    }

    public IEnumerable<Prestito> CercaPrestito(string nomeUtente, string cognomeUtente)
    {
        return prestiti.Where(prestito => prestito.Utente.Nome == nomeUtente && prestito.Utente.Cognome == cognomeUtente);
    }
}


