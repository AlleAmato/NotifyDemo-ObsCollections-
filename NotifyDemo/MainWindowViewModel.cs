using NotifyDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyDemo
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        #region List
        private List<User> _usersList;

		public List<User> UsersList
        {
			get { return _usersList; }
			set { _usersList = value; NotifyPropertyChanged("UsersList"); }
		}

		internal void AddList()
		{
            if (UsersList != null && UsersList.Count > 0)
            {
				UsersList.Add(new User { Username = "Carlo" });
            }
        }

		internal void LoadList()
		{
			UsersList = new List<User>
			{
				new User { Username = "Mario" },
				new User { Username = "Luigi" }
			};
		}

		internal void ModList()
		{
			if( UsersList!= null && UsersList.Count > 0 )
			{
				UsersList.FirstOrDefault().Username += "_mod";
			}
		}
        #endregion

        #region ObservableCollection
        private ObservableCollection<User> _usersObs;

        public ObservableCollection<User> UsersObs
        {
            get { return _usersObs; }
            set { _usersObs = value; NotifyPropertyChanged("UsersObs"); }
        }

        internal void AddObs()
        {
            if (UsersObs != null && UsersObs.Count > 0)
            {
                UsersObs.Add(new User { Username = "Carlo" });
            }
        }

        internal void LoadObs()
        {
            UsersObs = new ObservableCollection<User>
            {
                new User { Username = "Mario" },
                new User { Username = "Luigi" }
            };
            UsersObs.CollectionChanged += UsersObs_CollectionChanged;
        }

        internal void ModObs()
        {
            if (UsersObs != null && UsersObs.Count > 0)
            {
                UsersObs.FirstOrDefault().Username += "_mod";
            }
        }
        #endregion
    
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private void UsersObs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
