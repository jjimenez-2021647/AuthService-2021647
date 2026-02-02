using System;
using Microsoft.Extensions.Logginf;

namespace AuthServiceIN6BM.Application.Extensions;

//"partial" permite que pueda seguir trabajando en otra clase y luego al momento de ejecutar los unifica
public static partial class LoggerExtensions
{
    [LoggerMessage(
        EventId = 1001,
        Level = LogLevel.Information,
        Message = "User {Username} registered siccessfuly"
    )]

    public statis partial void LogUserRegistered(this ILogger logger, string username);

    [LoggerMessage(
        EventId = 1002,
        Level = LogLevel.Information,
        Message = "User login succeeded"
    )]

    public statis partial void LogUserLoggedIn(this ILogger logger);

    [LoggerMessage(
        EventId = 1003,
        Level = LogLevel.Warning,
        Message = "Failed login attempt"
    )]

    public statis partial void LogFailedLoginAttempt(this ILogger logger);

    [LoggerMessage(
        EventId = 1004,
        Level = LogLevel.Warning,
        Message = "Registration rejected: email already exists"
    )]

    public statis partial void LogRegistrationWithExistingEmail(this ILogger logger);

    [LoggerMessage(
        EventId = 1005,
        Level = LogLevel.Warning,
        Message = "Registration rejected: username already exists"
    )]

    public statis partial void LogRegistrationWithExistingUsername(this ILogger logger);

    [LoggerMessage(
        EventId = 1006,
        Level = LogLevel.Error,
        Message = "Error uploading profile image"
    )]

    public statis partial void LogImageUploadError(this ILogger logger);
}