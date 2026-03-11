using SistemaGerenciamentoAlmoxarifado.Hospital.Business.DTOs;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Entities;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Interfaces.IRepositories;
using SistemaGerenciamentoAlmoxarifado.Hospital.Data.Contexts;
using System.Xml;

namespace SistemaGerenciamentoAlmoxarifado.Hospital.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _context;
        public ItemRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(ItemDTO dto)
        {
            var itemDto = new Item
            {
                Name = dto.Name,
                Description = dto.Description,
                Quantity = dto.Quantity
            };
            _context.Items.Add(itemDto);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var item = FindById(Id);
            if (item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }

        public List<Item> FindAll()
        {
            return _context.Items.ToList();
        }

        public Item FindById(int Id)
        {
            return _context.Items.FirstOrDefault(item => item.Id == Id);
        }
        

        public void UpdateAddItem(int Id, int Quantity)
        {
            var item = FindById(Id);
            if (item != null)
            {
                item.Quantity += Quantity;
                _context.Items.Update(item);
                _context.SaveChanges();
            }
        }

        public void UpdateRemoveItem(int Id, int Quantity)
        {
            var item = FindById(Id);
            if (item != null)
            {
                item.Quantity -= Quantity;
                _context.Items.Update(item);
                _context.SaveChanges();
            }
        }

        public void Update(int Id, ItemDTO dto)
        {
            var item = FindById(Id);
            if (item != null)
            {
                item.Name = dto.Name;
                item.Description = dto.Description;
                item.Quantity = dto.Quantity;
                _context.Items.Update(item);
                _context.SaveChanges();
            }
        }

        public Item FindByDescription(string Description)
        {
            return _context.Items.Select(item => item).Where(item => item.Description.Contains(Description)).First();
        }
    }
}
