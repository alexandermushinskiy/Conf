namespace Conf.Management.Extensibility.Providers
{
    public interface IAccessCodeProvider
    {
        string Generate(int length = 5);
    }
}