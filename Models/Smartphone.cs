namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        //Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            //Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public void ModeloCelular()
        {
            Console.WriteLine($"Modelo: {Modelo}");
        }
        public void NumeroCelular()
        {
            Console.WriteLine($"Número: {Numero}");
        }
        public void IMEICelular()
        {
            Console.WriteLine($"IMEI: {IMEI}");
        }
        public void MemoriaCelular()
        {
            Console.WriteLine($"Memória: {Memoria} GB");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}