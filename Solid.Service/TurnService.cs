using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Enteties;
using Solid.Core.Repositories;
using Solid.Core.Services;

namespace Solid.Service
{
    public class TurnService:ITurnsServices
    {
        private readonly ITurnsRepositories _turnRepositor;
        public TurnService(ITurnsRepositories turnRepositor)
        {
            _turnRepositor = turnRepositor;
        }

        public void AddTurn(Turn turn)
        {
            _turnRepositor.AddTurn(turn);
        }

        public void DeleteTurn(int id)
        {
            _turnRepositor.DeleteTurn(id);
        }

        public List<Turn> GetTurns()
        {
            return _turnRepositor.GetTurns();
        }

        public Turn GetByStart(DateTime start)
        {
            return _turnRepositor.GetByStart(start);
        }

        public void UpdateTurn(int id, Turn turn)
        {
            _turnRepositor.UpdateTurn(id, turn);
        }
    }
}
