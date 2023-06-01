using System;

namespace sinif_kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class sinifAdi
            // {
            //     [Erişim belirleyici] [Veri Tipi] ÖzellikAdi;
            //     [Erişim belirleyici] [Geri Dönüş Tipi] MethodAdi([Parametre Listesi])
            //     {
            //         //Method Komutları
            //     }
            // }

            //Erişim belirleyiciler
            // * Public (Her yerden erişilebilir)
            // * Private (Sadece tanımlandığı sınıf içerisinden erişilebilir.)
            // * Internal (Sadece bulunduğu proje içerisiniden erişilebilir)
            // * Protected (Sadece bulunduğu sınıfta veya O sınıftan kalıtım(miras) alan sınıflar içerisinden)
            Console.WriteLine("*****Çalışan 1*****");
            Calisan calisan1 = new Calisan("Ayşe","Kara",23425634,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();
            Console.WriteLine("*****Çalışan 2*****");
            Calisan calisan2 = new Calisan();
            calisan2.Ad ="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";
            calisan2.CalisanBilgileri();
            Console.WriteLine("*****Çalışan 1*****");
            Calisan calisan3 = new Calisan("Muhammed","Salih");
            calisan3.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman=departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad =ad;
            this.Soyad =soyad;
        }
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }

    }
}