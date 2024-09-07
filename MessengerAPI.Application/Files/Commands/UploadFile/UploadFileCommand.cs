using ErrorOr;
using MediatR;
using MessengerAPI.Domain.Common.Entities;
using MessengerAPI.Domain.User.ValueObjects;

namespace MessengerAPI.Application.Files.Commands.UploadFile;

public record UploadFileCommand(
    UserId Sub,
    Stream FileStream,
    string ContentType
) : IRequest<ErrorOr<FileData>>;
