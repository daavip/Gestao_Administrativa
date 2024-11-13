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
    public class ReadOnlyBaseController<TModel, TIdType> : ODataController
        where TModel : class, IBaseModel<TIdType>
    {

        protected readonly IBaseService<TModel, TIdType> _service;
        protected readonly ILogger _logger;


        public ReadOnlyBaseController(IBaseService<TModel, TIdType> service, ILogger loger)
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

    }
}