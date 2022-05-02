using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tiger_Tix.Web.Models;

namespace Tiger_Tix.Web.Services
{
    public class EventRepository : DbContext, IEventRepository
    {
        public DbSet<EventModel> _Events { get; set; }
        private readonly IConfiguration _configuration;
        
        public EventRepository(IConfiguration config)
        {
            _configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connection = _configuration["ConnectionString:DefaultConnection"];
            optionsBuilder.UseSqlServer(connection);
        }
        public List<EventModel> Events()
        {
            return (from e in _Events select e).ToList();
        }
        
        public void AddEvent(EventModel eventInfo)
        {
            _Events.Add(eventInfo);
            SaveChanges();
        }
    }
}