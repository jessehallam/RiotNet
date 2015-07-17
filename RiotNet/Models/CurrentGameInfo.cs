﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RiotNet.Models
{
    public class CurrentGameInfo
    {
        /// <summary>
        /// Gets or sets the list of banned champion information.
        /// </summary>
        public List<BannedChampion> BannedChampions { get; set; }

        /// <summary>
        /// Gets or sets the game Id.
        /// </summary>
        [Key]
        public long GameId { get; set; }

        /// <summary>
        /// Gets or sets the amount of time in seconds that has passed since the game started.
        /// </summary>
        public long GameLength { get; set; }

        // TODO: add game mode one richard has pushed...

        /// <summary>
        /// Gets or sets the queue type.
        /// </summary>
        public QueueType GameQueueConfigId { get; set; }

        /// <summary>
        /// Gets or sets the game start time represented in epoch milliseconds.
        /// </summary>
        public DateTime GameStartTime { get; set; }

        /// <summary>
        /// Gets of sets the game type.
        /// </summary>
        public GameType GameType { get; set; }

        /// <summary>
        /// Gets or sets the map id.
        /// </summary>
        public long MapId { get; set; }

        /// <summary>
        /// Gets or sets the observer information.
        /// </summary>
        public Observer observers { get; set; }

        /// <summary>
        /// Gets or sets the participant information.
        /// </summary>
        public List<CurrentGameParticipant> participants { get; set; }

        /// <summary>
        /// Gets or sets the ID of the platform on which the game is being played.
        /// </summary>
        public string PlatformId { get; set; }
    }
}
