using Application.DTOs;
using Application.Features.LeaveTypes.Request;
using MediatR;

namespace Application.Features.LeaveTypes.Handlers.Queries;

public class GetLeaveTypeDetailRequestHandler:IRequestHandler<GetLeaveTypeDetailRequest,LeaveTypeDto>
{
    public Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}