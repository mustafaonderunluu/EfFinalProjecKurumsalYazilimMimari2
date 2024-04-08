using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel Voidler için Baslangıc
    public interface IResult
    {

        bool Success { get; } //Sadece okunabilir 
        string Message { get; }


    }
}
