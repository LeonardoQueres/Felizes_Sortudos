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
    public class EFelizController : ControllerBase
    {   
        [HttpPost]
        public string VerificarEFeliz([FromBody] FelizesSortudos viewModel)
        {
            var feliz = new EFelizServices();
            var resultado = feliz.Feliz(viewModel.Numero);
            return resultado;
        }

        
    }
}