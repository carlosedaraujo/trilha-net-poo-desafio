
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        
        // IMPLEMENTADO

        private string Modelo { get; set; }

        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            // IMPLEMENTADO

            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            //refatorando...
            Console.WriteLine($"Ligando... {Numero}");
            Thread.Sleep(2000);
          
        }

       

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            Thread.Sleep(2000);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}