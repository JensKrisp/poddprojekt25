namespace Models
{
    public interface IPodcastRepository
    {
        Task<Podcast> GetByIdAsync(string id);
        Task<List<Podcast>> GetAllAsync();
        Task AddAsync(Podcast podcast);
        Task UpdateAsync(Podcast podcast);
        Task DeleteAsync(string id);
    }
}
