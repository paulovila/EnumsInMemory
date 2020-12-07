using System.Threading.Tasks;
using DbModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Repository
{

    public class StatusMapRepository 
    {
        private readonly AmsContext _context;
        public StatusMapRepository(AmsContext context) => _context = context;

        public Task<vStatusMap[]> GetForcingCastEnum() =>
            (from sme in _context.StatusMapEvents
                join sm in _context.StatusMaps on (int)sme.StatusMapId equals (int)sm.Id
                join e in _context.Events on sme.EventId equals e.Id
                select new vStatusMap
                {
                    StatusMapId = sm.Id,
                    StatusMapName = sm.Name,
                    EventId = e.Id,
                    EventName = e.Name,
                    EventDescription = e.Description,
                    DisplayOrder = e.DisplayOrder,
                    SecondUserAuthorisation = sm.SecondUserAuthorisation
                }).ToArrayAsync();


        public Task<vStatusMap[]> GetShouldNotFail() =>
            (from sme in _context.StatusMapEvents
                join sm in _context.StatusMaps on sme.StatusMapId equals sm.Id
                join e in _context.Events on sme.EventId equals e.Id
                select new vStatusMap
                {
                    StatusMapId = sm.Id,
                    StatusMapName = sm.Name,
                    EventId = e.Id,
                    EventName = e.Name,
                    EventDescription = e.Description,
                    DisplayOrder = e.DisplayOrder,
                    SecondUserAuthorisation = sm.SecondUserAuthorisation
                }).ToArrayAsync();
    }
}