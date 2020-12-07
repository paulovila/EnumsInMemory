using System.Linq;
using System.Threading.Tasks;
using DbModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repository.UnitTests
{
    [TestClass]
    public class StatusMapRepositoryUnitTests : TestRepositoryBase
    {
        [TestInitialize]
        public void Init()
        {
            using var context = new AmsContext(Options);
            context.StatusMapEvents.Add(new StatusMapEvent
            {
                StatusMap = new StatusMap(),
                Event = new Event(),
            });
            context.SaveChanges();
        }
        [TestMethod]
        public async Task GetForcingCastEnumTest()
        {
            var sut = new StatusMapRepository(new AmsContext(Options));
            var statuses = await sut.GetForcingCastEnum();
            Assert.IsTrue(statuses.Any());
        }
        [TestMethod]
        public async Task GetShouldNotFailTest()
        {
            var sut = new StatusMapRepository(new AmsContext(Options));
            var statuses = await sut.GetShouldNotFail();
            Assert.IsTrue(statuses.Any());
        }
    }
}