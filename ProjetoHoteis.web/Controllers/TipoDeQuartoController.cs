using Microsoft.AspNetCore.Mvc;
using ProjetoHoteis.lib.Data.Repositorios;
using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.web.Controllers;

[ApiController]
[Route("[controller]")]
public class TipoDeQuartoController : ControllerBase
{
    public readonly TipoDeQuartoRepositorio _repositorio;
    public TipoDeQuartoController(TipoDeQuartoRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    [HttpGet]
    public IActionResult GetTodos()
    {
        return Ok(_repositorio.BuscarTodos());
    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        return Ok(_repositorio.BuscarPorId(id));
    }

    [HttpPost]
    public IActionResult Salvar(TipoDeQuarto tipoDeQuarto)
    {
        _repositorio.Adicionar(tipoDeQuarto);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeletePorId(int id)
    {
        _repositorio.Deletar(id);
        return Ok();
    }
}
