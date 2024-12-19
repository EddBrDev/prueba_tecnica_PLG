using System;
using API.Data;
using API.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController: ControllerBase
    {
        private readonly ClienteContext _context;
        public ClienteController(ClienteContext context)
        {
            _context = context;
        }

        [HttpGet("storeprocedure")]
        public IActionResult GetClientes(int pagina = 1, int tamano_pagina = 10)
        {
            var clientes = ClienteData.ListarClientes(pagina, tamano_pagina);
            return Ok(clientes);
        }

        // Servicio 2: Usando LINQ y Entity Framework
        [HttpGet("linq")]
        public async Task<IActionResult> GetClientesLinq(int page = 1, int pageSize = 10)
        {
            var clientes = await _context.t_clientes
                .OrderBy(c => c.id_cliente)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(c => new
                {
                    c.id_cliente,
                    c.cliente,
                    c.telefono,
                    Pais = c.Pais_Ef == null ? "" : c.Pais_Ef.pais
                })
                .ToListAsync();

            return Ok(clientes);
        }

    }
}
