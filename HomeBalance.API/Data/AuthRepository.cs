using HomeBalance.API.Model;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HomeBalance.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext context;

        public AuthRepository(DataContext context)
        {
            this.context = context;
        }
        public async Task<User> Login(string username, string password)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Username == username);

            if (user == null)
                return null;

            if (!PaswordsOK(password, user.PasswordHash, user.PasswordKey))
                return null;
            return user;
        }

        private bool PaswordsOK(string password, byte[] passwordHash, byte[] passwordKey)
        {
            using (var hmc = new System.Security.Cryptography.HMACSHA512(passwordKey))
            {
                var passwH = hmc.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < passwordHash.Length ;i++)
                {
                    if (passwordHash[i] != passwH[i])
                    return false;
                }                
            }           
            return true;
        }

        public async Task<User> Register(User user, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordKey);

            user.PasswordHash = passwordHash;
            user.PasswordKey = passwordKey;
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordKey)
        {
            using (var hmc = new System.Security.Cryptography.HMACSHA512())
            {
                passwordHash = hmc.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                passwordKey = hmc.Key;
            }     
        }

        public async Task<bool> UserExists(string username)
        {
            if (await context.Users.AnyAsync(x=> x.Username == username))
                return true;
            return false;
        }       
    }
}
