using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperPlease
{
    public record Race(bool? isHumanoid, string? planet, double? maxAge, List<string>? traits);

}
