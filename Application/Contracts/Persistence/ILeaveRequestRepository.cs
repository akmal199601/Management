using Domain;

namespace Application.Contracts.Persistence;

public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestWithDetail(int id);

    Task<List<LeaveRequest>> GetLeaveRequestWithDetails();

    Task<List<LeaveRequest>> GetLeaveRequestWithDetails(string userId);

    Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approvalStatus);
}