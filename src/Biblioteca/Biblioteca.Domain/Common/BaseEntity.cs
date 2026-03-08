namespace Biblioteca.Domain.Common;

public class BaseEntity
{
    public bool Active { get; private set; } = true;
    public DateTime CreatedAt { get; private set; } =  DateTime.Now;
    
    public void Deactivate() => Active = false;
    public void Activate() => Active = true;
    
}