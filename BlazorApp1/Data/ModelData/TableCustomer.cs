using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.ModelData
{
	[Table("Customer")]
	public class TableCustomer
	{
		[Key]
		public int cust_id { get; set; }
		public string cust_name { get; set; }
		public string cust_address { get; set; }
		public string cust_postcode { get; set; }
		public string cust_phone { get; set; }
		public string cust_fax { get; set; }
		public string cust_email { get; set; }
	}
}
