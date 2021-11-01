using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler= new string [5];
            string [] hayvanlar={"kedi","köpek","kuş"};

            int [] dizi;
            dizi=new int[5];


            //dizilere değer atama ve erişim

            renkler [0]= "Mavi";
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[3]);

            //Döngülerle Dizi

            Console.Write("Lütfen dizinin eleman saisini giriniz");
            int diziuzunlugu=int.Parse(Console.ReadLine());

            int [] sayiDizisi=new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("lütfen {0}.sayisi giriniz",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());

            }
            
            int toplam =0;
            
            foreach (var sayi in sayiDizisi)
                toplam +=sayi;
            
            Console.Write("ortalama :"+toplam/diziuzunlugu);
                
           





        }
    }
}
