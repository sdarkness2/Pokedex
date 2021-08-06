using Microsoft.EntityFrameworkCore;
using MVC_Pokedex.Models;

namespace MVC_Pokedex.Data
{
    public class PokedexContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }

        public PokedexContext(DbContextOptions<PokedexContext> options):base(options)
        {

        }
    }
}
