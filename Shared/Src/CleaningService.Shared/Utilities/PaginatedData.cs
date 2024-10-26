namespace CleaningService.Shared.Utilities;

public record PaginatedData<TItem>(
    IEnumerable<TItem> List,
    int TotalCount);
