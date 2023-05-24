using ApplicationServices.Mapping.Profiles;

using AutoFixture;

using AutoMapper;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationServices.Tests.Mapping.Profiles
{
    [TestClass]
    public abstract class MappingTestBase
    {
        public IMapper Mapper { get; private set; }

        public IFixture FixtureService { get; private set; }

        [TestInitialize]
        public void Init()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(EntityDbProfile)));
            Mapper = configuration.CreateMapper();

            FixtureService = new Fixture();
        }
    }
}
