using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace SmartPayHub.Configuration
{
    public interface IAuthenticationService
    {
        Task<(bool Success, string Token, string RefreshToken)> AuthenticateUserAsync(string email, string password);
        Task<(bool Success, string Token, string RefreshToken)> RefreshTokenAsync(string accessToken, string refreshToken);
        Task<bool> RevokeRefreshTokenAsync(string refreshToken);
        string HashPassword(string password);
        bool VerifyPassword(string hashedPassword, string providedPassword);
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _configuration;
        // Normalmente, voc� injetaria seu reposit�rio de usu�rios aqui
        // private readonly IUserRepository _userRepository;

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
            // _userRepository = userRepository;
        }

        public async Task<(bool Success, string Token, string RefreshToken)> AuthenticateUserAsync(string email, string password)
        {
            // No c�digo real, voc� buscaria o usu�rio do banco de dados
            // var user = await _userRepository.GetUserByEmailAsync(email);
            // if (user == null) return (false, string.Empty, string.Empty);
            // 
            // if (!VerifyPassword(user.PasswordHash, password))
            //    return (false, string.Empty, string.Empty);
            //
            // var roles = await _userRepository.GetUserRolesAsync(user.Id);
            //
            // var token = Authentication.GenerateToken(user.Id, user.Email, user.Name, roles.ToArray(), _configuration);
            // var refreshToken = Authentication.GenerateRefreshToken();
            //
            // // Salvar o refresh token no banco de dados associado ao usu�rio
            // user.RefreshToken = refreshToken;
            // user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7); // Token de atualiza��o v�lido por 7 dias
            // await _userRepository.UpdateUserAsync(user);
            //
            // return (true, token, refreshToken);
            
            // Esta � uma implementa��o de exemplo. Em produ��o, use o c�digo comentado acima
            throw new NotImplementedException("M�todo de autentica��o precisa ser implementado com seu reposit�rio de usu�rios");
        }

        public async Task<(bool Success, string Token, string RefreshToken)> RefreshTokenAsync(string accessToken, string refreshToken)
        {
            // No c�digo real, voc� validaria o token e buscaria o usu�rio
            // try
            // {
            //     var principal = Authentication.GetPrincipalFromExpiredToken(accessToken, _configuration);
            //     var userId = int.Parse(principal.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");
            //     
            //     var user = await _userRepository.GetUserByIdAsync(userId);
            //     if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            //         return (false, string.Empty, string.Empty);
            //     
            //     var email = principal.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;
            //     var name = principal.FindFirst(ClaimTypes.Name)?.Value ?? string.Empty;
            //     var roles = await _userRepository.GetUserRolesAsync(userId);
            //     
            //     var newToken = Authentication.GenerateToken(userId, email, name, roles.ToArray(), _configuration);
            //     var newRefreshToken = Authentication.GenerateRefreshToken();
            //     
            //     // Atualizar o refresh token no banco de dados
            //     user.RefreshToken = newRefreshToken;
            //     user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);
            //     await _userRepository.UpdateUserAsync(user);
            //     
            //     return (true, newToken, newRefreshToken);
            // }
            // catch
            // {
            //     return (false, string.Empty, string.Empty);
            // }
            
            // Esta � uma implementa��o de exemplo. Em produ��o, use o c�digo comentado acima
            throw new NotImplementedException("M�todo de atualiza��o de token precisa ser implementado com seu reposit�rio de usu�rios");
        }

        public async Task<bool> RevokeRefreshTokenAsync(string refreshToken)
        {
            // No c�digo real, voc� invalidaria o refresh token do usu�rio
            // var user = await _userRepository.GetUserByRefreshTokenAsync(refreshToken);
            // if (user == null) return false;
            // 
            // user.RefreshToken = null;
            // user.RefreshTokenExpiryTime = DateTime.UtcNow;
            // await _userRepository.UpdateUserAsync(user);
            // return true;
            
            // Esta � uma implementa��o de exemplo. Em produ��o, use o c�digo comentado acima
            throw new NotImplementedException("M�todo de revoga��o de token precisa ser implementado com seu reposit�rio de usu�rios");
        }

        public string HashPassword(string password)
        {
            // Implementa��o b�sica de hash de senha usando HMACSHA512
            // Em produ��o, considere usar o Identity para gerenciamento de senhas
            using var hmac = new HMACSHA512();
            var salt = hmac.Key;
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            
            // Combina o salt e o hash em uma �nica string codificada em base64
            var combinedBytes = new byte[salt.Length + hash.Length];
            Array.Copy(salt, 0, combinedBytes, 0, salt.Length);
            Array.Copy(hash, 0, combinedBytes, salt.Length, hash.Length);
            
            return Convert.ToBase64String(combinedBytes);
        }

        public bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            // Decodifica a string combinada de salt e hash
            var combinedBytes = Convert.FromBase64String(hashedPassword);
            
            // Extrai o salt (os primeiros 64 bytes)
            var salt = new byte[64]; // HMACSHA512 usa uma chave de 64 bytes
            Array.Copy(combinedBytes, 0, salt, 0, salt.Length);
            
            // Extrai o hash original
            var originalHash = new byte[combinedBytes.Length - salt.Length];
            Array.Copy(combinedBytes, salt.Length, originalHash, 0, originalHash.Length);
            
            // Recalcula o hash com o salt original e a senha fornecida
            using var hmac = new HMACSHA512(salt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(providedPassword));
            
            // Compara os hashes
            return originalHash.SequenceEqual(computedHash);
        }
    }
}