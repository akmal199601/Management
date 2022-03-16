using Domain.Common;

namespace Domain;

public class LeaveRequest : BaseDomainEntity
{
    public int Id { get; set; }
    public DateTime StartData { get; set; }
    public DateTime EndData { get; set; }
    public LeaveType LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public DateTime DateRequested { get; set; }
    public string RequestComments { get; set; }
    public DateTime DateActioned { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
}