using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolData.Models;

public class Class
{
    public int Id { get; set; }
    public string? classe { get; set; }
    public string? specializzazione { get; set; }

}
