using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicWebsite.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("MusicWebsite")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}