using DungeonsAndYou.Services.DTOs;
using DungeonsAndYou.Services.Managers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DungeonsAndYou.API.Controllers.Api
{
    [Route("api/[controller]")]
    public class SheetsController : Controller
    {

        private SheetManager _sm;

        public SheetsController() => _sm = new SheetManager();

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<CharacterSheetDTO> Get()
        {
            var sheetDTOs = _sm.GetAll();
            return sheetDTOs;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public CharacterSheetDTO Get(int id)
        {
            var sheetDTO = _sm.Get(id);
            return sheetDTO;
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]CharacterSheetDTO sheetDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            if (_sm.Add(sheetDTO))
            {
                sheetDTO.Id = sheetDTO.Id;

                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]CharacterSheetDTO sheetDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var sheetInDB = _sm.Get(id);

            if (sheetInDB == null)
                return NotFound();            

            if (_sm.Update(id, sheetDTO))
            {
                return Ok();
            }
            return NotFound();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var sheetInDB = _sm.Get(id);

            if (sheetInDB == null)
                return NotFound();

            if (_sm.Remove(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
