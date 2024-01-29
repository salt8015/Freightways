using Bogus;
using Freightways.UnitTest.Repositories.Mocks;
using FreightwaysApi.Model;
using FreightwaysApi.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Freightways.UnitTest.Services
{
    public class ScanEventServiceTests
    {
        private ScanEventRepositoryMock _scanEventRepositoryMock;
        private ScanEventService _scanEventService;

        [SetUp]
        public void Setup()
        {
            _scanEventRepositoryMock =  new ScanEventRepositoryMock();
            _scanEventRepositoryMock.ScanEvents.AddRange(GetFakeScanEvent().Generate(5));
            _scanEventService = new ScanEventService(_scanEventRepositoryMock.Mock.Object);
        }

        [Test]
        public async Task ScanEventService_Get_CallsExecuteAsyncWithCorrectParameters()
        {
            var results = (await _scanEventService.Get(1, 5)).ToList();
            Assert.That(results.Count, Is.EqualTo(5));
            _scanEventRepositoryMock.Mock.Verify(
                m => m.Get(It.IsAny<System.Linq.Expressions.Expression<Func<ScanEvent, bool>>>()), Times.Once);
        }

        private static Faker<ScanEvent> GetFakeScanEvent()
        {
            var Ids = 1;
            return new Faker<ScanEvent>()
                .RuleFor(p => p.EventId, f => Ids++);
        }
    }
}
