﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Catalog
{
    public class Effect : RiotGamesObject
    {
        #region Constructors and Callbacks

        public Effect(TypedObject result)
        {
            base.SetFields<Effect>(this, result);
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// ID number of effect.
        /// </summary>
        [InternalName("effectId")]
        public int EffectId { get; set; }

        /// <summary>
        /// The LOL game code of the effect.
        /// </summary>
        [InternalName("gameCode")]
        public string GameCode { get; set; }

        /// <summary>
        /// The name of the effect.
        /// </summary>
        [InternalName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Value of the item effect (set to null?).
        /// </summary>
        [InternalName("categoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// The type of the rune.
        /// </summary>
        [InternalName("runeType")]
        public RuneType RuneType { get; set; }

        #endregion
    }
}
