namespace StudentManagementSystem.Models.BaseModels;

/// <summary>
/// Base class for models that require a Name property.
/// </summary>
public abstract class BaseExtention : BaseModel
{
    public string? Name { get; set; }
}
