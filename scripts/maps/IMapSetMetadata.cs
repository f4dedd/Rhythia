using System.Collections.Generic;

namespace Rhythia.Maps;

public interface IMapSetMetadata
{
    public int Version { get; }

    public string AudioExtension { get; }

    public string Artist { get; }

    public string RomanizedArtist { get; }

    public string Title { get; }

    public string RomanizedTitle { get; }

    public IList<IMapInfo> Difficulties { get; }
}