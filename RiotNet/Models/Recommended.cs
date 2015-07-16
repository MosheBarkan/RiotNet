﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace RiotNet.Models
{
    /// <summary>
    /// Represents a recommended item set.
    /// </summary>
    public class Recommended
    {
        /// <summary>
        /// Gets or sets the blocks (or groups of items) in this item set.
        /// </summary>
        public List<Block> Blocks { get; set; }

        /// <summary>
        /// Gets or sets the champion name for the current item set.
        /// </summary>
        public string Champion { get; set; }

        /// <summary>
        /// Gets or sets the map for which the current item set applies.
        /// </summary>
        public string Map { get; set; }

        /// <summary>
        /// Gets or sets the game mode for which the current item set applies.
        /// </summary>
        public string Mode { get; set; }

        public bool Priority { get; set; }

        /// <summary>
        /// Gets or sets the title of the item set.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the type of teh item set.
        /// </summary>
        public string Type { get; set; }

#if DB_READY
        /// <summary>
        /// Gets or sets the ID of the current item set. This does NOT come from the Riot API; it is used as a key when storing this object in a database.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int Id { get; set; }
#endif
    }
}
