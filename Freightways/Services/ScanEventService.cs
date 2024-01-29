using FreightwaysApi.Model;
using FreightwaysApi.Repositories;

namespace FreightwaysApi.Services
{
    public class ScanEventService : IScanEventService
    {
        private readonly IRepository<ScanEvent> _scanEventRepository;

        public ScanEventService(IRepository<ScanEvent> scanEventRepository)
        {
            if(scanEventRepository == null)
            {
                throw new ArgumentException("scanEventRepository");
            }
            _scanEventRepository = scanEventRepository;
        }

        public async Task<IEnumerable<ScanEvent>> Get(int eventId, int limit)
        {
            return _scanEventRepository.Get(x => x.EventId >= eventId).Take(limit);
        }
    }
}
