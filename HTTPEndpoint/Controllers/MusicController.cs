using PocketMusic.Music.MusicManager;
using PocketMusic.Storage.DataStorage.Models;
using PocketMusic.Storage.StaticStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PocketMusic.Endpoint.HTTPEndpoint.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MusicController : ApiController
    {
        [Route("api/music")]
        [HttpGet]
        public async Task<IEnumerable<MusicFile>> GetAllMusicFiles()
        {
            return await TemporaryStorage.GetAllMusicFiles();
        }

        [Route("api/music/{id}")]
        [HttpGet]
        public async Task<MusicFile> GetMusicFile(int id)
        {
            return await TemporaryStorage.GetMusicFile(id);
        }

        [Route("api/music/{id}")]
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteMusicFile(int id)
        {
            var result = await TemporaryStorage.DeleteMusicFile(id);

            if (!result)
            {
                return Content(HttpStatusCode.BadRequest, id);
            }

            return Ok();
        }


        [Route("api/music")]
        [HttpPost]
        public async Task<IHttpActionResult> UpsertMusicFile(MusicFile file)
        {
            if (file == null)
            {
                return Content(HttpStatusCode.BadRequest, file);
            }

            bool result = await TemporaryStorage.UpsertMusicFile(file);

            if (!result)
            {
                return Content(HttpStatusCode.BadRequest, file);
            }

            return Ok();
        }

    }
}
