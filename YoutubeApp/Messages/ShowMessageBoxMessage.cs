﻿using CommunityToolkit.Mvvm.Messaging.Messages;
using MsBox.Avalonia.Enums;

namespace YoutubeApp.Messages;

public class ShowMessageBoxMessage : AsyncRequestMessage<ButtonResult>
{
    public required string Title { get; init; }
    public required string Message { get; init; }
    public required ButtonEnum ButtonDefinitions { get; init; }
    public required Icon Icon { get; init; }
}