using Microsoft.AspNetCore.Mvc;
using Donaldo_SportsStore.Models;

namespace Donaldo_SportsStore.Controllers
{
	public class HomeController: Controller
	{
		private IStoreRepository repository;

		public HomeController(IStoreRepository repository) 
		{ 
			this.repository= repository;
		}
		public IActionResult Index() => View(repository.Products);
	}
}
