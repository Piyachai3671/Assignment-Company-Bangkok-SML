using BlazorApp1.Data.ModelData;

namespace BlazorApp1.Data.Services
{
	public class CustomerService
	{
		//private List<Customer> Student = new List<Customer>()
		//{
		//	new Customer(){}
		//};
		//public async Task<List<Customer>> GetStudentsAsync()
		//{
		//	return await Task.FromResult(Student);
		//}
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public CustomerService(ApplicationContext context)
		{
			_Context = context;
		}
		public async Task<List<TableCustomer>> GetCustomerAsync()
		{
			var u = _Context.TableCustomer.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewCustomer(TableCustomer NewCustomer)
		{
			_Context.TableCustomer.Add(NewCustomer);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void DeleteEmployee(TableCustomer DeleteCustomer)
		{
			var FindID = _Context.TableCustomer.First(e => e.cust_id == DeleteCustomer.cust_id);

			_Context.TableCustomer.Remove(FindID);
			_Context.SaveChanges();
		}
		public void EditEmployee(TableCustomer EditCustomer)
		{
			var FindID = _Context.TableCustomer.First(e => e.cust_id == EditCustomer.cust_id);
			FindID.cust_name = EditCustomer.cust_name;
			FindID.cust_address = EditCustomer.cust_address;
			FindID.cust_postcode = EditCustomer.cust_postcode;
			FindID.cust_phone = EditCustomer.cust_phone;
			FindID.cust_fax = EditCustomer.cust_fax;
			FindID.cust_email = EditCustomer.cust_email;


			_Context.TableCustomer.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
	}
}
