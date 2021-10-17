using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Noter.Domain;
using Notes.Domain.Interfaces;

namespace Noter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotesController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult GetNote(int id)
        {
            var note = _unitOfWork.Notes.GetById(id);

            return Ok(note);
        }

        [HttpPost]
        public IActionResult AddNote(Note note)
        {
            _unitOfWork.Notes.Add(note);
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
