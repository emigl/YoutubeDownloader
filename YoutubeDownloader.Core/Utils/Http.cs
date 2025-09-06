using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;

namespace YoutubeDownloader.Core.Utils;

public static class Http
{
   public static class Http
{
    public static HttpClient Client { get; } = Create();

    private static HttpClient Create()
    {
        HttpClient Result = new();
        Result.DefaultRequestHeaders.TryAddWithoutValidation(
            "User-Agent",
            "com.google.ios.youtube/19.45.4 (iPhone16,2; U; CPU iOS 18_1_0 like Mac OS X; US)"
            // same as the one used in YoutubeExplode, as of right now
        );
        return Result;
    }
}
}
