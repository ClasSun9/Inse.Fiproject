using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace Inse.Fiproject.Youtube
{
    public static class YoutubeConnection
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        private static UserCredential credential = null;
        private static YouTubeService service    = null;

        private static string identifier = null;

        private static bool isOpen = false;

        //---------------------------------------------------------------------
        //
        //  property
        //
        //---------------------------------------------------------------------

        public static bool IsOpen
        {
            get { return isOpen; }
        }

        public static YouTubeService Service
        {
            get { return service; }
        }

        public static string Identifier
        {
            get { return identifier; }
        }
        
        //---------------------------------------------------------------------
        //
        //  event
        //
        //---------------------------------------------------------------------



        //---------------------------------------------------------------------
        //
        //  function
        //
        //---------------------------------------------------------------------
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="secrets"></param>
        public static async Task Open(string identifier, string secrets)
        {
            if (string.IsNullOrEmpty(secrets))
            {
                return;
            }

            using (var stream = new FileStream(secrets, FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                    new[]
                    {
                        YouTubeService.Scope.Youtube,
                        YouTubeService.Scope.YoutubeForceSsl,
                        YouTubeService.Scope.Youtubepartner,
                        YouTubeService.Scope.YoutubepartnerChannelAudit,
                        YouTubeService.Scope.YoutubeReadonly
                    },
                    identifier,
                    CancellationToken.None);
                
                service = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName       = "Inse.Fiproject"
                });
            }

            if (credential != null && service != null)
            {
                isOpen = true;
            }

            YoutubeConnection.identifier = identifier;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static void Close()
        {
            
        }

        //---------------------------------------------------------------------
        //
        //  constructor
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        static YoutubeConnection()
        {

        }
    }
}
