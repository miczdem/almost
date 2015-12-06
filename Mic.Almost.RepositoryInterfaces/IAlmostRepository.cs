namespace Mic.Almost.RepositoryInterfaces
{
    public interface IAlmostRepository
    {
        IAlmostDbContext Context { get; }
    }
}