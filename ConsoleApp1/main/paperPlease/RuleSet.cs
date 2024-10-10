using System;

namespace PaperPlease
{
    public class RuleSet
    {
        private Dictionary<string, List<Race>> rulesForUniverses = new Dictionary<string, List<Race>> {};

        public RuleSet(Dictionary<string, List<Race>> rule) {
            this.rulesForUniverses = rule;
        }

        public string? GetTheAffinity(Entity ent)
        {
            foreach (KeyValuePair<string, List<Race>> entry in this.rulesForUniverses)
            {
                foreach (Race race in entry.Value)
                {
                    if (ent.isHumanoid.HasValue && race.isHumanoid.HasValue && ent.isHumanoid != race.isHumanoid)
                        continue;

                    if (!string.IsNullOrEmpty(ent.planet) && !string.Equals(ent.planet, race.planet, StringComparison.OrdinalIgnoreCase))
                        continue;

                    if (ent.age.HasValue && ent.age > race.maxAge)
                        continue;

                    if (ent.traits != null && ent.traits.Any() && (race.traits == null || !ent.traits.All(trait => race.traits.Contains(trait))))
                        continue;

                    return entry.Key;
                }
            }
            return null;
        }
    }
}
