namespace MidtermProject.Services;

public class FavoritesService
{
    private readonly HashSet<string> _saved = new();
    public event Action? Changed;

    public int Count => _saved.Count;
    public IReadOnlyCollection<string> Saved => _saved;
    public bool IsSaved(string name) => _saved.Contains(name);

    public void Toggle(string name)
    {
        if (!_saved.Remove(name)) _saved.Add(name);
        Changed?.Invoke();
    }
}