using Interface_Segregation_Principle;

namespace Design_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IBorrwableDVD dvd = new DVD();
            dvd.CheckIn();
        }
    }
}