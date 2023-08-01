using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Discoteque.Data.Models;

public class Song : BaseEntity<int>
{
    /// <summary>
    /// Name of the Album
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// Year the albums was published
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// The <see cref="Genres" /> the album belongs to 
    /// </summary>
    
    [ForeignKey("Id")]
    public int? AlbumId { get; set; }

    /// <summary>
    /// The <see cref="Artist"/> Entity this album is refering to
    /// </summary> <summary>
    public virtual Album? Album { get; set; }
}

/// <summary>
/// A collection of musical genres
/// </summary> <summary>
