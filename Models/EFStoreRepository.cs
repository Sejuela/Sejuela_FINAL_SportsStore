using Microsoft.AspNetCore.DataProtection.XmlEncryption;

namespace Rubio_SportsStore.Models
{
	public class EFStoreRepository : IStoreRepository
	{
		private StoreDbContext context;
		public EFStoreRepository(StoreDbContext ctx)
		{
			context = ctx;
		}
		public IQueryable<Product> Products => context.Products;
	}
}
