using Balta.SharedContext;

namespace Balta.SubcriptionContext 
{
    public class User :  Base 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}