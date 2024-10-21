using System.Threading.Tasks;

namespace CmsProject.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}