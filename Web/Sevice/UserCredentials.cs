using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Web.Sevice;

public class UserCredentials
{
    public string email { get; set; }
    public string password { get; set; }
}