using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MusicWebsite.Models
{
    public class MusicDatabaseInitializer : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetMusics().ForEach(p => context.Musics.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID=1,
                    CategoryName="Nhạc Việt"
                },
                new Category
                {
                    CategoryID=2,
                    CategoryName="Nhạc Hoa"
                },
                new Category
                {
                    CategoryID=3,
                    CategoryName="Nhạc Nhật"
                },
                new Category
                {
                    CategoryID=4,
                    CategoryName="US-UK"
                },
            };

            return categories;
        }

        private static List<Music> GetMusics()
        {
            var musics = new List<Music>
            {
                new Music
                {
                    MusicID = 1,
                    MusicName = "Doraemon",
                    Information = "Ca sĩ: Hoshino Gen; Sáng tác: Lyricist: Hoshino Gen; Composer: Hoshino Gen, Shunsuke Kikuchi; Album: Doraemon",
                    ImagePath="doraemon.jpg",
                    CategoryID = 3
                },
                new Music
                {
                    MusicID = 2,
                    MusicName = "Ai Mang Cô Đơn Đi",
                    Information = "Ca sĩ: K-ICM, APJ; Sáng tác: K - ICM, APJ; Album: Ai Mang Cô Đơn Đi(Single); Năm phát hành: 2020",
                    ImagePath="aimangcodondi.jpg",
                    CategoryID = 1
                },
                new Music
                {
                    MusicID = 3,
                    MusicName = "1 2 3 4",
                    Information = "Ca sĩ: Chi Dân; Sáng tác: Nguyễn Đình Vũ; Album: 1 2 3 4(Single); Năm phát hành: 2017",
                    ImagePath="1234.jpg",
                    CategoryID = 1
                },
                new Music
                {
                    MusicID = 4,
                    MusicName = "Cánh Hoa Tổn Thương",
                    Information = "Ca sĩ: Hoàng Yến Chibi; Sáng tác: Nguyễn Đình Vũ; Album: Cánh Hoa Tổn Thương(Single); Năm phát hành: 2020",
                    ImagePath="canhhoatonthuong.jpg",
                    CategoryID = 1
                },
                new Music
                {
                    MusicID = 5,
                    MusicName = "Lily",
                    Information = "Ca sĩ: Alan Walker, K-391, Emelie Hollow; Sáng tác: Alan Walker, Lars Kristian Rosness, Magnus Bertelsen, K - 391, Didrik Handlykken, Marcus Arnbekk; Album: Different World; Năm phát hành: 2018",
                    ImagePath="lily.jpg",
                    CategoryID = 4
                },
                new Music
                {
                    MusicID = 6,
                    MusicName = "Một Triệu Khả Năng (一百万个可能)",
                    Information = "Ca sĩ: Christine Welch; Sáng tác: Christine Welch, Skot Suyama; Album: Một Triệu Khả Năng(一百万个可能); Năm phát hành: 2014",
                    ImagePath="mottrieukhanang.jpg",
                    CategoryID = 2
                },
                new Music
                {
                    MusicID = 7,
                    MusicName = "Lạnh Lẽo (凉凉)",
                    Information = "Ca sĩ: Trương Bích Thần, Dương Tông Vỹ; Sáng tác: Đàm Toàn, Lưu Sướng; Album: Tam Sinh Tam Thế Thập Lý Đào Hoa(Bản Truyền Hình) OST(三生三世十里桃花 电视剧原声带); Năm phát hành: 2017",
                    ImagePath="lanhleo.jpg",
                    CategoryID = 2
                },
                new Music
                {
                    MusicID = 8,
                    MusicName = "That Girl",
                    Information = "Ca sĩ: Olly Murs; Sáng tác: Olly Murs, Steve Robson, Clarence Coffee Jr, Ina Wroldsen; Album: 24 HRS(Deluxe); Năm phát hành: 2016",
                    ImagePath="thatgirl.jpg",
                    CategoryID = 4
                },
                new Music
                {
                    MusicID = 9,
                    MusicName = "Điều Anh Biết",
                    Information = "Ca sĩ: Chi Dân; Sáng tác: Ân Nhi; Album: Điều Anh Biết(Single); Năm phát hành: 2016",
                    ImagePath="dieuanhbiet.jpg",
                    CategoryID = 3
                }
            };
            return musics;
        }
    }
}