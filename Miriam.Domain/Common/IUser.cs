namespace Miriam.Domain.Common;

public interface IUser
{
    public string? UserName { get; set; }
    public string Password { get; set; }
    public string? NormalizedUserName { get; set; }
}