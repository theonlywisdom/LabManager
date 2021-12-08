using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.ViewModels
{
    public class ClientCollectionItemViewModel : ObservableObject
    {
        private string _code;
        private string _name;
        private string _address;
        private string _postcode;
        private string _person;
        private string _jobTitle;
        private string _phone;
        private string _email;

        public ClientCollectionItemViewModel(int id, string code,
            string name, string address, string postcode,
            string person, string jobTitle, string phone,
            string email)
        {
            Id = id;
            Code = code;
            Name = name;
            Address = address;
            Postcode = postcode;
            Person = person;
            JobTitle = jobTitle;
            Phone = phone;
            Email = email;
        }


        public int Id { get; }

        public string Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }

        public string Postcode
        {
            get { return _postcode; }
            set
            {
                _postcode = value;
                OnPropertyChanged();
            }
        }

        public string Person
        {
            get { return _person; }
            set
            {
                _person = value;
                OnPropertyChanged();
            }
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set
            {
                _jobTitle = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
    }
}
