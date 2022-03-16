using Application.DTOs.Common;

namespace Application.DTOs;

public class LeaveRequestListDto:BaseDto 
{
    public LeaveTypeDto LeaveType { get; set; }
    public DateTime DateRequested { get; set; }
    public bool? Approved { get; set; }
}