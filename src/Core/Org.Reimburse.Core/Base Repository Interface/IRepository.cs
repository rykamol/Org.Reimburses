namespace Org.Reimburse.Core.Base_Repository_Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
        void GetAll();
        void GetByID(string id);
    }
}
