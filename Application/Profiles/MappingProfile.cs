using Application.DTOs;
using AutoMapper;
using Domain;

namespace Application.Persistence.Profiles;

public class MappingProfile:Profile 
{
    public MappingProfile()
    {
        CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
        CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap(); 
        CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
    }
} 