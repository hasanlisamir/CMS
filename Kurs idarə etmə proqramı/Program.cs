namespace Kurs_idarə_etmə_proqramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Qrup> qruplar = new List<Qrup>();
            List<Muellim> muellimler = new List<Muellim>();
            List<Mentor> mentorlar = new List<Mentor>();
            List<Telebe> telebeler = new List<Telebe>();

            while (true)
            {
                Console.WriteLine("\n1. Qrup elave et");
                Console.WriteLine("2. Qrup deyişdir");
                Console.WriteLine("3. Qrup sil");
                Console.WriteLine("4. Mövcud qrupları göster");
                Console.WriteLine("5. Müellim elave et");
                Console.WriteLine("6. Müellim deyişdir");
                Console.WriteLine("7. Müellim sil");
                Console.WriteLine("8. Mövcud müellimleri göster");
                Console.WriteLine("9. Mentor elave et");
                Console.WriteLine("10. Mentor deyişdir");
                Console.WriteLine("11. Mentor sil");
                Console.WriteLine("12. Mövcud mentorları göster");
                Console.WriteLine("13. Telebe elave et");
                Console.WriteLine("14. Telebe deyişdir");
                Console.WriteLine("15. Telebe sil");
                Console.WriteLine("16. Mövcud telebeleri göster");
                Console.WriteLine("17. Müellim-Qrup elaqesi yarat");
                Console.WriteLine("18. Mentor-Qrup elaqesi yarat");
                Console.WriteLine("19. Telebe-Qrup elaqesi yarat");
                Console.WriteLine("0. Çıxış");

                Console.Write("Seçiminizi edin: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        QrupElaveEt(qruplar);
                        break;
                    case 2:
                        QrupDeyisdir(qruplar);
                        break;
                    case 3:
                        QrupSil(qruplar);
                        break;
                    case 4:
                        QruplariGoster(qruplar);
                        break;
                    // Diğer işlemler buraya elave edile biler
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }
            }
        }

        static void QrupElaveEt(List<Qrup> qruplar)
        {
            Console.Write("Qrup kodunu daxil edin: ");
            int qrupKodu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qrup adını daxil edin: ");
            string qrupAdi = Console.ReadLine();

            bool varMi = false;
            foreach (var qrup in qruplar)
            {
                if (qrup.QrupKodu == qrupKodu)
                {
                    Console.WriteLine("Bu qrup koduna sahib bir qrup sistemde mövcuddur.");
                    varMi = true;
                    break;
                }
            }

            if (!varMi)
            {
                qruplar.Add(new Qrup(qrupKodu, qrupAdi));
                Console.WriteLine("Qrup elave edildi.");
            }
        }

        static void QrupDeyisdir(List<Qrup> qruplar)
        {
            Console.Write("Deyişmek istediyiniz qrupun kodunu daxil edin: ");
            int qrupKodu = Convert.ToInt32(Console.ReadLine());

            bool tapildi = false;
            foreach (var qrup in qruplar)
            {
                if (qrup.QrupKodu == qrupKodu)
                {
                    Console.Write("Yeni qrup adını daxil edin: ");
                    string yeniQrupAdi = Console.ReadLine();
                    qrup.QrupAdi = yeniQrupAdi;
                    Console.WriteLine("Qrup melumatları deyişdirildi.");
                    tapildi = true;
                    break;
                }
            }

            if (!tapildi)
                Console.WriteLine("Bele bir qrup tapılmadı.");
        }

        static void QrupSil(List<Qrup> qruplar)
        {
            Console.Write("Silmek istediyiniz qrupun kodunu daxil edin: ");
            int qrupKodu = Convert.ToInt32(Console.ReadLine());

            bool tapildi = false;
            for (int i = 0; i < qruplar.Count; i++)
            {
                if (qruplar[i].QrupKodu == qrupKodu)
                {
                    qruplar.RemoveAt(i);
                    Console.WriteLine("Qrup silindi.");
                    tapildi = true;
                    break;
                }
            }

            if (!tapildi)
                Console.WriteLine("Bele bir qrup tapılmadı.");
        }

        static void QruplariGoster(List<Qrup> qruplar)
        {
            Console.WriteLine("Mövcud qruplar:");
            foreach (var qrup in qruplar)
            {
                Console.WriteLine($"Qrup kodu: {qrup.QrupKodu}, Qrup adı: {qrup.QrupAdi}");
            }
        }
    }
   
    
}
    
