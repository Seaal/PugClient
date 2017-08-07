﻿using Pug.Client.ViewModels.Phases;
using System.Collections.Generic;

namespace Pug.Client.ViewModels
{
    public class PickUpGame
    {
        public string Id { get; set; }
        public IEnumerable<string> Path { get; set; }
        public BasePugPhase CurrentPhase { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Player> PickablePlayers { get; set; }
    }
}