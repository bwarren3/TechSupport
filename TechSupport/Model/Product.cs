namespace TechSupport.Model
{
    public class Product
    {
        public string ProductCode { get; set; } = "";
        public string Name { get; set; } = "";
        public override string ToString() => Name;
    }
}