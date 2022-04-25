using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.String.Modifiers.Test
{
    [TestClass]
    public class XmlIdentationManagerTest
    {
        [TestMethod]
        [DeploymentItem(@"XmlIdentationFiles\FileToIdent.xml")]
        [DeploymentItem(@"XmlIdentationFiles\ExpectedResult.txt")]
        public void Process_shouldIdentGivenString()
        {
            // Arrange
            var originalString = File.ReadAllText(@"XmlIdentationFiles/FileToIdent.xml");
            var expectedString = File.ReadAllText(@"XmlIdentationFiles/ExpectedResult.txt");
            
            var modifier = XmlIdentationManager.Create();
            // Act
            var result =modifier.Process(originalString);
            // Assert
            result.Should().Be(expectedString);
        }
    }
}