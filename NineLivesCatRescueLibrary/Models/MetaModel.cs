using System;
namespace NineLivesCatRescueLibrary.Models
{
	public class MetaModel
	{
		public int Count { get; set; }
		public int CountReturned { get; set; }
		public int PageReturned { get; set; }
		public int Limit { get; set; }
		public int Pages { get; set; }
		public string TransactionId { get; set; }
	}
}