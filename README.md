# ClubHouse

This is a .NET Standard library for the ClubHouse API. Non-blocking async turtles all the way down!

```
install-package ClubHouse
```
or 
```
dotnet add package ClubHouse
```

## Usage

```csharp
var client = new ClubHouseClient("yourApiKey");
```

### Let's make a new story

```csharp
await client.Stories.Create(new Story {
    Name = "My new story",
    ProjectId = 123 //associated project
});
```