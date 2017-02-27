using MusicStoreEF.Models;

namespace MusicStoreEF.Repositories
{
    public interface ILabelRepository
    {
        Label GetById(int labelId);
        void RemoveAll();
    }
}