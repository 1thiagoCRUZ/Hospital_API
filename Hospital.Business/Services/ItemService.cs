using SistemaGerenciamentoAlmoxarifado.Hospital.Business.DTOs;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Entities;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Interfaces.IRepositories;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Interfaces.IServices;

namespace SistemaGerenciamentoAlmoxarifado.Hospital.Business.Services
{
    public class ItemService: IItemService
    {
        private readonly IItemRepository _repo;

        public ItemService(IItemRepository repo)
        {
            _repo = repo;
        }

        public void Create(ItemDTO dto)
        {
            if (dto.Quantity < 0)
            {
                throw new Exception("The quantity cannot be negative");
            }
            _repo.Create(dto);
        }

        public void Delete(int Id)
        {
            var item = _repo.FindById(Id);
            if (item == null) throw new Exception("Item not found");
            _repo.Delete(Id);
        }

        public List<Item> FindAll()
        {
            return _repo.FindAll();
        }

        public Item FindById(int Id)
        {
            return _repo.FindById(Id);
        }

        public void UpdateAddItem(int Id, int Quantity)
        {
            var item = _repo.FindById(Id);
            if(item == null)
            {
                throw new Exception("Item not found");
            }
            if (item.Quantity < 0)
            {
                throw new Exception("The quantity cannot be negative");
            }
            _repo.UpdateAddItem(item.Id, Quantity);
        }

        public void UpdateRemoveItem(int Id, int Quantity)
        {
            var item = _repo.FindById(Id);
            if (item == null)
            {
                throw new Exception("Item not found");
            }
            if (item.Quantity < 0)
            {
                throw new Exception("The quantity cannot be negative");
            }
            _repo.UpdateRemoveItem(item.Id, Quantity);
        }

        public void Update(int Id, ItemDTO dto)
        {
            var item = _repo.FindById(Id);
            if (item == null)
            {
                throw new Exception("Item not found");
            }
            if (item.Quantity < 0)
            {
                throw new Exception("The quantity cannot be negative");
            }
            var itemDto = new ItemDTO
            {
                Name = dto.Name,
                Description = dto.Description,
                Quantity = dto.Quantity
            };
            _repo.Update(item.Id, itemDto);
        }

        public Item FindByDescription(string Description)
        {
            return _repo.FindByDescription(Description);
        }

    }
}
