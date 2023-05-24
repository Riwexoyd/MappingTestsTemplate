using ApplicationServices.Models;
using ApplicationServices.Tests.Mapping.Validators;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Models;

using System;
using System.Linq;

namespace ApplicationServices.Tests.Mapping.Profiles
{
    [TestClass]
    public sealed class InnerEntityTypeProfileTests : MappingTestBase
    {
        [TestMethod]
        public void Map_FromDbToDto_MustBeCorrect()
        {
            // Arrange
            foreach (var innerEntityType in Enum.GetValues<InnerEntityType>())
            {
                // Act
                var innerEntityDtoType = Mapper.Map<InnerEntityDtoType>(innerEntityType);

                // Assert
                InnerEntityTypeValidator.AssertAreEqual(innerEntityType, innerEntityDtoType);
            }
        }

        [TestMethod]
        public void Map_ForInvalidEnumValue_MustThrowException()
        {
            // Arrange
            InnerEntityType innerEntityType = Enum.GetValues<InnerEntityType>().Max() + 1;

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Mapper.Map<InnerEntityDtoType>(innerEntityType));
        }
    }
}
