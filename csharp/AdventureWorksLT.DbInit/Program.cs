using DevZest.Data.DbInit;

namespace DevZest.Samples.AdventureWorksLT
{
    class Program
    {
        static int Main(string[] args)
        {
            return args.RunDbInit();
        }
    }
}
