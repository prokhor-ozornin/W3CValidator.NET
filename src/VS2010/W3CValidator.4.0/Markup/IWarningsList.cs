﻿using System.Collections.Generic;

namespace W3CValidator.Markup
{
  /// <summary>
  ///   <para>Logical group of validation warnings.</para>
  /// </summary>
  public interface IWarningsList
  {
    /// <summary>
    ///   <para>Total number of validation warnings.</para>
    /// </summary>
    int Count { get; }

    /// <summary>
    ///   <para>Collection of validation warnings.</para>
    /// </summary>
    IEnumerable<IIssue> Warnings { get; }
  }
}