using Microsoft.AspNetCore.Mvc;
using ProjetoHoteis.lib.Data.Repositorios;
using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.web.Controllers;

[ApiController]
[Route("[controller]")]
public class EstadiaController : ControllerBase
{
    public readonly EstadiaRepositorio _repositorio;
    public EstadiaController(EstadiaRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    [HttpGet]
    public async Task<IActionResult> GetTodos()
    {
    
        return Ok(await _repositorio.BuscarTodos());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPorId(int id)
    {
        return Ok(await _repositorio.BuscarPorId(id));
    }

    [HttpPost]
    public IActionResult Salvar(Estadia estadia)
    {
        _repositorio.Adicionar(estadia);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeletePorId(int id)
    {
        _repositorio.Deletar(id);
        return Ok();
    }
}
