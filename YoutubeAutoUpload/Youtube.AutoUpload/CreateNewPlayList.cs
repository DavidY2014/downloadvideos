﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Youtube.AutoUpload
{
    public class CreateNewPlayList
    {
        public async Task Run()
        {
            //UserCredential credential;
            //using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            //{
            //    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
            //        GoogleClientSecrets.Load(stream).Secrets,
            //        // This OAuth 2.0 access scope allows for full read/write access to the
            //        // authenticated user's account.
            //        new[] { YouTubeService.Scope.Youtube },
            //        "user",
            //        CancellationToken.None,
            //        new FileDataStore(this.GetType().ToString())
            //    );
            //}

            //var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            //{
            //    HttpClientInitializer = credential,
            //    ApplicationName = this.GetType().ToString()
            //});

            //// Create a new, private playlist in the authorized user's channel.
            //var newPlaylist = new Playlist();
            //newPlaylist.Snippet = new PlaylistSnippet();
            //newPlaylist.Snippet.Title = "Test Playlist";
            //newPlaylist.Snippet.Description = "A playlist created with the YouTube API v3";
            //newPlaylist.Status = new PlaylistStatus();
            //newPlaylist.Status.PrivacyStatus = "public";
            //newPlaylist = await youtubeService.Playlists.Insert(newPlaylist, "snippet,status").ExecuteAsync();

            //// Add a video to the newly created playlist.
            //var newPlaylistItem = new PlaylistItem();
            //newPlaylistItem.Snippet = new PlaylistItemSnippet();
            //newPlaylistItem.Snippet.PlaylistId = newPlaylist.Id;
            //newPlaylistItem.Snippet.ResourceId = new ResourceId();
            //newPlaylistItem.Snippet.ResourceId.Kind = "youtube#video";
            //newPlaylistItem.Snippet.ResourceId.VideoId = "GNRMeaz6QRI";
            //newPlaylistItem = await youtubeService.PlaylistItems.Insert(newPlaylistItem, "snippet").ExecuteAsync();

            //Console.WriteLine("Playlist item id {0} was added to playlist id {1}.", newPlaylistItem.Id, newPlaylist.Id);
        }
    }
}
