using Bogus;
using Freightways.UnitTest.Repositories.Mocks;
using FreightwaysApi.Model;
using FreightwaysApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freightways.UnitTest.Repositories
{
    public class ScanEventRepositoryTests
    {
        [Test]
        public async Task ScanEventRepository_Get_CallsExecuteAsyncWithCorrectParameters()
        {
            var scanEventRepository= new ScanEventRepository();
            var results = scanEventRepository.Get(x => x.EventId > 1).Take(3);

            Assert.That(results.Count, Is.EqualTo(3));
        }

        [Test]
        public async Task ScanEventRepository_Get_CallsExecuteAsyncReturnEmpty()
        {
            var scanEventRepository = new ScanEventRepository();
            var results = scanEventRepository.Get(x => x.EventId > 100000).Take(1);

            Assert.That(results.Count, Is.EqualTo(0));
        }
    }
}
