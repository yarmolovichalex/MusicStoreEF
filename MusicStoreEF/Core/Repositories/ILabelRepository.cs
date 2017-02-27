using MusicStoreEF.Core.Models;

namespace MusicStoreEF.Core.Repositories
{
    public interface ILabelRepository
    {
        Label GetById(int labelId);
        void RemoveAll();
    }
}