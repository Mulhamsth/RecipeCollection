using System.ComponentModel.DataAnnotations;

namespace Model.Entities;

public class Recipe
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> Ingredients { get; set; }
    public List<string> Instructions { get; set; }
    public double CookingTime { get; set; }
    public  Difficulty DifficultyLevel { get; set; }
    public List<Category> Categories { get; set; }
}

public enum Difficulty
{
    Hard,
    Middle,
    Easy
}