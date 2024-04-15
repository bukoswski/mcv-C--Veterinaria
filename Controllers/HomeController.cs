using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPETS.Models;

namespace LHPETS.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

//instanciamento dos clientes
    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Pedro Mendes", "123.258.459-23","pedro@gamil.com.br", "zacaryhas");
        Cliente cliente2 = new Cliente(02, "Jonattas Barrozzo", "859.569.358-65","jonnatta@gmail.com.br", "bilu");
        Cliente cliente3 = new Cliente(03, "kiko Guimarães", "456.783.233-78","kikooLicho@gmail.com.br", "chiquinha");
        Cliente cliente4 = new Cliente(04, "Woodpecker pezzolano", "897.457.333-00", "pezzoolano@gmail.com.br", "sherazady");
        Cliente cliente5 = new Cliente(05, "Paolla", "225.558.489-77", "paaolaa@gmail.com.br", "cebolinha");

//lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes; 

//instanciamento dos fornecedores

        Fornecedor fornecedor1 = new Fornecedor(01, "Rações Kedira", "14.888.456/0001-90", "kedira@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "C# Microsoft", "55.895.478/0001-52", "microsoft@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, ".NET-umidecidos", "44.741.236/0001-99", "netassociacao@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "python-brinquedos", "77.456.789/0001-22", "python@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "lenovo", "21.258.963/0001-25", "lenovo@gmail.com"); 
        
//lista dos fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
