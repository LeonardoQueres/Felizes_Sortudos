using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Felizes_Sortudos.Model;
using Felizes_Sortudos.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Felizes_Sortudos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ESortudoController : ControllerBase
    {        
        [HttpPost]
        public string VerificarSortudo([FromBody] FelizesSortudos viewModel)
        {
            var ESortudo = new ESortudoService();
            var resultado = ESortudo.Sortudo(viewModel);
            return resultado;
        }
    }
}