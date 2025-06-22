using EventEase.Models;

namespace EventEase.Services
{
    public class UserSession
    {
        public RegistrationModel? RegisteredUser { get; set; }
        public void Clear() => RegisteredUser = null;
    }
}