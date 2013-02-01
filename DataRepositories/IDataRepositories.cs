using System;
using System.Collections.Generic;
using System.Linq;

namespace DataRepositories
{
    public interface IDataRepositories<T> : IDisposable
    {
        IQueryable<T> All { get; }
        T Find(string id);
        void AddOrUpdate(T obj);
        void Delete(string id);
        void Save();
    }
}