using System.ComponentModel.DataAnnotations;

namespace Code.backend.api.carsite.src.DTOs;
 public class updateAuctionDTO
 {
    [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public string Color { get; set; }
    [Required]
    public int Mileage { get; set; }
 }