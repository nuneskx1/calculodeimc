using Microsoft.AspNetCore.Mvc;
using calculodeimc.Models;

namespace calculodeimc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new ImcViewModel());
        }

        [HttpPost]
        public IActionResult Index(ImcViewModel model)
        {
            if (ModelState.IsValid)
            {

                model.ResultadoImc = model.Peso / (model.Altura * model.Altura);


                if (model.ResultadoImc < 18.5) model.Classificacao = "Abaixo do peso";
                else if (model.ResultadoImc < 25) model.Classificacao = "Peso normal (Parabéns!)";
                else if (model.ResultadoImc < 30) model.Classificacao = "Sobrepeso";
                else if (model.ResultadoImc < 35) model.Classificacao = "Obesidade Grau I";
                else if (model.ResultadoImc < 40) model.Classificacao = "Obesidade Grau II";
                else model.Classificacao = "Obesidade Grau III (Mórbida)";
            }

            return View(model);
        }
    }
}