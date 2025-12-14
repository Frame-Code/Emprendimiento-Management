using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.ViewRol;

namespace Controller
{
    public class AuthController(ILogInService logInService, IRolUsuarioService rolUsuarioService, ISignUpService signUpService)
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

            var viewType = GetViewTypeByRolCode(roleCode);
            if(viewType == null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Rol no reconocido"
                };
            }

            return new ResponseDto
            {
                IsSuccess = true,
                Data = viewType
            };
        }

        public ViewType? GetViewTypeByRolCode(string roleCode) =>
            roleCode switch
            {
                "ADM" => ViewType.Administrador,
                "EST" => ViewType.Estudiante,
                _ => null
            };

        public string GetRolCodeByViewType(ViewType viewType) =>
            viewType switch
            {
                ViewType.Administrador => "ADM",
                ViewType.Estudiante => "EST",
                _ => throw new ArgumentException("Tipo de vista no reconocido")
            };

        public async Task<bool> IsAvailableUsername(string username) =>
            await signUpService.IsAvailableUsername(username);

        public async Task<ResponseDto> RegisterUser(string username, string password, string roleCode) =>
            await signUpService.RegisterUser(username, password, roleCode);
    }
}
