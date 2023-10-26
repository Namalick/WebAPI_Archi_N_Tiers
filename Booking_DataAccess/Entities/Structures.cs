using System;
using System.Collections.Generic;

namespace Booking_DataAccess.Entities;

public partial class Structures
{
    public Guid idStructure { get; set; }

    public string nomStructure { get; set; } = null!;

    public string? adresseStructure { get; set; }

    public string? complementAdresseStructure { get; set; }

    public string? codePostalStructure { get; set; }

    public string? villeStructure { get; set; }

    public string? telephoneStructure { get; set; }

    public string? emailStructure { get; set; }
}
