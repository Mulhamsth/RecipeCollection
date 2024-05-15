using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Model.Entities;

public class Category
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("NAME")]
    public string Name { get; set; }
    
    [Column("DESCRIPTION")]
    public string Description { get; set; }
    
    public List<Recipe> Recipes { get; set; }
}