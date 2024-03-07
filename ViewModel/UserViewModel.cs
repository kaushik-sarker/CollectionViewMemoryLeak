using CollectionViewMemoryLeak.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewMemoryLeak.ViewModel
{
    public partial class UserViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<User> users;
        int counter = 1;

        public void LoadData()
        {
            if(Users != null)
            {
                Users.Clear();
            }

            Users = Enumerable.Range(0, 500).Select((ind) =>
            {
                return new User
                {
                    FirstName = $"For Click {counter} FirstName {ind}  ",
                    LastName = $"Lastname {ind} "
                };
            }).ToList();

            counter++;
        }
    }
}
