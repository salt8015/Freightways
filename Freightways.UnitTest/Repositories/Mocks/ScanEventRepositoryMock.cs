using FreightwaysApi.Model;
using FreightwaysApi.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freightways.UnitTest.Repositories.Mocks
{
    internal class ScanEventRepositoryMock
    {
        public Mock<IRepository<ScanEvent>> Mock { get; } = new Mock<IRepository<ScanEvent>>();
        public List<ScanEvent> ScanEvents { get; set; } = new List<ScanEvent>();

        public ScanEventRepositoryMock()
        {
            Mock.Setup(p => p.Get(It.IsAny<System.Linq.Expressions.Expression<Func<ScanEvent, bool>>>())).Returns(() => ScanEvents);
        }
    }
}
