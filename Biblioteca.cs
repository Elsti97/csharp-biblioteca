using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Biblioteca
{
    private List<Utente> utenti;
    private List<Documento> documenti;
    private List<Prestito> prestiti;

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

    public void AggiungiPrestito(Utente utente, Documento documento, DateTime dataInizio, DateTime dataFine)
    {
        if (!utenti.Contains(utente))
        {
            Console.WriteLine("Utente non registrato");
            return;
        }

        if (!documenti.Contains(documento))
        {
            Console.WriteLine("Documento inesistente");
            return;
        }

        prestiti.Add(new Prestito(utente, documento, dataInizio, dataFine));
    }

    public List<Documento> RicercaDocumento(string titolo)
    {
        return documenti.FindAll(documento => documento.Titolo.Contains(titolo));
    }

    public List<Documento> RicercaDocumentoPerCodice(string codice)
    {
        return documenti.FindAll(documento => documento.Codice == codice);
    }

    public List<Prestito> RicercaPrestito(string nome, string cognome)
    {
        return prestiti.FindAll(prestito => prestito.Utente.Nome == nome && prestito.Utente.Cognome == cognome);
    }

    public void PrestitoDocumento(string codice, string cognome, string nome, DateTime dataInizio, DateTime dataFine)
    {
        Documento documento = RicercaDocumentoPerCodice(codice).FirstOrDefault();
        if (documento == null)
        {
            Console.WriteLine("Documento inesistente");
            return;
        }

        Utente utente = utenti.Find(utente => utente.Nome == nome && utente.Cognome == cognome);
        if (utente == null)
        {
            Console.WriteLine("Utente non registrato");
            return;
        }

        if (prestiti.Any(prestito => prestito.Documento.Codice == codice && prestito.DataFine > DateTime.Now))
        {
            Console.WriteLine("Il documento non disponibile");
            return;
        }

        AggiungiPrestito(utente, documento, dataInizio, dataFine);
    }
}


