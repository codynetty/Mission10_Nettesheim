using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class EfBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _context;

        public EfBowlingRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }
        public IEnumerable<Bowler> Bowlers => _context.Bowlers.Include(x => x.Team).ToList();

        public IEnumerable<Team> Teams => _context.Teams;

    }
}
