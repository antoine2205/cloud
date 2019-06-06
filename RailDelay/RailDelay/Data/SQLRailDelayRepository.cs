using RailDelay.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Models
{
    public class SQLRailDelayRepository : IRailDelayRepository
    {
        private readonly ApplicationDbContext context;

        public SQLRailDelayRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Delay Add(Delay delay)
        {

            context.Delay.Add(delay);
            context.SaveChanges();
            return delay;
        }

        public Delay Delete(int id)
        {
            Delay delay = context.Delay.Find(id);
            if(delay != null)
            {
                context.Delay.Remove(delay);
                context.SaveChanges();
            }
            return delay;
        }

        public IEnumerable<Delay> GetAllDelays()
        {
            return context.Delay;
        }

        public Delay GetDelay(int id)
        {
            return context.Delay.FirstOrDefault(e => e.ID == id);
        }

        public Delay Update(Delay delayChanges)
        {
            var delay = context.Delay.Attach(delayChanges);
            delay.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return delayChanges;
        }
    }
}
