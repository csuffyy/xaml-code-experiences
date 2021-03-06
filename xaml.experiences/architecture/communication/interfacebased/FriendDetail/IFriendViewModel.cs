using System.Collections.ObjectModel;
using interfacebased.DataModel;

namespace interfacebased.FriendDetail
{
    public interface IFriendViewModel
    {
        HairColor HairColor { get; set; }
        string LastName { get; }
        string FirstName { get; }
        ObservableCollection<HairColor> AvailableColors { get; }
    }
}