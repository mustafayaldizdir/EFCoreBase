using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreBase.Application.Dto
{
    public class ResponseModel<T> where T : class
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; private set; }

        public bool IsSuccess { get; private set; }

        public List<string> Errors{ get; set; }

        public static ResponseModel<T> Success(T data,int statusCode)
        {
            return new ResponseModel<T> { StatusCode = statusCode, Data = data,IsSuccess = true };
        }

        public static ResponseModel<T> Success(int statusCode)
        {
            return new ResponseModel<T> { Data = default(T), StatusCode = statusCode, IsSuccess = true };
        }

        public static ResponseModel<T> Fail(List<string> errors,int statusCode)
        {
            return new ResponseModel<T>
            {
                Errors = errors,
                StatusCode = statusCode,
                IsSuccess = false
            };
        }

        public static ResponseModel<T> Fail(string error,int statusCode)
        {

            return new ResponseModel<T> 
            { 
                Errors = new List<string> { error }, 
                StatusCode = statusCode, 
                IsSuccess = false 
            };
        }
    }
}
