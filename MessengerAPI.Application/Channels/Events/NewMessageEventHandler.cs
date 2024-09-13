using System.Text.Json;
using AutoMapper;
using MediatR;
using MessengerAPI.Application.Common;
using MessengerAPI.Application.Common.Interfaces;
using MessengerAPI.Application.Schemas.Notifications;
using MessengerAPI.Domain.ChannelAggregate.Events;

namespace MessengerAPI.Application.Channels.Events;

public class NewMessageEventHandler : INotificationHandler<NewMessageCreated>
{
    private readonly INotificationService _notificationService;
    private readonly IMapper _mapper;

    public NewMessageEventHandler(INotificationService notificationService, IMapper mapper)
    {
        _notificationService = notificationService;
        _mapper = mapper;
    }

    public async Task Handle(NewMessageCreated notification, CancellationToken cancellationToken)
    {
        var mapped = _mapper.Map<NewMessageNotificationSchema>(notification);
        var jsonMessage = JsonSerializer.Serialize(mapped, JsonOptions.Default);

        var recipientIds = notification.Channel.Members.Select(m => m.Id).ToList();

        var notificationMessage = new NotificationMessage(recipientIds, jsonMessage);

        await _notificationService.Notify(notificationMessage);
    }
}
