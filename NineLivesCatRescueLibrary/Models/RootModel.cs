using System;
using System.Text.Json.Serialization;

namespace NineLivesCatRescueLibrary.Models
{
	public class RootModel
	{
		public MetaModel Meta { get; set; }
		public List<DataModel> Data { get; set; }
		public List<IncludedModel> Included { get; set; }
	}
}