/*
order: 55
title: Audit Logs
slug: audit-logs

Shows how to query audit log events for your workspace.
*/

namespace Synthesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetAuditLogEvents()
    {
        using var client = GetAuthenticatedClient();

        //// Query paginated audit log events for a workspace.
        //// Supports filtering by date range, actions, actor IDs, and target ID.
        //// Exactly one of workspaceId or organizationId must be provided.
        var response = await client.AuditLogs.GetAuditLogEventsAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Events.Should().NotBeNull();
    }
}
