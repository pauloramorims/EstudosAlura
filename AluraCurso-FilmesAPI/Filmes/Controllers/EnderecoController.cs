using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnderecosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private AppDbContext _context;
    private IMapper _mapper;

    public EnderecoController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarEndereco([FromBody] CreateEnderecoDto enderecodto)
    {
        Endereco endereco = _mapper.Map<Endereco>(enderecodto); //Realizando Conversao com automapper
       
        _context.Enderecos.Add(endereco);
        _context.SaveChanges();

        //retorna o status 201, e a localização de acesso ao dado gravado (a rota)
        return CreatedAtAction(nameof(RecuperaEnderecosID), new { Id = endereco.Id }, endereco);
    }

    [HttpGet]
    public IEnumerable<Endereco> RescuperarEnderecos()
    {
        return _context.Enderecos;
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaEnderecosID(int id)
    {
        Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
        if (endereco == null)
            return NotFound(endereco);

        ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);

        return Ok(enderecoDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaEndereco (int id, [FromBody]UpdateEnderecoDto enderecoDto)
    {
        Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
        if (endereco == null)
            return NotFound(endereco);

        _mapper.Map(enderecoDto, endereco);
        
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaEndereco (int id)
    {
        Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
        if (endereco == null)
            return NotFound(endereco);

        _context.Remove(endereco);
        _context.SaveChanges();

        return NoContent();

    }
}
