//using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Formatter;
using System.Net.Http;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Shared.Domain.Interface.Models;
using Shared.Domain.Interface.Service;
using Shared.Domain.Models;

namespace Shared.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class BaseController<TModel, TIdType> : ODataController
        where TModel : class, IBaseModel<TIdType>
    {
        public Func<IActionResult> BeforeInsert;
        public Func<IActionResult> AfterInsert;

        public Func<IActionResult> BeforeUpdate;
        public Func<IActionResult> AfterUpdate;

        public Func<IActionResult> BeforeDelete;
        public Func<IActionResult> AfterDelete;

        protected readonly IBaseService<TModel, TIdType> _service;
        protected readonly HttpContext _httpContext;
        protected readonly ILogger _logger;


        protected TModel _model;

        public BaseController(IBaseService<TModel, TIdType> service, ILogger loger)
        {
            _service = service;
            _logger = loger;

            //_tenant = tenant;
        }

        [EnableQuery]
        [HttpGet]
        public virtual IActionResult Get()
        {
            return Ok(_service.Get());
        }

        [EnableQuery]
        [HttpGet]
        public virtual IActionResult Get([FromODataUri] TIdType key)
        {
            return Ok(_service.Get(key));
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] TModel model)
        {
            _model = model;

            var result = new ResultBase<TModel>
            {
                Data = model
            };

            if (!ModelState.IsValid)
            {
                result.Success = false;
                result.Message = "Não foi possível incluir o registro";
                result.Errors = GetModelStateErrors();

                return Ok(result);
            }

            var res = BeforeInsert?.Invoke();

            if (res != null)
                return res;


            if (await _service.InsertAsync(model) > 0)
            {
                AfterInsert?.Invoke();
                
                result.Success = true;

                result.Message = "Registro criado com sucesso";

                return Ok(result);
            }

            result.Success = false;
            result.Message = "Não foi possível incluir o registro";

            AfterInsert?.Invoke();

            return Ok(result);
        }

        /*protected async Task<int> DoPost(TModel model)
        {
            _repository.Db.Add<TModel>(model);

            return await _repository.Db.SaveChangesAsync();
        }*/

        [HttpPut]
        public virtual async Task<IActionResult> Put(TModel model)
        {
            _model = model;

            var result = new ResultBase<TModel>
            {
                Data = model
            };

            if (!ModelState.IsValid)
            {
                result.Message = "Não foi possível alterar o registro.";
                result.Errors = GetModelStateErrors();

                return Ok(result);
            }


            if (await _service.UpdateAsync(model) > 0)
            {
                AfterUpdate?.Invoke();

                result.Success = true;
                result.Message = "Registro alterado com sucesso";
                return Ok(result);
            }

            result.Message = "Não foi possível alterar o registro";
            return Ok(result);

        }

        [HttpDelete]
        public virtual async Task<IActionResult> Delete([FromQuery] TIdType id)
        {
            var result = new ResultBase<TModel>();

            var resultado = await _service.DeleteAsync(id);

            if (resultado > 0)
            {
                result.Success = true;
                result.Message = "Registro excluído com sucesso";
            }

            if (resultado == 0)
            {
                result.Message = "Não foi possível excluir o registro";
                result.Success = false;
            }

            if (resultado == -1)
            {
                result.Success = false;
                result.Message = "Registro não encontrado";
            }

            return Ok(result);
        }

        [NonAction]
        public IActionResult CreateResult(HttpStatusCode statusCode, string message,
            object data = null, object errors = null)
        {
            return StatusCode((int)statusCode, new { statusCode, message, data, errors });
        }

        [NonAction]
        public List<string> GetModelStateErrors()
        {
            //var errors = new Dictionary<string, string[]>(); //List<KeyValuePair<string, string>>();
            var errors = new List<string>();
            
            foreach (var key in ModelState.Keys)
            {
                errors.AddRange(ModelState[key].Errors.ToList().Select(t => t.ErrorMessage).ToArray());
                /*foreach (var m in ModelState[key].Errors.ToList().Select(t => t.ErrorMessage))
                {
                    errors.Add(string, string > (key, m));
                }*/

            }

            return errors;

        }

    }
}