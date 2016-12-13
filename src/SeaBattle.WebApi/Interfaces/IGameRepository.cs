using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaBattle.WebApi.Interfaces
{
    public interface IGameRepository
    {
        Guid Get();
        void Start(Guid gameID);
    }
}
