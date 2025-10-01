using System;

namespace MyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool devamEt = true;
            
            while (devamEt)
            {
                Console.Clear();
                Console.WriteLine("=== Soru Seçim Menüsü ===");
                Console.WriteLine("1. Birinci Soru - Try-Catch Yapısı");
                Console.WriteLine("2. İkinci Soru");
                Console.WriteLine("3. Üçüncü Soru");
                Console.WriteLine("4. Dördüncü Soru");
                Console.WriteLine("5. Beşinci Soru");
                Console.WriteLine("0. Çıkış");
                Console.Write("Lütfen bir seçim yapın (0-5): ");
                
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Program sonlandırılıyor...");
                            devamEt = false;
                            break;
                        case 1:
                            BirinciSoru();
                            break;
                        case 2:
                            IkinciSoru();
                            break;
                        case 3:
                            UcuncuSoru();
                            break;
                        case 4:
                            DorduncuSoru();
                            break;
                        case 5:
                            BesinciSoru();
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim! Lütfen 0-5 arasında bir sayı girin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                }
                
                if (devamEt)
                {
                    Console.WriteLine("\nDevam etmek için herhangi bir tuşa basın...");
                    Console.ReadKey();
                }
            }
        }

        public static void BirinciSoru()
        {
            Console.WriteLine("\n=== Birinci Soru: Try-Catch Yapısı ===");

            int[] numbers = { 1, 2, 3 };

            try
            {
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Hata yakalandı: {ex.Message}");
                Console.WriteLine("Dizinin sınırları dışında bir indekse erişmeye çalıştınız.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
            }
        }

        public static void IkinciSoru()
        {
            Console.WriteLine("\n=== İkinci Soru ===");
            Console.WriteLine("İkinci soru henüz hazırlanmadı.");
        }

        public static void UcuncuSoru()
        {
            Console.WriteLine("\n=== Üçüncü Soru ===");
            Console.WriteLine("Üçüncü soru henüz hazırlanmadı.");
        }

        public static void DorduncuSoru()
        {
            Console.WriteLine("\n=== Dördüncü Soru ===");
            Console.WriteLine("Dördüncü soru henüz hazırlanmadı.");
        }

        public static void BesinciSoru()
        {
            Console.WriteLine("\n=== Beşinci Soru ===");
            Console.WriteLine("Beşinci soru henüz hazırlanmadı.");
        }
    }
}
