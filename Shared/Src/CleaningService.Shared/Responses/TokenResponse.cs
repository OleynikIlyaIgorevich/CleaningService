namespace CleaningService.Shared.Responses;

public record TokenResponse(
    string AuthToken,
    string RefreshToken);