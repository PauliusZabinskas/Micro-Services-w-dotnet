
```c#
using System.ComponentModel.DataAnnotations.Schema;

  

namespace Code.backend.api.carsite.src.Entities;

  

// add an action for DbContext

[Table("Items")]

public class Item

{

    public Guid Id { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public string Color { get; set; }

    public int Mileage { get; set; }

    public string ImageUrl { get; set; }

  

    // nav property

    // these are properties used to create one-to-one relashion

    public Auction Auction {set; get;}

    public Guid AuctionID { get; set; }

}
```
