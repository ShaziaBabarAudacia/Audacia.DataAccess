﻿using System;

namespace Audacia.DataAccess.EntityFrameworkCore.Triggers
{
    public interface ICreatable<TUserIdentifier>
    {
        DateTimeOffset Created { get; set; }
        TUserIdentifier CreatedBy { get; set; }
    }
}