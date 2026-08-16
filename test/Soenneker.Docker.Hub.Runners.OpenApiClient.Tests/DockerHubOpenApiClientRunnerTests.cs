using Soenneker.Tests.HostedUnit;

namespace Soenneker.Docker.Hub.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DockerHubOpenApiClientRunnerTests : HostedUnitTest
{
    public DockerHubOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
