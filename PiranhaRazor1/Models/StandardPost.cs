using Piranha.AttributeBuilder;
using Piranha.Models;

namespace PiranhaRazor1.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost : Post<StandardPost>
    {
    }
}
