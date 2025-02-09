using System;

public class Program
{
    public static void Main()
    {
        try
        {
            // Potansiyel hata oluşturabilecek kod bloğu
            Console.Write("Lütfen bir sayı giriniz: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int kare = number * number;

            Console.WriteLine("Girdiğiniz sayının karesi: " + kare);
        }
        catch (FormatException ex)
        {
            // Format hatası durumunda burası çalışır
            Console.WriteLine("Hata: Sayı formatı geçersiz. Lütfen doğru formatta bir sayı giriniz.");
        }
        catch (Exception ex)
        {
            // Genel hata durumu için burası çalışır
            Console.WriteLine("Bir hata oluştu: " + ex.Message);
        }
        finally
        {
            // Her durumda çalışmasını istediğiniz kodlar buraya yazılır
            Console.WriteLine("İşlem tamamlandı.");
        }
    }
}