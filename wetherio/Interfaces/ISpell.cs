using System;

namespace wetherio.Interfaces;

public interface ISpell
{
    Guid Id { get; set; }
    string Name { get; set; }
    string Incantation { get; set; }
    string Effect { get; set; }
    bool? CanBeVerbal { get; set; }
    string Type { get; set; }
    string Light { get; set; }
    string Creator { get; set; }
}