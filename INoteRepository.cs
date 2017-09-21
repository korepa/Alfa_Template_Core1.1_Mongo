using Alfa_Template_Core11_Mongo.Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alfa_Template_Core11_Mongo
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetAllNotes();
        Task<Note> GetNote(string id);
        Task AddNote(Note item);
        Task<DeleteResult> RemoveNote(string id);
        Task<DeleteResult> RemoveAllNotes();
        // обновление содержания (body) записи
        Task<UpdateResult> UpdateNote(string id, string body);
        Task<ReplaceOneResult> UpdateNote(string id, Note item);
    }
}
