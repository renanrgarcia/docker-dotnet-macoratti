namespace ApiMediatR.Services
{
    public interface IValidationService
    {
        void Validate<T>(T obj);
    }
}
