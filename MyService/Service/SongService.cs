using MyService.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using T1904EHelloUWP.Entity;

namespace MyService.Service
{
   public class SongService
    {
        public async Task<Song> CreateSong(Song song)
        {
            var songObj = JsonConvert.SerializeObject(song);
            var requestData = new StringContent(songObj, Encoding.UTF8, ApiConfig.MediaType);
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic KlAjiB9QyN9jsmfzyMvQsg7lodQMR4hao1X070JFEms5gCs8KO4cKdh20KuRFycZ");
            var httpResponseMessage = await httpClient.PostAsync(new Uri(ApiConfig.CreateSongApi), requestData);
            if (httpResponseMessage.StatusCode != HttpStatusCode.Created)
            {
                return null;
            }
            var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Song>(responseContent);
        }
    }
}
