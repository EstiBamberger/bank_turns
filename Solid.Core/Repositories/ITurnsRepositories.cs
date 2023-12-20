using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Enteties;

namespace Solid.Core.Repositories
{
    public interface ITurnsRepositories
    {
        List<Turn> GetTurns();

        Turn GetByStart(DateTime start);

        Turn AddTurn(Turn turn);

        Turn UpdateTurn(int id, Turn turn);

        void DeleteTurn(int id);
    }
}
