/*
order: 50
title: Webhooks
slug: webhooks

Shows how to list webhooks configured in your Synthesia account.
*/

namespace Synthesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListWebhooks()
    {
        using var client = GetAuthenticatedClient();

        //// List all currently configured webhooks in your Synthesia account.
        //// Webhooks notify your application when video generation events occur.
        var response = await client.Webhooks.GetWebhooksAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Webhooks.Should().NotBeNull();
    }
}
