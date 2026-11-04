namespace alanb;

class Program
{
    static void Main(string[] args)
    {
        Dikdortgen dikdortgen = new Dikdortgen(kisaKenar, uzunKenar);
        dikdortgen.EkranaYazdir();

        Daire daire = new Daire();
        daire.EkranaYazdir();
    }
}
