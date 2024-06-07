namespace LAB8.Library.IService;

public interface ISearchService
{
    void SearchUsersByKeyword(string keyword);
    void SearchDocumentsByKeyword(string keyword);
}