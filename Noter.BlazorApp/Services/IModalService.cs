using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace Noter.BlazorApp.Services
{
    public interface IModalService
    {
        Blazored.Modal.Services.IModalService Modal { get; set; }

        IModalReference Show<TComponent>(string Title, int Id = 0) where TComponent : IComponent;
    }
}