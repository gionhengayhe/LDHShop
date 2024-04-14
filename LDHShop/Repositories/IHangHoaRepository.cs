using LDHShop.Models;

namespace LDHShop.Repositories
{
	public interface IHangHoaRepository
	{
		Task<IEnumerable<HangHoa>> GetAllAsync();
		Task<HangHoa> GetByIdAsync(int id);
		Task CreateAsync(HangHoa HangHoa);
		Task EditAsync(HangHoa HangHoa);
		Task DeleteAsync(int id);
	}
}
