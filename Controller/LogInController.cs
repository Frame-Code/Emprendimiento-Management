using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public enum ViewType
    {
        Administrador,
        Estudiante,
    }

    public interface ITypeMainForm
    {
        ViewType ViewType { get; }
        string UserName { get; set; }
        void ShowForm(Action closeWindows);
    }

    public class LogInController(ILogInService logInService, IRolUsuarioService rolUsuarioService)
    {
        public async Task<ResponseDto> ValidateCredentials(string username, string password)
        {
            var isSuccess = await logInService.Validate(username, password);
            if (!isSuccess)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Credenciales inválidas"
                };
            }

            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Credenciales válidas",
                Data = await logInService.GetUserByUsername(username)
            };
        }
            

        public async Task<ResponseDto> GetViewByRol(string roleCode)
        {
            var rol = await rolUsuarioService.GetRolByCode(roleCode);
            if(rol == null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Rol no encontrado"
                };
            }

            return rol.Codigo switch
            {
                "ADM" => new ResponseDto
                {
                    IsSuccess = true,
                    Data = ViewType.Administrador
                },
                "EST" => new ResponseDto
                {
                    IsSuccess = true,
                    Data = ViewType.Estudiante
                },
                _ => new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Rol no reconocido"
                }
            };
        }
    }
}
