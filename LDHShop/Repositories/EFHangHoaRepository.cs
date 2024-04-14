using LDHShop.Models;
using Microsoft.EntityFrameworkCore;

namespace LDHShop.Repositories
{
	public class EFHangHoaRepository : IHangHoaRepository
	{
		private readonly ApplicationDbContext _context;
		public EFHangHoaRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<HangHoa>> GetAllAsync()
		{
			// return await _context.HangHoas.ToListAsync();
			return await _context.HangHoas
			.Include(p => p.MaLoai) // Include thông tin về Loai
			.ToListAsync();
		}
		public async Task<HangHoa> GetByIdAsync(int id)
		{
			// return await _context.HangHoas.FindAsync(id);
			// lấy thông tin kèm theo Loai
			return await _context.HangHoas.Include(p => p.MaLoai).FirstOrDefaultAsync(p => p.MaHh == id);
		}
		public async Task CreateAsync(HangHoa HangHoa)
		{
			_context.HangHoas.Add(HangHoa);
			await _context.SaveChangesAsync();
		}
		public async Task EditAsync(HangHoa HangHoa)
		{
			_context.HangHoas.Update(HangHoa);
			await _context.SaveChangesAsync();
		}
		public async Task DeleteAsync(int id)
		{
			var HangHoa = await _context.HangHoas.FindAsync(id);
			_context.HangHoas.Remove(HangHoa);
			await _context.SaveChangesAsync();
		}
}