using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudWeb.Models;

namespace PortfolioHenrique.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Recuperar a lista de assuntos do banco de dados
            var assuntosDoBanco = _context.Assunto.ToList();

            // Criar uma instância do modelo Contato
            Contato contato = new Contato();

            // Preencher a propriedade ListaAssunto com os assuntos recuperados do banco
            contato.ListaContato = assuntosDoBanco
                .Select(a => new SelectListItem { Text = a.assunto, Value = a.AssuntoId.ToString() })
                .ToList();

            return View(contato);
        }

        public IActionResult Enviar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Enviar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                contato.DataEnvio = DateTime.Now;

                _context.Add(contato);
                await _context.SaveChangesAsync();
                TempData["Mensagem"] = "Mensagem enviada com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }
    }
}
