using FreightwaysApi.Model;

namespace FreightwaysApi.Services
{
    public interface IScanEventService
    {
        Task<IEnumerable<ScanEvent>> Get(int eventId, int limit);
    }
}
