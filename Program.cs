
using static System.Reflection.Metadata.BlobBuilder;

Biblioteca biblioteca = new Biblioteca();

var res = CercaDocumentoPerCodice_TrovaPerCodice();
printTestResult(nameof(CercaDocumentoPerCodice_TrovaPerCodice), res);

var utente1 = new Utente("Rossi", "Mario", "mario.rossi@gmail.com", "password1", "3299090909");
biblioteca.AggiungiUtente(utente1);

var utente2 = new Utente("Verdi", "Luigi", "luigi.verdi@gmail.com", "password2", "32987655780");
biblioteca.AggiungiUtente(utente2);

var libro1 = new Libro("1111", "Le Metamorfosi", 1980, "Storia", "S1", "Umberto", "Eco", 500);
biblioteca.AggiungiDocumento(libro1);

var libro2 = new Libro("2222", "Il libro 2 la vendetta", 2010, "Fantascienza", "S2", "Frank", "Kafka", 600);
biblioteca.AggiungiDocumento(libro2);

var dvd1 = new DVD("3333", "Star Wars", 1977, "Fantascienza", "S3", "Luca", "E Paolo", "02:30");
biblioteca.AggiungiDocumento(dvd1);

var documento1 = biblioteca.CercaDocumentoCodice("1111");
Console.WriteLine($"Documento trovato per codice: {documento1?.Titolo}");

var documento2 = biblioteca.CercaDocumentoTitolo("Il libro 2 la vendetta");
Console.WriteLine($"Documento trovato per titolo: {documento2?.Codice}");

Prestito prestito1 = new Prestito(utente1, libro1, DateTime.Now, DateTime.Now.AddDays(7));
biblioteca.AggiungiPrestito(prestito1);

var prestitiUtente1 = biblioteca.CercaPrestito("Mario", "Rossi");
foreach (var prestito in prestitiUtente1)
{
    Console.WriteLine("Prestito di: " + utente1.Nome + " " + utente1.Cognome);
    Console.WriteLine("Documento in prestito: " + prestito.Documento.Titolo + " Data inizio: " + prestito.DataInizio.ToShortDateString() + " Data fine: " + prestito.DataFine.ToShortDateString());
}

void printTestResult(string testCase, bool ok)
{
    Console.WriteLine($"testing: {testCase}");
    Console.WriteLine(ok ? "Giusto" : "Test non passato");
}

bool CercaDocumentoPerCodice_TrovaPerCodice()
{
    var test = new Documento("1234", "Il Libro", 1990, "Economia", "a", "Marco", "Rossi");
    biblioteca.AggiungiDocumento(test);

    var risultato = biblioteca.CercaDocumentoCodice("1234");

    return risultato == test;
}