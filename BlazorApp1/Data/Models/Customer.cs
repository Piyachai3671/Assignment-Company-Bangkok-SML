using BlazorApp1.Data.ModelData;

namespace BlazorApp1.Data.Models
{
	public class Customer
	{
		public int cust_id { get; set; }
		public string cust_name { get; set; }
		public string cust_address { get; set; }
		public string cust_postcode { get; set; }
		public string cust_phone { get; set; }
		public string cust_fax { get; set; }
		public string cust_email { get; set; }

		public Customer() { }
		public Customer ToUi(TableCustomer tableCustomer) //UI ไปเทเบิล
		{

			return new Customer
			{
				cust_id = tableCustomer.cust_id,
				cust_name = tableCustomer.cust_name,
				cust_address = tableCustomer.cust_address,
				cust_postcode = tableCustomer.cust_postcode,
				cust_phone = tableCustomer.cust_phone,
				cust_fax = tableCustomer.cust_fax,
				cust_email = tableCustomer.cust_email,
			};


		}

		public TableCustomer ToTable(Customer NewCustomer)
		{
			return new TableCustomer
			{
				cust_id = NewCustomer.cust_id,
				cust_name = NewCustomer.cust_name,
				cust_address = NewCustomer.cust_address,
				cust_postcode = NewCustomer.cust_postcode,
				cust_phone = NewCustomer.cust_phone,
				cust_fax = NewCustomer.cust_fax,
				cust_email = NewCustomer.cust_email,
			};
		}
	}
}
