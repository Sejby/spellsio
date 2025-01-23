using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using wetherio.Models;
using System.Diagnostics;
using wetherio.Factory;
using System.Linq;
using wetherio.Interfaces;

namespace wetherio.ViewModels;

public partial class SpellViewModel : ViewModelBase
{
    public ObservableCollection<ISpell> Spells { get; private set; }

    public SpellViewModel()
    {
        Spells = new ObservableCollection<ISpell>();
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
            Debug.WriteLine("Loading spells from API...");
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
                Spells.Clear();
                foreach (var spell in spells)
                {
                    SpellFactory? factory;
                    switch (spell.Type.ToLower())
                    {
                        case "charm":
                            factory = new CharmSpellFactory();
                            break;
                        case "conjuration":
                            factory = new ConjurationSpellFactory();
                            break;
                        default:
                            factory = new DefaultSpellFactory();
                            break;
                    }

                    var createdSpell = factory.CreateSpell(
                        spell.Id,
                        spell.Name,
                        spell.Incantation,
                        spell.Effect,
                        spell.CanBeVerbal,
                        spell.Type,
                        spell.Light,
                        spell.Creator
                    );
                    Spells.Add(createdSpell);
                }
            }
        }
        catch (HttpRequestException ex)
        {
            Debug.WriteLine($"Error loading data: {ex.Message}");
        }
    }
}