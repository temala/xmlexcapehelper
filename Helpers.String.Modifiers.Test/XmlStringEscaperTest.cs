using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.String.Modifiers.Test
{
    [TestClass]
    public class XmlStringEscaperTest
    {
        [TestMethod]
        [DeploymentItem(@"XmlEscaperFiles\FileToEscape.xml")]
        [DeploymentItem(@"XmlEscaperFiles\ExpectedResult.txt")]
        public void Process_shouldEscapeGivenString()
        {
            // Arrange
            var originalString = File.ReadAllText(@"XmlEscaperFiles/FileToEscape.xml");
            var expectedString = File.ReadAllText(@"XmlEscaperFiles/ExpectedResult.txt");
            var modifier = XmlStringEscaper.Instance;
            // Act
            var result =modifier.Process(originalString);
            // Assert
            result.Should().Be(expectedString);
            // result.Should().Be()
        }
    }
}