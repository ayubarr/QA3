namespace QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces
{
    public interface IBaseResponse<T>
    {
        string Description { get; }
        T Data { get; }
    }
}
