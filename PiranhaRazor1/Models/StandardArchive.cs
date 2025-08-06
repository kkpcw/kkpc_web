using Piranha.AttributeBuilder;
using Piranha.Models;

namespace PiranhaRazor1.Models
{
    [PageType(Title = "Standard archive", IsArchive = true)]
    public class StandardArchive : Page<StandardArchive>
    {
    }
}
