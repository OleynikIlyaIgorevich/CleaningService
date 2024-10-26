namespace CleaningService.Shared.Requests;

public record RefreshTokenRequest(
    string AuthToken, 
    string RefreshToken);