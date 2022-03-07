﻿using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreatedFilmeDto, Filme>();
        CreateMap<Filme, ReadFilmeDto>();
        CreateMap<UpdatedFilmeDto, Filme>();

    }
}
