using AnkiNet;
using CommandLine;
using LanguageReactorToAnki;
using System.Linq;
using System.Text.Json;

#if !DEBUG
await Parser.Default.ParseArguments<CommandLineOptions>(args)
    .WithParsedAsync(async o =>
    {
        var fileName = o.Input;
        var outputFileName = o.Output;
#endif

#if DEBUG
var fileName = "lln_json_items_2025-6-1_569243.json";
var outputFileName = "testt.apkg";
#endif

var json = File.ReadAllText(fileName);
var savedWords = JsonSerializer.Deserialize<ExportedWord[]>(json);
var cardDtos = savedWords.Select(x => new CardDto(x.word.text, x.wordTranslationsArr.Select((x, i) => $"{i + 1}. {x}").Implode("<br/>"))).ToList();
var ankiCollection = cardDtos.ToAnkiCollection(Path.GetFileNameWithoutExtension(outputFileName));
await AnkiFileWriter.WriteToFileAsync(outputFileName, ankiCollection);

#if !DEBUG
});
#endif
