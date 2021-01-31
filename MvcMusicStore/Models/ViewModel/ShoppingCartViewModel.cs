using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Keep it in the same namespace
namespace MvcMusicStore.Models
{
    public class ShoppingCartViewModel
    {
        public IEnumerable<Album> albums { get; set; } //This is the albums list we created
        public string userName { get; set; }
        public string authenticationLevel { get; set; }
        public double cartTotal { get; set; }

    }
}
