﻿namespace Movie.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public byte[] HashedPassowrd { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime CreatedDate { get; set; }
    public Role Role { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }
    
}