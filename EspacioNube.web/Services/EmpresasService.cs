using DataAccess.Models;
using EspacioNube.web.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Data.Managers;
using Commons.Helpers;

namespace EspacioNube.web.Services
{
    public class EmpresasService : IEmpresasService
    {
        private readonly EmpresasManager _manager;

        public EmpresasManager Manager 
        { 
            get 
            { 
                return _manager; 
            } 
        }

        public EmpresasService()
        {
            _manager = new EmpresasManager();
        }

        public async Task<List<Empresa>> BuscarListaAsync()
        {
            try
            {
                return await _manager.BuscarListaAsync();
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "EmpresasService", "BuscarListaASync");

                return null;
            }
        }

        public async Task<Empresa> BuscarListaAsync(int id, bool incluirRelaciones = false)
        {
            try
            {
                return await _manager.BuscarUno(id);
            }
            catch(Exception ex)
            {
                return null;

            }
        }

        public async Task<List<Empresa>> BuscarListaAsync(bool incluirRelaciones)
        {
            try
            {
                return await _manager.BuscarListaAsync(incluirRelaciones);
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "EmpresasService", "BuscarListaASync");

                return null;
            }
        }

        public async Task<List<Empresa>> GuardarAsync(Empresa empresa)
        {
            try
            {
                var resultado = await _manager.Guardar(empresa, empresa.Id);

                return await _manager.BuscarListaAsync();
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "UsuariosService", "GuardarAsync");

                return null;
            }
        }

        public async Task<List<Empresa>> EliminarAsync(Empresa empresa)
        {
            try
            {
                var resultado = await _manager.Eliminar(empresa);

                return await _manager.BuscarListaAsync();
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "UsuariosService", "EliminarAsync");

                return null;
            }
        }
    }
}