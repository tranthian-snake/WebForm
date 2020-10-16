using MusicWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicWebsite
{
    public partial class MusicDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Music> GetMusic([QueryString("musicID")] int? musicId)
        {
            var _db = new MusicWebsite.Models.MusicContext();
            IQueryable<Music> query = _db.Musics;
            if (musicId.HasValue && musicId > 0)
            {
                query = query.Where(p => p.MusicID == musicId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}