namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iscrizione user
            User Persona1 = new User("Valerio", "Bartoletti", "valerio.bartoletti97@gmail.com", "CiaoAndrea", 3273333333);

            //Aggiunta libro
            Book Libro1 = new Book("La teoria del tutto", 2015, "Scienza", "4A", "Stephen Hawking", 350);

            //Aggiunta DVD
            Dvd Dvd1 = new Dvd("Pimpa", 2006, "Cartoni", "12B", "Osvaldo Cavanoli", 0.30m);

            Dvd1.FindDocumentTitle("Pimpa");
            Dvd1.BorrowDocument();
            Libro1.BorrowDocument();
        }
    }
}

