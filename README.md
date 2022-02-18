# TelegramToDiscordBot

## Configuration
You can set all tokens only in enviroment variables.

 - `DISCORD_TOKEN` - Discord **BOT** token, this required to send message to discord and create threads.
 - `TG_TOKEN` - Telegram bot token, required to read channel and repost it to discord!
 - `POST_CHANNEL_ID` - Discord channel id required to post messages.


## Requirements

### Bot
`SEND_MESSAGES` and `EMBED_LINKS` permissions to send messages and edit it.

### Building
To build required `.NET SDK 6`
You can build by following command
```
$ dotnet build . -c Release -out build/
```

## TODO
 - [X] Sending pictures from Telegram to Discord
 - [ ] Sending any messages from Discord Telegram
 - [ ] Sending Documents (Like audio files, other documents up to 8 MB)
 - [ ] Bridge between Threads and Comments section.
 - [X] Edit-message Bridge 
 - [X] Discord thread creating
