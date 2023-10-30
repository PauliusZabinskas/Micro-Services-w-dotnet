```cs
using AutoMapper;

using Code.backend.api.carsite.src.DTOs;

using Code.backend.api.carsite.src.Entities;

  

namespace Code.backend.api.carsite.src.RequestHelpers;

  

public class MappingProfiles : Profile

{

    public MappingProfiles()

    {

        CreateMap<Auction, AuctionDTO>().IncludeMembers(x => x.Item);

        CreateMap<Item, AuctionDTO>();

        CreateMap<CreateAuctionDTO, Auction>()

            .ForMember(d => d.Item, o => o.MapFrom(s => s));

  

        CreateMap<CreateAuctionDTO, Item>();

  

    }

}
```