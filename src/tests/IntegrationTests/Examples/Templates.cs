/*
order: 20
title: Templates
slug: templates

Shows how to list available video templates in your Synthesia workspace.
*/

namespace Synthesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListTemplates()
    {
        using var client = GetAuthenticatedClient();

        //// List all available video templates in your Synthesia STUDIO workspace.
        //// Templates define reusable video layouts with customizable variables.
        var response = await client.Templates.GetTemplatesAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Templates.Should().NotBeNull();
    }
}
