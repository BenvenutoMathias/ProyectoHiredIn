using Commons.Helpers;
using DataAccess.Models;
using EspacioNube.web.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Data.Managers;

namespace EspacioNube.web.Services
{
    public class PostsService : IPostsService
    {
        private readonly PostsManager _manager;

        public PostsManager Manager
        {
            get
            {
                return _manager;
            }
        }

        public PostsService()
        {
            _manager = new PostsManager();
        }

        public async Task<List<Post>> BuscarListaAsync()
        {
            try
            {
                return await _manager.BuscarListaAsync();
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "PostsService", "BuscarListaASync");

                return null;
            }
        }

        public async Task<Post> BuscarListaAsync(int id, bool incluirRelaciones = false)
        {
            try
            {
                return await _manager.BuscarUno(id);
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public async Task<List<Post>> BuscarListaAsync(bool incluirRelaciones)
        {
            try
            {
                return await _manager.BuscarListaAsync(incluirRelaciones);
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "PostsService", "BuscarListaASync");

                return null;
            }
        }

        public async Task<List<Post>> GuardarAsync(Post Post)
        {
            try
            {
                var resultado = await _manager.Guardar(Post, Post.Id);

                return await _manager.BuscarListaAsync();
            }
            catch (Exception ex)
            {
                await GenerateLogHelper.LogError(ex, "UsuariosService", "GuardarAsync");

                return null;
            }
        }

        public async Task<List<Post>> EliminarAsync(Post Post)
        {
            try
            {
                var resultado = await _manager.Eliminar(Post);

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