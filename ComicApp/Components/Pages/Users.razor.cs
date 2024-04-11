using Microsoft.AspNetCore.Components;
//using ComicApp.Contracts;

namespace ComicApp.Components.Pages
{
    public class UsersBase : ComponentBase
    {
        //private readonly HttpClient _httpClient;
        //private readonly NavigationManager _navigationManager;

        //public UsersBase(HttpClient http, NavigationManager navigationManager)
        //{
        //    _httpClient = http;
        //    _navigationManager = navigationManager;
        //}

        protected string welcomeText = "Welcome to 'Users'";

        //public async Task CreateUser(CreateUserDTO createUserDTO)
        //{
        //    var result = await _httpClient.PostAsJsonAsync("api/user", createUserDTO);
        //}
    }
}