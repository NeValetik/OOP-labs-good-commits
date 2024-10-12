using System;

namespace PaperPlease
{
    public record Entity(int id, bool? isHumanoid, string? planet, double? age, List<string>? traits);
}
