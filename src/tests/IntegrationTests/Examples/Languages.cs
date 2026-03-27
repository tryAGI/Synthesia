/*
order: 40
title: Languages
slug: languages

Shows how to get supported languages for video translations.
*/

namespace Synthesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetTranslationLanguages()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve the list of supported languages for video translations.
        //// Use these language codes when creating translated versions of your videos.
        var response = await client.Translations.GetTranslateLanguagesAsync();

        response.Should().NotBeNull();
    }
}
