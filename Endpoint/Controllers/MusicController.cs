using Endpoint.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Endpoint.Controller
{
    public class MusicController : ApiController
    {
        List<MusicFile> files = new List<MusicFile>()
        {
            new MusicFile { Id = 1, Name = "Don't Stop Believing",},
            new MusicFile { Id = 2, Name = "Paralyzer",},
            new MusicFile { Id = 3, Name = "Viva La Vida",}
        };

        public IEnumerable<MusicFile> GetAllMusicFiles()
        {
            return files;
        }

        public IHttpActionResult GetMusicFile(int id)
        {
            var file = files.FirstOrDefault((p) => p.Id == id);
            if (file == null)
            {
                return NotFound();
            }
            return Ok(file);
        }

        public IHttpActionResult UpsertMusicFile(MusicFile file)
        {
            if (file == null)
            {
                return Content(HttpStatusCode.BadRequest, file);
            }

            files.Add(file);

            return Ok();
        }

    }
}
