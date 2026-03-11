using Microsoft.AspNetCore.Mvc;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.DTOs;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Entities;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Interfaces.IServices;

namespace SistemaGerenciamentoAlmoxarifado.Hospital.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _service;

        public ItemController(IItemService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] ItemDTO dto)
        {
            try
            {
                _service.Create(dto);
                return Ok("The item was created");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int Id)
        {
            try
            {
                _service.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update Quantity Item - Add")]
        public IActionResult UpdateAddItem([FromQuery] int Id, [FromBody] int Quantity)
        {
            try
            {
                _service.UpdateAddItem(Id, Quantity);
                return Ok("The item was updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update Quantity Item - Remove")]
        public IActionResult UpdateRemoveItem([FromQuery] int Id, [FromBody] int Quantity)
        {
            try
            {
                _service.UpdateRemoveItem(Id, Quantity);
                return Ok("The item was updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update Item")]
        public IActionResult Update([FromQuery] int Id, [FromBody] ItemDTO dto)
        {
            try
            {
                _service.Update(Id, dto);
                return Ok("The item was updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult FindById(int Id)
        {
            try
            {
                Item itemResponse = _service.FindById(Id);
                return Ok(itemResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FindAll")]
        public IActionResult FindAll()
        {
            try
            {
                List<Item> itemResponse = _service.FindAll();
                return Ok(itemResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FindByDescription")]
        public IActionResult FindByDescription(string Description)
        {
            try
            {
                Item itemResponse = _service.FindByDescription(Description);
                return Ok(itemResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
