using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMusic.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("MyMusic") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}