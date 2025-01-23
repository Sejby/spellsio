using System;
using wetherio.Interfaces;


namespace wetherio.Factory;

public abstract class SpellFactory
{
    public abstract ISpell CreateSpell(
        Guid id,
        string name,
        string incantation,
        string effect,
        bool? canBeVerbal,
        string type,
        string light,
        string creator
    );
}