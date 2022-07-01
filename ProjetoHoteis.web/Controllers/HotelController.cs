using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ProjetoHoteis.lib.Data.Repositorios;
using ProjetoHoteis.lib.Exceptions;
using ProjetoHoteis.lib.Models;
using ProjetoHoteis.web.DTOs;
using ProjetoHoteis.web.DTOs.RespostaHTTP;

namespace ProjetoHoteis.web.Controllers;

[ApiController]
[Route("[controller]")]
public class HotelController : ControllerBase
{
    public readonly HotelRepositorio _repositorio;
    public static List<Hotel> _hoteis = new List<Hotel>();
    public HotelController(HotelRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    [HttpGet("CEP")]
    public async Task<IActionResult> GetCEP(string cep)
    {
        var clientHttp = new HttpClient();
        var retorno =  await clientHttp.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
        var respostaString = await retorno.Content.ReadAsStringAsync();
        var respostaObjeto = JsonSerializer.Deserialize<ViaCepRespostaHTTP>(respostaString);
        return Ok(respostaObjeto);
    }

    [HttpGet("Teste")]
    public IActionResult Teste(){
        EscreverSincrono(1, "Teste", 800);
        return Ok();
    }
    [HttpGet("TesteAsync")]
    public async Task<IActionResult> TesteAsync(){
        await EscreverAsync(1, "TesteAsync", 800);
        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> GetTodos()
    {
        var todosHoteis = await _repositorio.BuscarTodosAsync();
        return Ok(todosHoteis);
    }
    [HttpGet("estatico")]
    public async Task<IActionResult> GetTodosEstatico()
    {
        return Ok(_hoteis);
    }
    [HttpPost("Estatico")]
    public async Task<IActionResult> SalvarEstatico(HotelDTO hotelDto)
    {
        try
        {
            var endereco = await BuscarEnderecoPorCEP(hotelDto.Cep);
            var hotel = new Hotel(hotelDto.Id, DateTime.Now.ToString(), DateTime.Now.ToString(), 
            hotelDto.Nome, endereco, hotelDto.Cep, hotelDto.Descricao, hotelDto.Telefone,
            hotelDto.Email, hotelDto.Checkin.ToString(), hotelDto.Checkout.ToString());
            _hoteis.Add(hotel);
            return Ok();
        }
        catch (InputInvalidoException ex)
        {
            
            return BadRequest(ex.Message);
        }
      
    }
    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        return Ok(_repositorio.BuscarPorId(id));
    }

    [HttpPost]
    public async Task<IActionResult> Salvar(HotelDTO hotelDto)
    {
        try
        {
            var endereco = await BuscarEnderecoPorCEP(hotelDto.Cep);
            var hotel = new Hotel(hotelDto.Id, DateTime.Now.ToString(), DateTime.Now.ToString(), 
            hotelDto.Nome, endereco, hotelDto.Cep, hotelDto.Descricao, hotelDto.Telefone,
            hotelDto.Email, hotelDto.Checkin.ToString(), hotelDto.Checkout.ToString());
            await _repositorio.Adicionar(hotel);
            return Ok();
        }
        catch (InputInvalidoException ex)
        {
            
            return BadRequest(ex.Message);
        }
      
    }
    private async Task<string> BuscarEnderecoPorCEP(string cep)
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("https://viacep.com.br");
        var retorno = await client.GetAsync($"ws/{cep}/json/");
        if(!retorno.IsSuccessStatusCode){
            throw new InputInvalidoException("CEP INVALIDO");
        }
        var corpoResposta = await retorno.Content.ReadAsStringAsync();
        var resposta = JsonSerializer.Deserialize<ViaCepRespostaHTTP>(corpoResposta);
        var endereco = $"{resposta.logradouro}, {resposta.complemento}, {resposta.bairro}";
        return endereco;
    }
    [HttpDelete]
    public IActionResult DeletePorId(int id)
    {
        _repositorio.Deletar(id);
        return Ok();
    }

    void EscreverSincrono(int idChamada, string mensagem, int tempoEmMS){

    Console.WriteLine(
    $"Thread da chamada {idChamada}: {Thread.CurrentThread.ManagedThreadId}");
    Thread.Sleep(tempoEmMS);
    Console.WriteLine(mensagem);
}
async Task EscreverAsync(int idChamada, string mensagem, int tempoEmMS){
    Console.WriteLine("Já recebi o pedido numero: " + idChamada);
    Console.WriteLine(
            $"Thread da chamada {idChamada}: {Thread.CurrentThread.ManagedThreadId}");
    await Task.Delay(tempoEmMS);
    Console.WriteLine(mensagem);
}
}
