using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class ContactInfoRepository : INotifyPropertyChanged
    {
        private ObservableCollection<Contacts> contactinfo;

        #region Properties
        public ObservableCollection<Contacts> ContactInfo
        {
            get
            {
                return contactinfo;
            }

            set
            {
                contactinfo = value;
                this.OnPropertyChanged("ContactInfo");
            }
        }

        #endregion

        #region Constructor

        public ContactInfoRepository()
        {
            contactinfo = new ObservableCollection<Contacts>();
            Random r = new Random();
            for (int i = 0; i < ContactNames.Count(); i++)
            {
                var contact = new Contacts();
                contact.ContactName = ContactNames[i];
                contact.ContactNumber = r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString();
                contact.ContactColor = Color.FromRgb(r.Next(40, 255), r.Next(40, 255), r.Next(40, 255));
                contact.ContactImage = "people_circle" + (i % 19) + ".png";
                contact.UserId = i;
                contactinfo.Add(contact);
            }
        }

        #endregion

        #region Fields

        string[] ContactNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson"    ,
            "Mason  "    ,
            "Liam   "    ,
            "Jacob  "    ,
            "Jayden "    ,
            "Ethan  "    ,
            "Noah   "    ,
            "Lucas  "    ,
            "Logan  "    ,
            "Caleb  "    ,
            "Caden  "    ,
            "Jack   "    ,
            "Ryan   "    ,
            "Connor "    ,
            "Michael"    ,
            "Elijah "    ,
            "Brayden"    ,
            "Benjamin"   ,
            "Nicholas"   ,
            "Alexander"  ,
            "William"    ,
            "Matthew"
        };

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
