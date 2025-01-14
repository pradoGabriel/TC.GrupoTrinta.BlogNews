﻿using Microsoft.EntityFrameworkCore;
using TC.GrupoTrinta.BlogNews.Domain.Entity;
using TC.GrupoTrinta.BlogNews.Domain.Repository;

namespace TC.GrupoTrinta.BlogNews.Infra.Data.EF.Repositories;
public class NewsRepository : INewsRepository
{
    private readonly BlogNewsDbContext _context;
    
    private DbSet<News> _news
        => _context.Set<News>();

    public NewsRepository(BlogNewsDbContext context)
        => _context = context;

    public async Task Insert(News aggregate, CancellationToken cancellationToken) 
        => await _news.AddAsync(aggregate,cancellationToken);
    
}
