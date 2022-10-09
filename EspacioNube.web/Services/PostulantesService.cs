using DataAccess.Models;
using EspacioNube.web.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Data.Managers;
using Commons.Helpers;

namespace EspacioNube.web.Services
{
    public class PostulantesService : IPostulantesService
    {
        private readonly PostulantesManager _manager;

        public PostulantesManager Manager 
        { 
            get 
            { 
                return _manager; 
            } 
        }

        public PostulantesService()
        {
            _manager = new PostulantesManager();
        }

        public async Task<List<Postulante>> BuscarListaAsync()
        {
            try
            {
                return await _manager.BuscarListaAsync();
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "PostulantesService", "BuscarListaASync");

                return null;
            }
        }

        public async Task<Postulante> BuscarListaAsync(int id, bool incluirRelaciones = false)
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

        //public async Task<List<Postulante>> BuscarListaAsync(bool incluirRelaciones)
        //{
        //    try
        //    {
        //        return await _manager.BuscarListaAsync(incluirRelaciones);
        //    }
        //    catch (Exception ex)
        //    {
        //        await GenerateLogHelper.LogError(ex, "PostulantesService", "BuscarListaASync");

        //        return null;
        //    }
        //}

        public async Task<List<Postulante>> GuardarAsync(Postulante Postulante)
        {
            try
            {
                var resultado = await _manager.Guardar(Postulante, Postulante.Id);

                return await _manager.BuscarListaAsync();
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "UsuariosService", "GuardarAsync");

                return null;
            }
        }

        public async Task<List<Postulante>> EliminarAsync(Postulante Postulante)
        {
            try
            {
                var resultado = await _manager.Eliminar(Postulante);

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