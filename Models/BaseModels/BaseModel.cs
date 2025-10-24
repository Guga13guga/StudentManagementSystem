namespace StudentManagementSystem.Models.BaseModels;

/// <summary>
/// Base class for all models, providing a unique identifier.
/// </summary>
public abstract class BaseModel
{
    public Guid Id { get; set; }
}
