using Loris_Blazor.Models;
using Blazored.LocalStorage;

namespace Loris_Blazor.Services
{
    public class AuthService
    {
        private readonly ILocalStorageService _localStorage;
        public User? CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;

        public AuthService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task Login(User user)
        {
            CurrentUser = user;
            await _localStorage.SetItemAsync("currentUser", user);
        }

        public async Task Logout()
        {
            CurrentUser = null;
            await _localStorage.RemoveItemAsync("currentUser");
        }

        public async Task LoadUserFromStorage()
        {
            CurrentUser = await _localStorage.GetItemAsync<User>("currentUser");
        }
    }
}

