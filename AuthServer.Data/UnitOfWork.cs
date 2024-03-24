using AuthServer.Core.UnıtOfWork;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;

    public UnitOfWork(AppDbContext AppDbContext)
    {
        _context = AppDbContext;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}
