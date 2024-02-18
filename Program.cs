using CommandApp.App;
using CommandApp.Command;
using MorseTranslateApp;

ICommandCollection commands = new DefaultCommandCollection();
commands.Register(new TranslateCommand());
commands.Register(new HistoryCommand());

IApp app = new DefaultApp(commands);
app.Context.Add("history", new List<Translation>());
app.Start();