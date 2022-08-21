using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNestMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class UserRequest 
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PrimeiraAction()
    {
        return View();
    }

    public string TesteQueryString([FromQuery] string q, string nome)
    {
        return $"Chegou aqui {q} para {nome}";
    }

    public string TesteFormData([FromForm] UserRequest userRequest) //criando formulário
    {
        return $"Nome: {userRequest.Nome}, Email: {userRequest.Email} e Senha: {userRequest.Senha}";
    }
    
    public IActionResult Formulario() //sempre q quero uma view, preciso colocar IActionResult
    {
        return View();
    }

    public IActionResult OperacoesMatematicas()
    {
        return View();
    }
    
    public IActionResult OperacaoSomar([FromForm] double primeiroValor, [FromForm] double segundoValor)
    {
        ViewBag.Operacao = "Soma";
        ViewBag.Resultado = $"A soma de {primeiroValor} + {segundoValor} é igual a {primeiroValor + segundoValor}.";
        return View("Resultado");
    }

    public IActionResult OperacaoSubtrair([FromForm] double primeiroValor, [FromForm] double segundoValor)
    {
        ViewBag.Operacao = "Subtração";
        ViewBag.Resultado = $"A subtração de {primeiroValor} - {segundoValor} é igual a {primeiroValor - segundoValor}.";
        return View("Resultado");
    }

    public IActionResult OperacaoMultiplicar([FromForm] double primeiroValor, [FromForm] double segundoValor)
    {
        ViewBag.Operacao = "Multiplicação";
        ViewBag.Resultado = $"A multiplicação de {primeiroValor} * {segundoValor} é igual a {primeiroValor * segundoValor}.";
        return View("Resultado");
    }

    public IActionResult OperacaoDividir([FromForm] double primeiroValor, [FromForm] double segundoValor)
    {
        ViewBag.Operacao = "Divisão";
        ViewBag.Resultado = $"A divisão de {primeiroValor} / {segundoValor} é igual a {primeiroValor / segundoValor}.";
        return View("Resultado");
    }
    
    public IActionResult CalculadoraForm([FromForm] double primeiroValor, [FromForm] double segundoValor, [FromForm] string operacao)
    {
        if(operacao == "Soma")
        {
            ViewBag.Operacao = "Soma";
            ViewBag.Resultado = $"A soma de {primeiroValor} + {segundoValor} é igual a {primeiroValor + segundoValor}.";
            return View("Resultado");
        } else
        if(operacao == "Subtracao")
        {
            ViewBag.Operacao = "Subtração";
            ViewBag.Resultado = $"A subtração de {primeiroValor} - {segundoValor} é igual a {primeiroValor - segundoValor}.";
            return View("Resultado");
        } else
        if(operacao == "Multiplicacao")
        {
            ViewBag.Operacao = "Multiplicação";
            ViewBag.Resultado = $"A multiplicação de {primeiroValor} * {segundoValor} é igual a {primeiroValor * segundoValor}.";
            return View("Resultado");
        } else
        if(operacao == "Divisao")
        {
            ViewBag.Operacao = "Divisão";
            ViewBag.Resultado = $"A divisão de {primeiroValor} / {segundoValor} é igual a {primeiroValor / segundoValor}.";
            return View("Resultado");
        }
        return View("Resultado");
    }

    public IActionResult Calculadora()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    /*
    public string TesteFormData([FromForm] UserRequest userRequest, [FromHeader]string Valor) //forms com valor que fica no URL
    {
        return $"Nome: {userRequest.Nome}, Email: {userRequest.Email} Valor: {Valor}";
    }
    */ 
}