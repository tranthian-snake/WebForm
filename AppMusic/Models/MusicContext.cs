using System.Data.Entity;

namespace AppMusic.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("AppMusic") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}