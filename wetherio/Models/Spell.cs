using System;

namespace wetherio.Models;

public class Spell
{
    required public Guid Id { get; set; }
    required public string Name { get; set; }
    required public string Incantation { get; set; }
    required public string Effect { get; set; }
    public bool? CanBeVerbal { get; set; }
    required public string Type { get; set; }
    required public string Light { get; set; }
    required public string Creator { get; set; }
}
