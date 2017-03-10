using PocketMusic.Music.MusicManager;
using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PocketMusic.Endpoint.HTTPEndpoint.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MusicController : ApiController
    {
        private IMusicManager _musicManager;

        public MusicController(IMusicManager musicManager)
        {
            if (musicManager == null)
            {
                throw new ArgumentNullException(nameof(musicManager));
            }
            _musicManager = musicManager;
        }

        [Route("api/music/")]
        [HttpGet]
        public async Task<IEnumerable<MusicFile>> GetAllMusicFiles()
        {
            return await _musicManager.GetAllMusicFiles(null);
        }

        [Route("api/music/{id}")]
        [HttpGet]
        public async Task<MusicFile> GetMusicFile(Guid id)
        {
            return await _musicManager.GetMusicFile(id);
        }

        [Route("api/music/{id}")]
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteMusicFile(Guid id)
        {
            var result = await _musicManager.DeleteMusicFile(id);

            if (!result)
            {
                return Content(HttpStatusCode.BadRequest, id);
            }

            return Ok();
        }


        [Route("api/music/{name}")]
        [HttpPost]
        public async Task<MusicFile> CreateMusic(string name)
        {
            try
            {
                HttpRequestMessage request = this.Request;
                if (!request.Content.IsMimeMultipartContent())
                {
                    throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
                }

                var provider = new MultipartFormDataStreamProvider("C:\\Temp");

                var multipartUploadResult = await Request.Content.ReadAsMultipartAsync(provider);

                MusicFile file = new MusicFile(name);

                foreach (var datum in multipartUploadResult.FileData)
                {
                    var layer = new LayerInfo(datum.Headers.ContentDisposition.FileName, "", false);
                    layer.Url = datum.LocalFileName;
                    file.Layers.Add(datum.Headers.ContentDisposition.FileName, layer);
                }

                var result = await _musicManager.UpsertMusicFile(file);

                return file;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
