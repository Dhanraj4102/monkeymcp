namespace MyMonkeyApp;

/// <summary>
/// Represents a monkey species with relevant details.
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
    /// Gets or sets the population of the monkey species.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Gets or sets additional details about the monkey.
    /// </summary>
    public string? Details { get; set; }

    /// <summary>
    /// Gets or sets the image URL for the monkey.
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Gets or sets the latitude of the monkey's location.
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude of the monkey's location.
    /// </summary>
    public double? Longitude { get; set; }
}
