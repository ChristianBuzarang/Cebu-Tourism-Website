using MidtermProject.Models;

namespace MidtermProject.Services;

public class DestinationService
{
    public string[] Categories { get; } = { "All", "History", "Beaches", "Nature", "Adventure" };

    public List<Destination> All { get; } = new()
    {
        new("Magellan's Cross", "Cebu City", "History",
            "A kiosk in the city centre shelters the cross said to be planted by Magellan's crew in 1521, when Cebuanos first embraced Christianity.",
            "Go early in the morning, before the heat and the tour groups.", "Any time, free entry", "images/magellans-cross.png"),
        new("Basilica del Santo Niño", "Cebu City", "History",
            "The oldest Roman Catholic church in the country, built beside the cross and home to the Santo Niño image given by Magellan.",
            "Dress modestly. Masses are crowded on Fridays and Sundays.", "Any time"),
        new("Fort San Pedro", "Cebu City", "History",
            "A triangular Spanish fort by the harbour, with stone walls, cannon bastions and a quiet courtyard garden.",
            "Pair it with the cross and basilica; all three are within walking distance.", "Morning or late afternoon"),
        new("Lapu-Lapu Shrine", "Mactan Island", "History",
            "A bronze statue of Datu Lapu-Lapu, who led the Mactan warriors that stopped Magellan in the Battle of Mactan.",
            "Visit before or after an island-hopping trip, since it is on the way.", "Any time, free entry", "images/lapu-lapu.png"),
        new("Temple of Leah", "Busay, Cebu City", "Nature",
            "A Roman-style temple in the hills with sweeping city views, built as a monument to love and family.",
            "Allow time for the nearby Sirao Garden and a hilltop dinner.", "Late afternoon for sunset", "images/temple-of-leah.png"),
        new("Mactan Beaches", "Mactan Island", "Beaches",
            "Clear turquoise water and white sand a short ride from the airport, with resorts and day-use beach clubs.",
            "Day passes are available at most beach clubs if you aren't staying overnight.", "November to May", "images/beach.png"),
        new("Kawasan Falls", "Badian", "Adventure",
            "Three-tiered turquoise falls and the starting point for canyoneering through the Matutinao River gorge.",
            "Book a licensed guide for canyoneering and bring water shoes.", "Dry season, early morning"),
        new("Moalboal Sardine Run", "Moalboal", "Adventure",
            "Millions of sardines swirl just off Panagsama Beach, close enough to reach with a snorkel from shore.",
            "Stay calm in the water and never touch the sardines or the turtles.", "Year-round, mornings are best"),
        new("Bantayan Island", "North Cebu", "Beaches",
            "Powder-white beaches, slow island roads and fresh seafood, a few hours from Cebu City by road and ferry.",
            "Rent a motorbike or tricycle to reach Sugar Beach and Paradise Beach.", "December to May")
    };

    public IEnumerable<Destination> ByCategory(string category) =>
        category == "All" ? All : All.Where(d => d.Category == category);
}
