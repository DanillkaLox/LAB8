using LAB8.Library.IService;

namespace LAB8.Library.Services
{
    public class SearchService : BaseService, ISearchService
    {
        private readonly IUserService _userService;
        private readonly IDocumentService _documentService;
        
        public SearchService(IUserService userService, IDocumentService documentService)
        {
            _userService = userService;
            _documentService = documentService;
        }

        public void SearchUsersByKeyword(string keyword)
        {
            var users = _userService.GetAllUsers();
            var matchingUsers = users.FindAll(u => u.FirstName.Contains(keyword) || u.LastName.Contains(keyword) || u.AcademicGroup.Contains(keyword));
            foreach (var user in matchingUsers)
            {
                Console.WriteLine(user);
            }
        }

        public void SearchDocumentsByKeyword(string keyword)
        {
            var documents = _documentService.GetAllDocuments();
            var matchingDocuments = documents.FindAll(d => d.Title.Contains(keyword) || d.Author.Contains(keyword));
            foreach (var document in matchingDocuments)
            {
                Console.WriteLine(document);
            }
        }
    }
}