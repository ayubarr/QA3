namespace QualityAssurance2.Data.Serveces.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Description { get; set; }

        public T Data { get; set; }
    }
    public interface IBaseResponse<T>
    {
        string Description { get; }
        T Data { get; }
    }
}
