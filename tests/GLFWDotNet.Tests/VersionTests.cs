using Xunit;
using static GLFWDotNet.GLFW;

namespace GLFWDotNet.Tests
{
    public class VersionTests : GLFWTests
    {
        [Fact]
        public void GlfwGetVersionStringShouldStartWithResultsOfGlfwGetVersion()
        {
            glfwGetVersion(out int major, out int minor, out int revision);
            var versionString = glfwGetVersionString();

            Assert.StartsWith($"{major}.{minor}.{revision}", versionString);
        }
    }
}
