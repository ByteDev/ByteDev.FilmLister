using System;
using System.Reflection;
using System.Windows.Forms;

namespace ByteDev.FilmLister.WindowsUi
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void About_Load(object sender, EventArgs e)
		{
			infoTextBox.Text = @"Film Lister" + Environment.NewLine
				+ Application.ProductVersion + Environment.NewLine 
				+ GetAssemblyDetails();
		}

		private static string GetAssemblyDetails()
		{
			return GetAssemblyProduct() + " " + GetAssemblyCopyright();
		}

		private static string GetAssemblyProduct()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);

			if(attributes.Length < 1)
                return string.Empty;

            return ((AssemblyProductAttribute)attributes[0]).Product;
		}

		private static string GetAssemblyCopyright()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

			if (attributes.Length < 1)

                return string.Empty;

            return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
		}
	}
}
