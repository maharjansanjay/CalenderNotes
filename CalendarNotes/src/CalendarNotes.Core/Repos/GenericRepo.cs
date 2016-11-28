using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarNotes.Common.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalendarNotes.Core.Repos
{
    public interface IGenericRepo<T> where T : class
    {
        T Add(T model);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        T Single(Expression<Func<T, bool>> predicate);
        int Commit();
    }
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private CalendarNoteContext dbContext;
        public GenericRepo()
        {
            var option = new DbContextOptionsBuilder<CalendarNoteContext>()
                .UseSqlServer("Server=localhost;Database=CalendarNotes;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;
            dbContext = new CalendarNoteContext(option);
        }
        public virtual T Add(T model)
        {
            return dbContext.Set<T>().Add(model).Entity;
        }
        public virtual IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().Where(predicate);
        }
        public virtual T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().FirstOrDefault(predicate);
        }
        public virtual T Single(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().Single(predicate);
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }
    }
}