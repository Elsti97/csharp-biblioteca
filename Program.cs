
Biblioteca biblioteca = new Biblioteca();

var res = CercaDocumentoPerCodice_TrovaPerCodice();
printTestResult(nameof(CercaDocumentoPerCodice_TrovaPerCodice), res);

void printTestResult(string testCase, bool ok)
{
    Console.WriteLine($"testing: {testCase}");
    Console.WriteLine(ok ? "Giusto" : "Test non passato");
}

bool CercaDocumentoPerCodice_TrovaPerCodice()
{
    var biblioteca = new Biblioteca();
    var test = new Documento("1234", "Il Libro", 1990, "Economia", "a", "Marco", "Rossi");
    biblioteca.AggiungiDocumento(test);
    biblioteca.AggiungiDocumento(new Documento("1265", "1984", 1984, "Fantasy", "a", "George", "Orwell"));
    biblioteca.AggiungiDocumento(new Documento("1789", "Le Metamorfosi", 1990, "Dramma", "a", "Frank", "Kafka"));

    var risultato = biblioteca.CercaDocumentoCodice("1234");

    return risultato == test;
}