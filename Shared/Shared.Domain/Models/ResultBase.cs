using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Domain.Models
{
    public class ResultBase<TModel> where TModel:class
    {
        public bool Success { get; set; } = false;

        public TModel Data { get; set; }

        public List<string> Errors { get; set; }

        public string Message { get; set; } = "Não foi possível executar a operação no momento";
    }
}
