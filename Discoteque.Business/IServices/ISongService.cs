using System;
using Discoteque.Data.Models;

namespace Discoteque.Business.IServices
{
    public interface ISongService
    {
        Task<IEnumerable<Song>> GetSongsAsync();
        Task<Song> GetById(int id);
        Task<Song> CreateSong(Song song);
        Task<Song> UpdateSong(Song song);
    }
}