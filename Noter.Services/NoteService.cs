using Noter.Data.Interfaces;

namespace Noter.Services
{
    public class NoteService
    {
        private INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;         
        }



    }
}