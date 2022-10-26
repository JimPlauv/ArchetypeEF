using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArchtypeEF
{
    public interface ICommands
    {
        Task Get<T>();
        Task Inset<T>();
        Task Update<T>();
        Task Delete<T>();

        Task GetAsync<T>();
        Task InsetAsync<T>();
        Task UpdateAsync<T>();
        Task DeleteAsync<T>();
    }
}
