using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Context;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        //esses metodos que chamam paginas são HttpGet
        //mas a tag HttpGet no MVC é implicita, portanto
        //não é necessario colocar, somente as outras
        //como post, put e delete.
        public IActionResult Index()
        {
            //quando você abre a index, ele vai pegar todos os contatos
            //e criar uma lista, e jogar em contatos, e passar para a view.
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        //Esse criar serve para abrir a pagina criar
        //é implicito que ele é um HttpGet
        public IActionResult Criar()
        {
            return View();
        }

        //Esse criar vai funcionar quando apertar o botão criar da pagina criar
        //ele vai pega o modelo do contato, carrega-lo com as informações dos
        //campos e dai salva no banco de dados.
        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            //se for valido (ele confere se esta correto os campos
            //exemplo se o campo nome for obrigatorio então precisa
            //ter algo no campo nome para ser valido).
            if (ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                //volta para index da pasta Contato onde tem a lista de contatos.
                return RedirectToAction(nameof(Index));
            }
            //se nao for valido
            return View(contato);
        }

        public IActionResult Editar(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato is null)
                return NotFound();

            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Detalhes(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato is null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato is null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        [HttpPost] //Porque não HttpDelete?
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
