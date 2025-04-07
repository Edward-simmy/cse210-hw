using System;

class Program
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

// ... (Other necessary using statements)

public class Program
{
    public static void Main(string[] args)
    {
        // Replace with your API key
        string apiKey = "YOUR_API_KEY";

        // Create a new YouTube service
        var youtubeService = new YouTubeService(new BaseClientService.Initializer
        {
            ApiKey = apiKey,
            ApplicationName = "YouTube Program"
        }
        );

        var searchRequest = youtubeService.Search.List("snippet");
        searchRequest.Q = "C# tutorial";

        searchRequest.MaxResults = 5; 

        var searchResult = searchRequest.Execute();

        // Print the video titles
        foreach (var video in searchResult.Items)
        {
            Console.WriteLine(video.Snippet.Title);
        }

        Console.ReadKey();
    }
}

    }
}