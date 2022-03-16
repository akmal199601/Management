using Application.DTOs;
using MediatR;

namespace Application.Features.LeaveTypes.Request;

public class GetLeaveTypeListRequest:IRequest<List<LeaveTypeDto>>
{
    
}