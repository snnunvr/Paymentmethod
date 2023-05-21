using System;

public class PaymentSystem
{
    public bool ProcessPayment(decimal amount, string currency, string paymentMethod)
    {
        // Ödeme işleminin gerçekleştirilmesi

        // Belirli bir banka sistemine entegrasyonun yapılması

        // Uluslararası ödeme seçeneklerinin yönetilmesi

        // Transferin hızlı ve akıcı bir şekilde gerçekleştirilmesi

        // İşlemin başarılı olup olmadığının kontrolü ve sonucun döndürülmesi

        return true; // İşlem başarılı ise true, aksi halde false döndürülür
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Örnek kullanım

        PaymentSystem paymentSystem = new PaymentSystem();

        decimal amount = 100.00m;
        string currency = "USD";
        string paymentMethod = "CreditCard";

        bool paymentResult = paymentSystem.ProcessPayment(amount, currency, paymentMethod);

        if (paymentResult)
        {
            Console.WriteLine("Ödeme işlemi başarılı.");
        }
        else
        {
            Console.WriteLine("Ödeme işlemi başarısız.");
        }
    }
}
