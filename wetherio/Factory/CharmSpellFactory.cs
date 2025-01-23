using System;
using wetherio.Interfaces;
using wetherio.Models;

namespace wetherio.Factory
{
    public class CharmSpellFactory : SpellFactory
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
            if (type.ToLower() != "charm")
                throw new ArgumentException("Invalid spell type for CharmSpellFactory");

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