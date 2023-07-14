﻿using ChatWeb3Frontend.Models;
using ChatWeb3Frontend.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace ChatWeb3Frontend.Pages
{
    public class UserDetailsBase : ComponentBase
    {
        [Inject]
        public IUserService UserService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public UpdateUser updateUser = new UpdateUser();
        public APIResponse response = new APIResponse();
        protected async Task UpdateUser_Click(UpdateUser update)
        {
            try
            {
                response = await UserService.UpdateAsync(update);
                if (response.Success)
                {
                    NavigationManager.NavigateTo("/home");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
