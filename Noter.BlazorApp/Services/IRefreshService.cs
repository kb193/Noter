
namespace Noter.BlazorApp.Services
{
    public interface IRefreshService
    {
        event Action RefreshRequested;

        void CallRequestRefresh();
    }
}