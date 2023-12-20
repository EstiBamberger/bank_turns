using Solid.Core.Enteties;


namespace Solid.Data
{
    public class DataContext
    {
        public List<Turn> Turns { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Official> Officials { get; set; }
        public DataContext()
        {
            Turns = new List<Turn>();
            Customers = new List<Customer>();
            Officials = new List<Official>();
        }
    }
}
