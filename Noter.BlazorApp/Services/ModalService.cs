using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace Noter.BlazorApp.Services
{
    public class ModalService : IModalService
    {
        public Blazored.Modal.Services.IModalService Modal { get; set; }

        public ModalService(Blazored.Modal.Services.IModalService modal)
        {
            this.Modal = modal;
        }

        public IModalReference Show<TComponent>(string Title, int Id = 0) where TComponent : IComponent
        {
            var options = new ModalOptions();

            options.Class = "blazored-modal w-50 ";

            var paramz = new ModalParameters();

            paramz.Add("Id", Id);

            return Modal.Show<TComponent>(Title, options: options, parameters: paramz);
        }
    }
}
