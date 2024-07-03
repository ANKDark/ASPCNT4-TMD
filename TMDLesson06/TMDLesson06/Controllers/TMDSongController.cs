using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDLesson06.Models;

namespace TMDLesson06.Controllers
{
    public class TMDSongController : Controller
    {
        private static List<TMDSong> tmdSongs = new List<TMDSong>()
        {
            new TMDSong{Id = 2210900014, TMDTitle = "Trần Minh Đức", TMDAuther = "K22CNT4", TMDArtist = "NTU", TMDYearRelease = 2020 },
            new TMDSong{Id = 1, TMDTitle = "Trần Minh Đức", TMDAuther = "K22CNT4", TMDArtist = "NTU", TMDYearRelease = 2020 },
        };
        // GET: TMDSong
        /// <summary>
        /// Hiển thị danh sách bài hát
        /// Auther: Trần Minh Đức
        /// </summary>
        /// <returns></returns>
        public ActionResult TMDIndex()
        {
            return View(tmdSongs);
        }
        //GET: TMDCreate
        /// <summary>
        /// Form thêm mới bài hát
        /// Auther: Trần Minh Đức
        /// </summary>
        /// <returns></returns>
        public ActionResult TMDCreate()
        {
            var tmdsong = new TMDSong();
            return View();
        }
    }
}