using CityApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CityApp.ViewModels
{
    public class TelevisionViewModel : ViewModelBase
    {
        private const string apiKey = "AIzaSyCut9sVr4_vkx2Z4e4y5WyT-XNIpMxDAUc";
        private const string playListId = "UUNFZx8xDMOfwcwe4WJaP7DA";
        private const int maxResults = 20;
        private const string part = "snippet";
        private string apiUrlForPlaylist =
            "https://www.googleapis.com/youtube/v3/playlistItems?" +
            $"part={part}&maxResults={maxResults}&playlistId={playListId}&key={apiKey}";

        public ObservableCollection<YoutubeItem> YoutubeItems { get; private set; }
        public ICommand LoadDataCommand { private set; get; }

        public TelevisionViewModel()
        {
            Title = "ТВР+";
            YoutubeItems = new ObservableCollection<YoutubeItem>();
            LoadDataCommand = new Command(async () => await LoadData());
            LoadData();
        }

        private async Task LoadData()
        {
            if (IsLoading)
                return;
            IsLoading = true;
            YoutubeItems.Clear();

            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(apiUrlForPlaylist);

            try
            {
                JObject jsonResponse = JsonConvert.DeserializeObject<dynamic>(json);
                var items = jsonResponse.Value<JArray>("items");
                foreach (var item in items)
                {
                    var snippet = item.Value<JObject>("snippet");
                    var youtubeItem = new YoutubeItem
                    {
                        Title = snippet.Value<string>("title"),
                        Description = snippet.Value<string>("description"),
                        ChannelTitle = snippet.Value<string>("channelTitle"),
                        PublishedAt = snippet.Value<DateTime>("publishedAt"),
                        VideoId = snippet?.Value<JObject>("resourceId")?.Value<string>("videoId"),
                        DefaultThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("default")?.Value<string>("url"),
                        MediumThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("medium")?.Value<string>("url"),
                        HighThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("high")?.Value<string>("url"),
                        StandardThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("standard")?.Value<string>("url"),
                        MaxResThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("maxres")?.Value<string>("url"),
                    };
                    YoutubeItems.Add(youtubeItem);
                }
            }
            catch
            {
                // todo: handle an exception
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
