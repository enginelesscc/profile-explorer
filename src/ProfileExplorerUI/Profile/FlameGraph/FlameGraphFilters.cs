// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
using System.Collections.Generic;
using static ProfileExplorer.UI.Profile.FlameGraphFilters;

namespace ProfileExplorer.UI.Profile;

public class FlameGraphFilters {
  public struct FilterInfo<T> {
    public int Depth;
    public T Value;
  }
  public List<FilterInfo<string>> FilteredModules = new();
}
