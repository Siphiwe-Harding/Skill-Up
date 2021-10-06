using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song(){id = 0, title = "Willow", language = "English"},
            new Song(){id = 1, title = "After Glow", language = "English"}
        };

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songs;
        }

        [HttpPost]
        public void Post([FromBody]Song  song)
        {
            songs.Add(song);
        }
    }
}
