using NTierVeresiye.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresite.BLL.Repositories
{
    public class SqlRepository<T> where T : class
    {
        SqlDbContext db = new SqlDbContext();

        public IQueryable<T> Listele()
        {
            return db.Set<T>();
        }
        public IQueryable<T> Filtreleme(Expression<Func<T, bool>> ifade)
        {
            return db.Set<T>().Where(ifade);
        }

        public T IDGoreGetir(Expression<Func<T, bool>> ifade)
        {
            return db.Set<T>().Where(ifade).FirstOrDefault();
        }
        //Kayıt olması durumunda çalışır.Yoksa hataya düşer.
        //Kayıt yoksa;

        //public T IDGoreGetir(Expression<Func<T, bool>> ifade)
        // {
        //    if(db.Set<T>().Any(ifade)) return db.Set<T>().Where(ifade).First();

        //   else return null;
        // }

        public void Ekle(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();

        }
        //public void Ekle(List<T> entity)
        //{
        //    db.Set<T>().AddRange(entity);
        //    db.SaveChanges();

        //}
        public void Guncelle(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }


        public void Sil(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();

        }
    }
}