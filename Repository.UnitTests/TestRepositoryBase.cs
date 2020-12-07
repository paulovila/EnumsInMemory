using System;
using DbModel;
using Microsoft.EntityFrameworkCore;

namespace Repository.UnitTests
{
    public abstract class TestRepositoryBase
    {
        protected DbContextOptions<AmsContext> Options { get; }

        protected TestRepositoryBase()
        {
            Options = new DbContextOptionsBuilder<AmsContext>()
                .UseInMemoryDatabase(DateTime.Now.Ticks.ToString())
                .EnableSensitiveDataLogging()
                .Options;
        }
    }
}