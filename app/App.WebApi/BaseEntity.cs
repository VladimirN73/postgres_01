namespace App.WebApi;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    public string UpdatedBy { get; set; } = "";
    public string AddedBy { get; set; } = "";
    public DateTime AddedDate { get; set; } = DateTime.UtcNow;
    public int Status { get; set; } = 1;
}

public class Team : BaseEntity
{
    public Team()
    {
        Drivers = new HashSet<Driver>();
    }

    public string Name { get; set; } = "";
    public string Year { get; set; } = "";

    public string Info { get; set; } = "";
    public DateOnly? OrderDate { get; set; }

    public virtual ICollection<Driver> Drivers { get; set; }
}

public class Driver : BaseEntity
{
    public Guid TeamId { get; set; }
    public string Name { get; set; } = "";
    public virtual Team Team { get; set; }
}