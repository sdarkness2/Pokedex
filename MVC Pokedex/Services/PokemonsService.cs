using System.Collections.Generic;
using System.Linq;
using MVC_Pokedex.Data;
using MVC_Pokedex.Models;

namespace MVC_Pokedex.Services
{
    public class PokemonsService
    {
        private PokedexContext _context;

        public PokemonsService(PokedexContext context)
        {
            this._context = context;
        }

        public List<Pokemon> ListaPokemons()
        {
            return _context.Pokemons.ToList();
        }
    }
}
