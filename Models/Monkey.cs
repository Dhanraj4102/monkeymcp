#nullable enable

namespace MonkeyApp.Models
{
    /// <summary>
    /// Represents a monkey with basic information.
    /// </summary>
    public class Monkey
    {
        /// <summary>
        /// Gets or sets the name of the monkey.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the location where the monkey is found.
        /// </summary>
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the estimated population of the monkey.
        /// </summary>
        public int Population { get; set; }
    }
}
