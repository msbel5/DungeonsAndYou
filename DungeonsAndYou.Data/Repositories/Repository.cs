﻿using DungeonsAndYou.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using DungeonsAndYou.Data.Data;

namespace DungeonsAndYou.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly DbContext _context;

    public Repository()
    {
        _context = new DungeonsAndYouContext();
    }
    public TEntity Get(int id)
    {
        return _context.Set<TEntity>().Find(id);
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    {
        return _context.Set<TEntity>().Where(predicate);
    }

    public bool Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        int result = _context.SaveChanges();
        if (result > 0)
            return true;
        return false;
    }

    public bool AddRange(IEnumerable<TEntity> entities)
    {
        _context.Set<TEntity>().AddRange(entities);
        int result = _context.SaveChanges();
        if (result > 0)
            return true;
        return false;
    }

    public bool Update(int entityId, TEntity entity)
    {
        var updatedEntity = _context.Set<TEntity>().Find(entityId);
        _context.Entry(updatedEntity).CurrentValues.SetValues(entity);
        int result = _context.SaveChanges();
        if (result > 0)
            return true;
        return false;
    }

    public bool Remove(int id)
    {
        var removedEntity = _context.Set<TEntity>().Find(id);
        _context.Set<TEntity>().Remove(removedEntity);
        int result = _context.SaveChanges();

        if (result > 0)
            return true;
        return false;

    }

    public bool RemoveRange(IEnumerable<TEntity> entities)
    {
        _context.Set<TEntity>().RemoveRange(entities);
        int result = _context.SaveChanges();
        if (result > 0)
            return true;
        return false;
    }
}
