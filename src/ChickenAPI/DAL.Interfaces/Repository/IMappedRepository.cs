﻿using System.Collections.Generic;

namespace ChickenAPI.DAL.Interfaces.Repository
{
    public interface IMappedRepository<T> : IRepository<T> where T : class, IMappedDto
    {
        T GetById(long id);
        IEnumerable<T> GetByIds(IEnumerable<long> ids);


        void DeleteById(long id);
        void DeleteByIds(IEnumerable<long> ids);
    }
}