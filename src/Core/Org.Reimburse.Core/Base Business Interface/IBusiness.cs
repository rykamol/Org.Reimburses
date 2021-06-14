namespace Org.Reimburse.Core.Base_Business_Interface
{
    public interface IBusiness<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
        void GetAll();
        void GetByID(string id);
    }
}
