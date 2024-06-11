using Microsoft.EntityFrameworkCore;
using DemoWebApp.Application.Wrappers;
using DemoWebApp.Domain.Common;
using DemoWebApp.Persistence.Context;

namespace DemoWebApp.Persistence.Repositories
{
    public class GenericRepository<T, PKey> : IGenericRepositoryAsync<T> where T : BaseEntity<PKey>
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse<List<T>>> GetAllAsync()
        {
            BaseResponse<List<T>> ri = new BaseResponse<List<T>>();

            ri.Data = await _context.Set<T>().ToListAsync();

            return ri;
        }
    }
}
