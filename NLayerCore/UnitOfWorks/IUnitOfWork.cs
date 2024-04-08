namespace NLayerCore.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();

        void Commit();
    }
}
