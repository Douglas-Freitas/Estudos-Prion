using Backend.Entities;
using Backend.Services;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : GenericController<Usuario>
    {
        private UsuarioService _usuarioService;
        public UsuarioController()
        {
            this._usuarioService = new UsuarioService();
        }

        //[AllowAnonymous]
        //[HttpPost]
        //public object GetUsuarioPorEmail(Usuario usuario)
        //{

        //    Usuario usuarioDb = _usuarioService.GetUsuarioPorEmail(usuario.Email);
        //    if (usuarioDb != null || usuarioDb.Email == usuario.Email
        //        && usuarioDb.Senha == usuario.Senha)
        //    {
        //        byte[] key = Convert.FromBase64String(TokenManager.Secret);
        //        string json = JsonConvert.SerializeObject(usuarioDb);
        //        ClaimsIdentity identidade = new ClaimsIdentity();
        //        identidade.AddClaim(new Claim("Usuario", json));

        //        DateTime dataCriacao = DateTime.Now;
        //        DateTime dataExpiracao = dataCriacao +
        //            TimeSpan.FromSeconds(3000);

        //        var handler = new JwtSecurityTokenHandler();
        //        var securityToken = handler.CreateToken(new SecurityTokenDescriptor
        //        {

        //            SigningCredentials = new SigningCredentials(
        //                                    new SymmetricSecurityKey(key),
        //                                    SecurityAlgorithms.HmacSha256Signature),
        //            Subject = identidade,
        //            NotBefore = dataCriacao,
        //            Expires = dataExpiracao
        //        });

        //        //var token = handler.WriteToken(securityToken);
        //        return handler.WriteToken(securityToken);

        //        //return new
        //        //{
        //        //    authenticated = true,
        //        //    created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
        //        //    expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
        //        //    accessToken = token,
        //        //    user = usuarioBase,
        //        //    message = "OK"
        //        //};

        //    }
        //    else
        //        throw new Exception("Usuário ou Senha inválidos");
        //}

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public object Login(Usuario usuario)
        {
            //Usuario usuarioDb = this._usuarioService.GetUsuarioPorEmail(usuario.Email);
            Usuario usuarioDb = new Usuario()
            {
                Email = "douglas",
                Senha = "123",
                UsuarioId = 1
            };
            if (usuarioDb == null || usuarioDb.Senha != usuario.Senha
                || usuarioDb.Email != usuario.Email)
                return Request.CreateResponse(HttpStatusCode.Forbidden,
                     "Usuário ou Senha inválidos.");
            return Request.CreateResponse(HttpStatusCode.OK,
                 TokenManager.GenerateToken(usuario.Email));
        }

        [HttpGet]
        public HttpResponseMessage Validate(string token, string email)
        {
            bool exists =  _usuarioService.GetUsuarioPorEmail(email) != null;
            if (!exists) return Request.CreateResponse(HttpStatusCode.NotFound,
                 "Usuario ou senha invalidos.");
            string tokenUsername = TokenManager.ValidateToken(token);
            if (email.Equals(tokenUsername))
                return Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}