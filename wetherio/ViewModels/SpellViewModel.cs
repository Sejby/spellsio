using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using wetherio.Models;
using System.Diagnostics;
using System.Linq;

namespace wetherio.ViewModels;

public partial class SpellViewModel : ViewModelBase
{
    public ObservableCollection<Spell> Spells { get; private set; }

    public SpellViewModel()
    {
        Spells = new ObservableCollection<Spell>();
        _ = InitializeAsync();
    }

    public async Task InitializeAsync()
    {
        await LoadSpellsAsync();
    }

    private async Task LoadSpellsAsync()
    {
        using HttpClient client = new();
        try
        {
            Debug.WriteLine("Načítání dat z API...");
            var response = await client.GetStringAsync("https://wizard-world-api.herokuapp.com/Spells");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var spells = JsonSerializer.Deserialize<List<Spell>>(response, options)?
                        .Take(10)
                        .ToList();

            if (spells != null)
            {
                Spells.Clear();  // Clear existing spells first
                foreach (var spell in spells)
                {
                    Debug.WriteLine($"Přidávám kouzlo: {spell.Name}");
                    Spells.Add(spell);
                }
            }
        }
        catch (HttpRequestException ex)
        {
            Debug.WriteLine($"Chyba při načítání dat: {ex.Message}");
        }
    }
}
