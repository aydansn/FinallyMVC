using FinallyMVC.Domain.AppCode.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.AppCode.Services
{
    public class CryptoService : ICryptoService
    {
        private readonly CryptoServiceOptions options;

        public CryptoService(IOptions<CryptoServiceOptions> options)
        {
            this.options = options.Value;
        }

        public string ToMd5(string value)
        {
            return value.ToMd5(options.SaltKey);
        }

        public string Encrypt(string value, bool appliedUrlEncode = false)   //123
        {
            return value.Encrypt(options.SymmetricKey, appliedUrlEncode);
        }

        public string Decrypt(string value)   //123
        {
            return value.Decrypt(options.SymmetricKey);
        }
    }


    public class CryptoServiceOptions
    {
        public string SaltKey { get; set; }
        public string SymmetricKey { get; set; }
    }
}
