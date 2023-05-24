using ApplicationServices.Mapping.Profiles;

using AutoMapper;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationServices.Tests.Mapping.Profiles
{
    [TestClass]
    public sealed class MapperConfigurationTests : MappingTestBase
    {
        [TestMethod]
        public void AssertConfigurationIsValid()
        {
            // Arrange
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(EntityDbProfile)));

            // Act & Assert
            configuration.AssertConfigurationIsValid();
        }
    }
}
