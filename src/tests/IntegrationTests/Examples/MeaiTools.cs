/*
order: 60
title: MEAI Tools
slug: meai-tools

Shows how to use Synthesia AIFunction tools with any IChatClient.
*/

namespace Synthesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsCreateVideoTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a video creation tool from the Synthesia client for use with any IChatClient.
        var tool = client.AsCreateVideoTool(
            avatarId: "anna_costume1_cameraA",
            background: "off_white",
            test: true);
        tool.Name.Should().Be("CreateVideo");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsCreateVideoFromTemplateTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a template-based video creation tool for producing videos from predefined templates.
        var tool = client.AsCreateVideoFromTemplateTool(test: true);
        tool.Name.Should().Be("CreateVideoFromTemplate");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListTemplatesTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for listing available video templates in your workspace.
        var tool = client.AsListTemplatesTool(limit: 10);
        tool.Name.Should().Be("ListTemplates");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetVideoTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for checking video generation status and retrieving download URLs.
        var tool = client.AsGetVideoTool();
        tool.Name.Should().Be("GetVideo");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListVideosTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for listing videos in the Synthesia workspace.
        var tool = client.AsListVideosTool(limit: 10);
        tool.Name.Should().Be("ListVideos");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsDeleteVideoTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for deleting videos from the Synthesia workspace.
        var tool = client.AsDeleteVideoTool();
        tool.Name.Should().Be("DeleteVideo");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CombineAllTools()
    {
        using var client = GetAuthenticatedClient();

        //// Combine all tools for full video generation and management capabilities.
        var tools = new[]
        {
            client.AsCreateVideoTool(),
            client.AsCreateVideoFromTemplateTool(),
            client.AsListTemplatesTool(),
            client.AsGetVideoTool(),
            client.AsListVideosTool(),
            client.AsDeleteVideoTool(),
        };

        tools.Should().HaveCount(6);
        tools.Select(t => t.Name).Should().OnlyHaveUniqueItems();
    }
}
