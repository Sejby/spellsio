using System;
using wetherio.Interfaces;
using wetherio.Models;

namespace wetherio.Factory
{
    public class DefaultSpellFactory : SpellFactory
    {
        public override ISpell CreateSpell(
            Guid id,
            string name,
            string incantation,
            string effect,
            bool? canBeVerbal,
            string type,
            string light,
            string creator)
        {
            return new Spell
            {
                Id = id,
                Name = name,
                Incantation = incantation,
                Effect = effect,
                CanBeVerbal = canBeVerbal,
                Type = type,
                Light = light,
                Creator = creator
            };
        }
    }
}