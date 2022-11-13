// See https://aka.ms/new-console-template for more information
public class Prestito
{
    public DateTime DataInizio { get; set; }
    public DateTime DataFine { get; set; }

    public Prestito()
    {
        //Un nuovo prestito avrà come data inizio prestito la data corrente e come durata prestabilita una settimana
        DataInizio = DateTime.Now;
        DataFine = DateTime.Now.AddDays(7);
    }
}