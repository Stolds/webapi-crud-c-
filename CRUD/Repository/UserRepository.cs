using CRUD.Data;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext context;
        public UserRepository(UserDbContext context)
        {
            this.context = context;
        }
        public void AddUser(User user)
        {
            context.Add(user);
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<User> SearchUser(int id)
        {
            return await context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> SearchUsers()
        {
            return await context.Users.ToListAsync();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}