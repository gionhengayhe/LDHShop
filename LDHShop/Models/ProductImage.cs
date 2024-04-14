namespace LDHShop.Models
{
	public class HangHoaImage
	{
		public int Id { get; set; }
		public string Url { get; set; }
		public int MaHH { get; set; }
		public HangHoa? HangHoa { get; set; }
	}
}
