using ApplicationServices.Models;
using ApplicationServices.Tests.Mapping.Validators;

using AutoFixture;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Models;

namespace ApplicationServices.Tests.Mapping.Profiles
{
    [TestClass]
    public sealed class InnerEntityDbProfileTests : MappingTestBase
    {
        [TestMethod]
        public void Map_FromDbToDto_MustBeCorrect()
        {
            // Arrange
            var entityDb = FixtureService.Create<InnerEntityDb>();

            // Act
            var entityDto = Mapper.Map<InnerEntityDto>(entityDb);

            // Assert
            InnerEntityDbValidator.AssertAreEqual(entityDb, entityDto);
        }
    }
}
