namespace EFEjemplo.Services
{
    public class Tools : ITools
    {
        public void Conectar()
        {
            Console.WriteLine(DateTime.Now);
        }

        public int TraerAlgo()
        {
            return 1;
        }
    }
}
