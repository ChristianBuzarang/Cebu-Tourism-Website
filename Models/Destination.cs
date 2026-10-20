namespace MidtermProject.Models;

public record Destination(
    string Name, string Area, string Category, string Summary,
    string Tip, string BestTime, string? Image = null);
