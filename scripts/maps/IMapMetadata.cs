using System;
using System.Collections.Generic;

namespace Rhythia.Maps;

public interface IMapMetadata : IEquatable<IMapMetadata>
{
    public string AudioExtension { get; }

    public string Artist { get; }

    public string Title { get; }

    public IEnumerable<string> Mappers { get; }

    public string DifficultyName { get; }

    public int NoteCount { get; }
}