using System;
using System.Collections.Generic;

namespace PaperPlease
{
    public record Entity(int id, bool? isHumanoid, string? planet, double? age, List<string>? traits);
}
