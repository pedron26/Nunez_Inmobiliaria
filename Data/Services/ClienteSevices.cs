﻿using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Nuñez_Inmobiliaria.Data.Context;
using Nuñez_Inmobiliaria.Data.Entities;
using Nuñez_Inmobiliaria.Data.Request;
using Nuñez_Inmobiliaria.Data.Response;
using System.Collections.Immutable;

namespace Nuñez_Inmobiliaria.Data.Services
{
    public class Result
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
    public class Result<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }

    public class ClienteSevices : IClienteSevices
    {
        private readonly INunezInmobiliariaDbContext dbContext;

        public ClienteSevices(INunezInmobiliariaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result> Crear(ClienteRequest request)
        {
            try
            {
                var cliente = Cliente.Crear(request);
                dbContext.Clientes.Add(cliente);
                await dbContext.SaveChangesAsync();
                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception E)
            {
                return new Result() { Message = E.Message, Success = false };

            }
        }


        public async Task<Result> Modificar(ClienteRequest request)
        {
            try
            {
                var cliente = await dbContext.Clientes.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (cliente == null) return new Result { Message = "No se encontro el cliente", Success = false };


                if (cliente.Modificar(request))
                    await dbContext.SaveChangesAsync();

                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception E)
            {
                return new Result() { Message = E.Message, Success = false };

            }
        }

        public async Task<Result> Eliminar(ClienteRequest request)
        {
            try
            {
                var cliente = await dbContext.Clientes
                    .FirstOrDefaultAsync(c => c.Id == request.Id);
                if (cliente == null)
                    return new Result() { Message = "No se encontro el cliente", Success = false };

                dbContext.Clientes.Remove(cliente);
                await dbContext.SaveChangesAsync();
                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception E)
            {

                return new Result() { Message = E.Message, Success = false };
            }
        }

        public async Task<Result<List<ClienteResponse>>> Consultar(string filtro)
        {
            try
            {
                var clientes = await dbContext.Clientes.Where(c =>
                (c.Nombre + " " + c.Cedula + " " + c.Telefono + " " + c.Direccion)
                .ToLower()
                .Contains(filtro.ToLower()))

                .Select(c => c.ToResponse())
                .ToListAsync();

                return new Result<List<ClienteResponse>>()
                {
                    Message = "OK",
                    Success = true,
                    Data = clientes  
                };

            }
            catch (Exception E)
            {
                return new Result<List<ClienteResponse>>
                {
                    Message = E.Message,
                    Success = false


                };
            }
        }
    }
}

