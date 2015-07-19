﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Models
{
    /// <summary>
    /// Contains summoner information.
    /// </summary>
    public class Summoner
    {
        /// <summary>
        /// Gets or sets the summoner's summoner ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the summoner's name.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the ID of the summoner's summoner icon.
        /// </summary>
        public int ProfileIconId { get; set; }

        /// <summary>
        /// Gets or sets the date the summoner was last modified.
        /// The summoner is modified by the following events: changing summoner icon,
        /// playing a tutorial, finishing a game, or changing summoner name.
        /// </summary>
        public DateTime RevisionDate { get; set; }

        /// <summary>
        /// Gets or sets the summoner's summoner level.
        /// </summary>
        public long SummonerLevel { get; set; }
    }
}
