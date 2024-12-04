namespace MusiKup.Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;
        else if (obj is not BaseEntity baseEntity)
            return false;
        else if (baseEntity.Id != Id)
            return false;
        else if (this.GetHashCode() != baseEntity.GetHashCode())
            return false;
        return true;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        var props = GetType().GetProperties();
        var values = props.Select(prop => $"{prop.Name}: {prop.GetValue(this) ?? "null"}");
        return string.Join(" ", values);
    }

    public static bool operator ==(BaseEntity a, BaseEntity b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(BaseEntity a, BaseEntity b)
    {
        return !(a == b);
    }
}