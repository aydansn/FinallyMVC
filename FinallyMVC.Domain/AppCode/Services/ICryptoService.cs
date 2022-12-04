using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.AppCode.Services
{
    public interface ICryptoService
    {
        string Decrypt(string value);
        string Encrypt(string value, bool appliedUrlEncode = false);
        string ToMd5(string value);
    }
}
