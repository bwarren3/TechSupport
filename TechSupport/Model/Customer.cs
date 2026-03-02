namespace TechSupport.Model
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; } = "";
        public override string ToString() => Name;
    }
}
