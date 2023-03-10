using AyubArbievQualityAssurance2.Data.Models.Common;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;

namespace QualityAssurance2.Data.Serveces.Implementations.Response
{
    public class BaseResponse<T> : IBaseResponse<T> 
    {
        public string Description { get; set; }

        public T Data { get; set; }
    }

}
