/*
order: 30
title: Videos
slug: videos

Shows how to list videos in your Synthesia workspace.
*/

namespace Synthesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListVideos()
    {
        using var client = GetAuthenticatedClient();

        //// List all videos created via the API or STUDIO in your workspace.
        //// Supports pagination with limit and offset parameters.
        var response = await client.Videos.GetVideosAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Videos.Should().NotBeNull();
    }
}
