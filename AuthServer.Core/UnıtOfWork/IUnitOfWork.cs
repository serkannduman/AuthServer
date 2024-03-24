namespace AuthServer.Core.UnıtOfWork;

public interface IUnitOfWork
{
    Task CommitAsync();
    void Commit();
}
