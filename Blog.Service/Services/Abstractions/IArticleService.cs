﻿using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;


namespace Blog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticleAsync();
    }
}
