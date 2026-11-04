class Dikdortgen
{
public double uzunKenar { get
{
    Console.Write("Dikdörtgenin uzun kenarını girin: ");
    return Convert.ToDouble(Console.ReadLine());
}


 set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Uzun kenar pozitif bir sayı olmalıdır.");
            }
            uzunKenar = value;
        }
        
    }
public double kisaKenar { get
        {
            Console.Write("Dikdörtgenin kısa kenarını girin: ");
            return Convert.ToDouble(Console.ReadLine());    
        }


 set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Kısa kenar pozitif bir sayı olmalıdır.");
            }
            kisaKenar = value;
        }
    }

public Dikdortgen(double uzunKenar, double kisaKenar)
{
    this.uzunKenar = uzunKenar;
    this.kisaKenar = kisaKenar;
}

    private double AlanHesapla()
    {
        return uzunKenar * kisaKenar;
    }

    private double CevreHesapla()
    {
        return 2 * (uzunKenar + kisaKenar);
    }

    public void EkranaYazdir()
    {
        Console.WriteLine($"Dikdörtgenin Alanı: {AlanHesapla()}");
        Console.WriteLine($"Dikdörtgenin Çevresi: {CevreHesapla()}");
    }
}