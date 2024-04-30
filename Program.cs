using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Music Player");

            Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");

            Nokia nokia2 = new Nokia("2499999-9878", "Nokia 3380", "3902387490", 256);
            nokia2.Ligar();
            nokia2.ReceberLigacao();
            nokia2.InstalarAplicativo("Facebook");

            Iphone iphone2 = new Iphone("2499999-9878", "iPhone 15", "3902387490", 256);
            iphone2.Ligar();
            iphone2.ReceberLigacao();
            iphone2.InstalarAplicativo("Instagram");


        }
    }
}