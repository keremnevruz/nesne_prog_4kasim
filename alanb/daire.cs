class Daire
{
    public double yaricap {
        get
        {
            Console.Write("Dairenin yarıçapını girin: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    
    
    
    set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Yarıçap pozitif bir sayı olmalıdır.");
            }
            yaricap = value;
        }
    }
    

    public Daire(double yaricap)
    {
        this.yaricap = yaricap;
    }

    public double AlanHesapla()
    {
        return Math.PI * yaricap * yaricap;
    }

    public void EkranaYazdir()
    {
        Console.WriteLine("Dairenin alanı: " + AlanHesapla());
    }
}