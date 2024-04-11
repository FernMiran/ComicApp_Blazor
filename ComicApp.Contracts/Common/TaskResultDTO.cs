using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Contracts.Common
{
    public class TaskResultDTO
    {
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }

    public class TaskResultDTO<T> : TaskResultDTO where T : class
    {
        public T Data { get; set; }
    }
}
