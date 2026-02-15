namespace DirectorioEmpleadosMawi.Service
{
    public interface IRepositoryService<T>
    {
        
        Task <T> GetById(int id);
        void Update(T entity);

        Task<List<T>> GetAllAsync();
    }
}
