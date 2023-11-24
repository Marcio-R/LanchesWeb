using LanchesWeb.Repositories;
using LanchesWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesWeb.Controllers
{
    public class LancheController : Controller
    {
        private readonly LancheRepository _lancheRepository;

        public LancheController(LancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var lanchesListViewModel = new LanchesListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches();
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }
    }
}
