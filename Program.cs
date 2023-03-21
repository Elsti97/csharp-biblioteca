
Biblioteca biblioteca = new Biblioteca();

biblioteca.AggiungiDocumento(new Libro("1234", "1984", 1948, "Settore_1", "Economia", "George", "Orwell", 389));
biblioteca.AggiungiDocumento(new DVD("2345", "Il Padrino", 2000, "Settore_2", "Drammatico", "Regista", "Registratore", "02:55"));

// Registrazione Utente
Console.WriteLine("Utente:");
Console.WriteLine("Inserisci il tuo cognome:");
string? cognome = Console.ReadLine();

Console.WriteLine("Inserisci il tuo nome:");
string? nome = Console.ReadLine();

Console.WriteLine("Inserisci la tua email:");
string? email = Console.ReadLine();

Console.WriteLine("Inserisci la tua password:");
string? password = Console.ReadLine();

Console.WriteLine("Inserisci il tuo telefono:");
string? telefono = Console.ReadLine();

Utente nuovoUtente = new Utente(cognome, nome, email, password, telefono);
biblioteca.AggiungiUtente(nuovoUtente);


// Registrazione Documento
Console.Write("Documento: ");
Console.Write("Inserisci il codice identificativo: ");
string? codice = Console.ReadLine();

Console.Write("Inserisci il titolo: ");
string? titolo = Console.ReadLine();

Console.Write("Inserisci l'anno: ");
int anno = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Inserisci il settore: ");
string? settore = Console.ReadLine();

Console.Write("Inserisci lo scaffale: ");
string? scaffale = Console.ReadLine();

Console.Write("Inserisci il nome dell'autore: ");
string? autoreNome = Console.ReadLine();

Console.Write("Inserisci il cognome dell'autore: ");
string? autoreCognome = Console.ReadLine();

Documento nuovoDocumento = new Documento(codice, titolo, anno, settore, scaffale, autoreNome, autoreCognome);
biblioteca.AggiungiDocumento(nuovoDocumento);


