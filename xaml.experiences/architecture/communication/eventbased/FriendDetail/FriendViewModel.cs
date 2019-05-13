using System;
using System.Collections.ObjectModel;
using eventbased.DataModel;
using observingobjects;

namespace eventbased.FriendDetail
{
    public class FriendViewModel : BaseViewModel, IFriendViewModel
    {
        private Friend m_friend;

        public FriendViewModel(Friend friend)
        {
            m_friend = friend;
            AvailableColors = new ObservableCollection<HairColor>()
            {
                new HairColor("Black"),
                new HairColor("White"),
                new HairColor("Red"),
                new HairColor("Brown"),
                new HairColor("Green"),
                new HairColor("Pink"),
                new HairColor("Blue"),
                new HairColor("Yellow"),
            };
        }

        public event EventHandler HairColorChangedEvent;

        public string FirstName => m_friend.FirstName;
        public ObservableCollection<HairColor> AvailableColors { get; }

        public string LastName => m_friend.LastName;

        public HairColor HairColor
        {
            get => m_friend.HairColor;
            set
            {
                m_friend.HairColor = value;
                OnPropertyChanged();
                HairColorChangedEvent?.Invoke(this, null);
            }
        }
    }
}