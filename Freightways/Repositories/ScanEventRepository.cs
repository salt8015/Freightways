using FreightwaysApi.Model;

namespace FreightwaysApi.Repositories
{
    public class ScanEventRepository : IRepository<ScanEvent>
    {
        protected IEnumerable<ScanEvent> ScanEvents
        {
            get
            {
                return new ScanEvent[]
                {
                    new ScanEvent
                    {
                        EventId = 83269,
                        ParcelId = 5002,
                        Type = "PICKUP",
                        CreatedDateTimeUtc = DateTime.UtcNow,
                        StatusCode = "",
                        Device = new Device
                        {
                            DeviceTransactionIdId = 83269,
                            DeviceId = 103
                        },
                        User = new User
                        {
                            UserId = "NC1001",
                            CarrierId = "NC",
                            RunId = "100"
                        }
                    },
                    new ScanEvent
                    {
                        EventId = 83270,
                        ParcelId = 5002,
                        Type = "INDEPOT",
                        CreatedDateTimeUtc = DateTime.UtcNow,
                        StatusCode = "",
                        Device = new Device
                        {
                            DeviceTransactionIdId = 83270,
                            DeviceId = 103
                        },
                        User = new User
                        {
                            UserId = "NC1001",
                            CarrierId = "NC",
                            RunId = "100"
                        }
                    },
                    new ScanEvent
                    {
                        EventId = 83271,
                        ParcelId = 5002,
                        Type = "DELIVERY",
                        CreatedDateTimeUtc = DateTime.UtcNow,
                        StatusCode = "",
                        Device = new Device
                        {
                            DeviceTransactionIdId = 83271,
                            DeviceId = 103
                        },
                        User = new User
                        {
                            UserId = "NC1001",
                            CarrierId = "NC",
                            RunId = "100"
                        }
                    },
                };
            }
        }
        public IEnumerable<ScanEvent> Get(System.Linq.Expressions.Expression<Func<ScanEvent, bool>> predicate)
        {
            return ScanEvents.AsQueryable().Where(predicate);
        }
    }
}
