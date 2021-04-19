﻿using AutoMapper;
using CA.Core.Application.Contracts.HandlerExchanges.Post.Commands;
using CA.Core.Application.Contracts.HandlerExchanges.Post.Queries;

namespace CA.Core.Application.Handlers.Post
{
    public class PostMapperProfile : Profile
    {
        public PostMapperProfile()
        {
            CreateMap<Domain.Persistence.Entities.Post, GetPostByIdQueryResponse>();
            CreateMap<Domain.Persistence.Entities.Post, GetAllPostQueryResponse>();
            CreateMap<AddPostCommand, Domain.Persistence.Entities.Post>();
        }
    }
}
