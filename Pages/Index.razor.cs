using BlastOff.Shared;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Dashboard.Pages
{
	partial class Index : ComponentBase
	{
		public IEnumerable<Image> ImageList { get; set; } = new List<Image>();
	}
}
