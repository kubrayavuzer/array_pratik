using System;
class Program
{
    static void Main()
    {
        //10 adet sayı verisi alacak dizi

        int[] sayilar = new int[10];

        //dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazdır

        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = i;
        }

        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        //Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)

        Console.WriteLine("Sayı eklemek için bir sayı giriniz.");

        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        int[] yeniDizi = new int[sayilar.Length +1 ];

        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i];
        }

        yeniDizi[sayilar.Length] = yeniSayi;

        //yeni diziyi ekrana yazdır

        foreach (int sayi in yeniDizi)
        {
            Console.WriteLine(sayi);
        }

        //diziyi küçükten büyüğe yazdır

        for (int i = 0; i < yeniDizi.Length -1; i++ )
            {
            for ( int j = 0; j < yeniDizi.Length -1 - i ; j++ )
            {
                if (yeniDizi[j] > yeniDizi[j +1])
                {
                    int temp = yeniDizi[j];
                    yeniDizi[j] = yeniDizi[j +1];
                    yeniDizi[j +1] = temp;
                }
            }
        }

        //yazdır
        Console.WriteLine("küçükten büyüğe sıralanmış dizi:");

        foreach (int sayi in yeniDizi)
        {
            Console.WriteLine(sayilar);
        }
    }

}
