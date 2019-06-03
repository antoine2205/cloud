using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Models
{
    public interface IRailDelayRepository
    {
        Delay GetDelay(int id);
        IEnumerable<Delay> GetAllDelays();
        Delay Add(Delay delay);
        Delay Update(Delay delayChanges);
        Delay Delete(int id);
    }
}
