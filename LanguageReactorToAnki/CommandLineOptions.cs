using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageReactorToAnki
{
    public class CommandLineOptions
    {
        [Option("input", Required = true, HelpText = "The input JSON file.")]
        public string Input { get; set; }

        [Option("output", Required = true, HelpText = "The output .apkg file.")]
        public string Output { get; set; }
    }
}
