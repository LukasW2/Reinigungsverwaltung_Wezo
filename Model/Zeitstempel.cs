using System.ComponentModel.DataAnnotations;

namespace Reinigungsverwaltung.Model;

public record Zeitstempel(DateTime date, int duration, [MaxLength(255)] string description = "");