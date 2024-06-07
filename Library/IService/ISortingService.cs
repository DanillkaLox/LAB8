namespace LAB8.Library.IService;

public interface ISortingService
{
    void SortUsersByFirstName(bool ascending);
    void SortUsersByLastName(bool ascending);
    void SortUsersByAcademicGroup(bool ascending);
    void SortDocumentsByTitle(bool ascending);
    void SortDocumentsByAuthor(bool ascending);
}