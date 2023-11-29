using System.ComponentModel.DataAnnotations;


namespace BlazorApp.Movie;
public class Movie {
    public int Id {get;set;}

    public string? Title {get;set;}
    public string? Genre {get;set;}
}