using CrudApi.Dtos;

namespace CrudApi.SMTP.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(EmailDto emailDto);
    }
}
