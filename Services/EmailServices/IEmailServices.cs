namespace Email__And__Sms__Notification.Services.EmailServices
{
    public interface IEmailServices
    {
        void SendEmail(EmailDto request);
    }
}
