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
    public partial class MusicList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Music> GetMusics([QueryString("id")] int? categoryId)
        {
            var _db = new MusicWebsite.Models.MusicContext();
            IQueryable<Music> query = _db.Musics;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}