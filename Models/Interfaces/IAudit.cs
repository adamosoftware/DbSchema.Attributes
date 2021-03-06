﻿using AO.Models.Enums;

namespace AO.Models.Interfaces
{
    public interface IAudit
    {
        /// <summary>
        /// Called right before a row is updated or inserted.
        /// Use this to record any audit tracking or time stamp data on a row
        /// </summary>
        void Stamp(SaveAction saveAction, IUserBase user);
    }
}
