using Domain.Entities;
using Domain.Repositories;
using Infra.DatabaseConfig;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class SolicitacaoRepository : ISolicitacaoRepository
    {
        private readonly IMongoCollection<Solicitacao> _collection;

        public SolicitacaoRepository(IDatabaseConfig databaseConfig)
        {
            var connectionString = databaseConfig.ConnectionString.Replace("user", databaseConfig.User).Replace("password", databaseConfig.Password);
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);
            _collection = database.GetCollection<Solicitacao>(databaseConfig.CollectionName);
        }

        public async Task SaveSolicitacao(Solicitacao solicitacaoObj)
        {
            await _collection.InsertOneAsync(solicitacaoObj);
        }

        public async Task<List<Solicitacao>> GetAllSolicitacoes()
        {
            return _collection.Find(x => true).ToList();
        }

        public async Task<Solicitacao> GetSolicitacaoById(string id)
        {
            return await _collection.Find(x => x.Id.ToString() == id).FirstOrDefaultAsync();
        }
    }
}
