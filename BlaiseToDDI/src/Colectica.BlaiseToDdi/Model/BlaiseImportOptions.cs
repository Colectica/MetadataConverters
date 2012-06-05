using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;

namespace Colectica.BlaiseToDdi.Model
{
	public class BlaiseImportOptions : INotifyPropertyChanged
	{
		private string baseFilePathField;
		public string BaseFilePath
		{
			get { return this.baseFilePathField; }
			set { this.baseFilePathField = value; OnPropertyChanged("BaseFilePath"); }
		}

		private ObservableCollection<BlaiseLanguageMapping> languageMappingsField = new ObservableCollection<BlaiseLanguageMapping>();
		public ObservableCollection<BlaiseLanguageMapping> LanguageMappings
		{
			get { return this.languageMappingsField; }
		}

		public BlaiseLanguageMapping GetMapping(string languageId)
		{
			if (languageId == null) { languageId = string.Empty; }
			foreach (BlaiseLanguageMapping mapping in languageMappingsField)
			{
				if (string.Compare(languageId, mapping.LanguageIdentifier, true) == 0)
				{
					return mapping;
				}
			}
			return null;
		}


		Collection<string> definedLanguagesOrder = new Collection<string>();
		public Collection<string> DefinedLanguagesOrder
		{
			get { return definedLanguagesOrder; }
			set { definedLanguagesOrder = value; }
		}
		private Dictionary<string, string> definedLanguages = new Dictionary<string, string>();
		public Dictionary<string, string> DefinedLanguages
		{
			get { return definedLanguages; }
			set { definedLanguages = value; }
		}

		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}

	public class BlaiseLanguageMapping
	{
		public string LanguageIdentifier { get; set; }
		public MetadataFieldType MetadataElement { get; set; }
		public CultureInfo CultureInfo { get; set; }

		public string Culture
		{
			get 
			{ 
				return this.CultureInfo == null ? 
					string.Empty : this.CultureInfo.Name; 
			}
		}
	}

}
