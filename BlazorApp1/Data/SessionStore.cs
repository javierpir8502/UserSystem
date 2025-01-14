using Microsoft.AspNetCore.Session;

namespace BlazorApp1.Data
{
    public class SessionStore : ISessionStore
    {
        private readonly ApplicationDbContext _dbContext;

        public SessionStore(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ISession Create(string sessionKey, TimeSpan idleTimeout, TimeSpan ioTimeout, Func<bool> tryEstablishSession, bool isNewSessionKey)
        {
            throw new NotImplementedException();
        }

        // ... Implementación de los métodos SetData, GetData, Remove
    }

}
