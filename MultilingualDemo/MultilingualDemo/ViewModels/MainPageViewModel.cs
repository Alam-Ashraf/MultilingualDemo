using MultilingualDemo.Helpers;
using MultilingualDemo.Models;
using MultilingualDemo.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MultilingualDemo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Language> Languages { get; set; } = new ObservableCollection<Language>();
        public Language SelectedLanguage { get; set; }

        public ICommand ChangeLangugeCommand { get; set; }

        public MainPageViewModel()
        {
            LoadLanguage();

            ChangeLangugeCommand = new Command(async () =>
            {
                LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.CI));
                LoadLanguage();
            });

        }

        void LoadLanguage()
        {

            Languages = new ObservableCollection<Language>()
            {
                {new Language(Resource.English, "en") },
                {new Language(Resource.Hindi, "hi") },
                {new Language(Resource.Marathi, "mr") },
                {new Language(Resource.Gujarati, "gu") }
            };

            SelectedLanguage = Languages.FirstOrDefault(pro => pro.CI == LocalizationResourceManager.Instance.CurrentCulture.TwoLetterISOLanguageName);
        }

    }
}
