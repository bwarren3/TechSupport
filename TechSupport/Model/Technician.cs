namespace TechSupport.Model
{
    /// <summary>
    /// Represents a technician.
    /// </summary>
    public class Technician
    {
        /// <summary>
        /// Gets or sets the tech identifier.
        /// </summary>
        public int TechID { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString() => Name;
    }
}