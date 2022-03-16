using Application.DTOs;
using MediatR;

namespace Application.Features.LeaveTypes.Request;

public class GetLeaveTypeDetailRequest:IRequest<LeaveTypeDto>
{
    public int Id { get; set; }
     
}