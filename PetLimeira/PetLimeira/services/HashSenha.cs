using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PetLimeira.services
{
    public class HashSenha
    {
        // Método que recebe a senha informada e devolve o hash em texto
        public static string Gerar(string senha)
        {
            // Tranforma a senha em bytes e calcula o hash

            byte[] bytes = Encoding.UTF8.GetBytes(senha);
            byte[] hash = SHA256.HashData(bytes);

            // Converter o hash para uma string hexadecimal
            return Convert.ToHexString(hash);

        }

        public static bool Verificar(string senha, string hashArmazenado)
        {
            // Gera a senha, compara e retorna verdadeiro ou falso
            return Gerar(senha) == hashArmazenado;
        }

    }
}
