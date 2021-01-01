namespace MiniGigApi.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MiniGigApi.Entities;

    public interface IGigService
    {
        Task<IEnumerable<Gig>> GetGigs(int page, int pageSize);

        Task<IEnumerable<Gig>> GetGigs();

        Task<Gig> GetGig(int id);

        Task CreateGig(Gig gig);

        Task UpdateGig(Gig gig);

        Task DeleteGig(int gigId);
    }
}
