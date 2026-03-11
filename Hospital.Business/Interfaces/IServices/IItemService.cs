using SistemaGerenciamentoAlmoxarifado.Hospital.Business.DTOs;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Entities;

namespace SistemaGerenciamentoAlmoxarifado.Hospital.Business.Interfaces.IServices
{
    public interface IItemService
    {
        public Item FindById(int Id);
        public List<Item> FindAll();
        public void Create(ItemDTO dto);
        public void UpdateAddItem(int Id, int Quantity);
        public void UpdateRemoveItem(int Id, int Quantity);
        public void Delete(int Id);
        public void Update(int Id, ItemDTO dto);
        public Item FindByDescription(string Description);
    }
}
