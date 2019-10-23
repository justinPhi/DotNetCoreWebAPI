using System;
using System.Threading.Tasks;
using WordsAreBomb.API.Models;

namespace WordsAreBomb.API.Data
{
    public class AuthRespository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRespository(DataContext context)
        {
            _context = context;
        }

        
        public Task<User> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512();
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}