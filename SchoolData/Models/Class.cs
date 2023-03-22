using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolData.Models;

public class Class
{
    public int Id { get; set; }
    public string? Classe { get; set; }
    public string? Specializzazione { get; set; }

}
