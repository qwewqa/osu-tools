// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using JetBrains.Annotations;
using McMaster.Extensions.CommandLineUtils;

namespace PerformanceCalculator.Simulate
{
    [Command(Name = "performance", Description = "Computes the performance (pp) of a simulated play.")]
    [Subcommand("osu", typeof(OsuSimulateCommand))]
    [Subcommand("taiko", typeof(TaikoSimulateCommand))]
    [Subcommand("mania", typeof(ManiaSimulateCommand))]
    public class SimulateListingCommand
    {
        [UsedImplicitly]
        public int OnExecute(CommandLineApplication app, IConsole console)
        {
            console.WriteLine("You must specify a subcommand.");
            app.ShowHelp();
            return 1;
        }
    }
}
