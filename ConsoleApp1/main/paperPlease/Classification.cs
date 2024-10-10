using System;

namespace PaperPlease
{
    public class Classification
    { 
        private RuleSet? rules;
        public Classification(RuleSet? rules) => this.rules = rules;
        public Dictionary<string, Universe> Process(EntityData? individuals)
        {
            Dictionary<string, Universe> universes = new Dictionary<string, Universe>
            {
                { "starWars", new Universe("starWars", new EntityData()) },
                { "hitchHiker", new Universe("hitchHiker", new EntityData()) },
                { "marvel", new Universe("marvel", new EntityData()) },
                { "rings", new Universe("rings", new EntityData()) }
            };
            
            foreach (var entity in individuals.Data)
            {
                // think about naming
                string? entAffiliatedPlanet = rules.GetTheAffinity(entity);
                if (!string.IsNullOrEmpty(entAffiliatedPlanet)){
                    universes[entAffiliatedPlanet].individuals.AddEntity(entity);
                };
            }
            return universes;


        }
    }
}
