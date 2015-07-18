﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RiotNet.Models
{
    /// <summary>
    /// Contains team member information.
    /// </summary>
    public class TeamMemberInfo
    {
        /// <summary>
        /// Gets or sets the date this team member was invited to the team.
        /// </summary>
        public DateTime InviteDate { get; set; }

        /// <summary>
        /// Gets or sets the date this team member joined the team.
        /// </summary>
        public DateTime JoinDate { get; set; }

        /// <summary>
        /// Gets or sets this team member's player ID.
        /// </summary>
        public long PlayerId { get; set; }

        /// <summary>
        /// Gets or sets this team member's status.
        /// </summary>
        public String Status { get; set; }

#if DB_READY
        /// <summary>
        /// Gets or sets the ID of the current <see cref="TeamMemberInfo"/>. This does NOT come from the Riot API; it is used as a key when storing this object in a database.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int Id { get; set; }
#endif
    }
}