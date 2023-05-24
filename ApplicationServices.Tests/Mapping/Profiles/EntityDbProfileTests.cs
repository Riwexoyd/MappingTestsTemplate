using ApplicationServices.Models;
using ApplicationServices.Tests.Mapping.Validators;

using AutoFixture;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Models;

namespace ApplicationServices.Tests.Mapping.Profiles
{
    [TestClass]
    public sealed class EntityDbProfileTests : MappingTestBase
    {
        [TestMethod]
        public void Map_FromDbToDto_MustBeCorrect()
        {
            // Arrange
            var entityDb = FixtureService.Create<EntityDb>();

            // Act
            var entityDto = Mapper.Map<EntityDto>(entityDb);

            // Assert
            EntityDbValidator.AssertAreEqual(entityDb, entityDto);
        }
    }
}
