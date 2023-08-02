﻿using System.Collections.Generic;

namespace Audacia.DataAccess.Specifications.Ordering;

/// <summary>
/// Exposes a collection of <see cref="OrderStep"/> objects which contain the rules needed to sort a collection of objects of type <see cref="T"/>.
/// </summary>
public interface IOrderSpecification<T>
{
    /// <summary>
    /// Gets the <see cref="OrderStep"/> objects that contain the sorting rules.
    /// </summary>
    IEnumerable<OrderStep> OrderSteps { get; }
}