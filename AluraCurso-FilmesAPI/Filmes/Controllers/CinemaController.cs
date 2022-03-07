using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemasAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CinemaController : ControllerBase
{
    private AppDbContext _context;
    private IMapper _mapper;

    public CinemaController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarCinema([FromBody] CreateCinemaDto cinemadto)
    {
        Cinema cinema = _mapper.Map<Cinema>(cinemadto); //Realizando Conversao com automapper
       
        _context.Cinemas.Add(cinema);
        _context.SaveChanges();

        //retorna o status 201, e a localização de acesso ao dado gravado (a rota)
        return CreatedAtAction(nameof(RecuperaCinemasID), new { Id = cinema.Id }, cinema);
    }

    [HttpGet]
    public IEnumerable<Cinema> RescuperarCinemas()
    {
        return _context.Cinemas;
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaCinemasID(int id)
    {
        Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if (cinema == null)
            return NotFound(cinema);

        ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);

        return Ok(cinemaDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaCinema (int id, [FromBody]UpdateCinemaDto CinemaDto)
    {
        Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if (cinema == null)
            return NotFound(cinema);

        _mapper.Map(CinemaDto, cinema);
        
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaCinema (int id)
    {
        Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if (cinema == null)
            return NotFound(cinema);

        _context.Remove(cinema);
        _context.SaveChanges();

        return NoContent();

    }
}
