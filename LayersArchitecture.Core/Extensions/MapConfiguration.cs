using AutoMapper;
using Layers.Core.Models;
using Layers.Dto.Dtos.UserDto;

namespace LayersArchitecture.Core.Extensions
{
	public class MapConfiguration : Profile
	{
		// Map Configuration

		public MapConfiguration()
		{
			// Mapping Transactions 

			CreateMap<UserListDto, User>().ReverseMap();
		}
	}
}
