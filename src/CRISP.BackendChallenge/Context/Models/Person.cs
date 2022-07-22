using CRISP.Backend.Challenge.Context.Models;

namespace CRISP.Backend.Challenge.Context;


/// <summary>
/// Person Entity Model
/// </summary>
public class Person
{
    public Person()
    {
        // ReSharper disable once VirtualMemberCallInConstructor
        Logins = new HashSet<Login>();
    }

    /// <summary>
    /// Id of the person
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the person
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Navigation property to the logins of the person
    /// </summary>
    public  virtual ICollection<Login> Logins { get; set; }
}