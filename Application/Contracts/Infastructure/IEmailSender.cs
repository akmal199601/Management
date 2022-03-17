using Application.Models;

namespace Application.Contracts.Infastructure;

public interface IEmailSender
{
    Task<bool> SendEmail(Email email);
}