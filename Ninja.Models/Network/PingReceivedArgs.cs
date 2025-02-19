﻿using System;

namespace Ninja.Models.Network
{
    /// <summary>
    ///     Contains the information of a received ping in a <see cref="Ping" />.
    /// </summary>
    public class PingReceivedArgs : EventArgs
    {
        /// <summary>
        ///     Creates a new instance of <see cref="PingReceivedArgs" /> with the given <see cref="PingInfo" />.
        /// </summary>
        /// <param name="args"></param>
        public PingReceivedArgs(PingInfo args)
        {
            Args = args;
        }

        /// <summary>
        ///     Ping information.
        /// </summary>
        public PingInfo Args { get; }
    }
}