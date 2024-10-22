namespace SolidTech.Business.Interfaces
{
    public interface IMessageService
    {
        List<MessageDto> Messages();

        int AddMessage(MessageDto messageDto);
    }

}