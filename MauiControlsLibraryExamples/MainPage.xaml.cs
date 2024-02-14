using MauiControlsLibrary;
using System.Reflection;

namespace MauiControlsLibraryExamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TestListbox1.Labels = ["Akshay", "John", "Bob", "Alice", "Jane", "Jill", "Brandon", "Josh", "Allen", "Jake", "Zed",
                "Kate", "Allison", "Chris", "Mike", "Lauren", "James" ];
            TestGrid1.HeaderNames = ["First Name", "Middle Name", "Last Name", "Age"];
            TestGrid1.Data = new string[,] { { "Akshay", "", "Srinivasan", "21" }, { "John", "", "Baptiste", "25" },
                { "Bob", "Edward", "Smith", "34" }, { "Alice", "Charlotte", "Green", "26" },
                { "Jane", "Kristi", "Woodhall", "32" }, { "Jill", "Justine", "Dane", "23" },
                { "Brandon", "Kris", "Mellon", "29" }, { "Josh", "Janus", "Hobart", "27" },
                { "Allen", "Long", "Pholsom", "35" }, { "Jake", "Mike", "Johnson", "33" },
                { "Zed", "Zeb", "Zebenizer", "20" }, { "Kate", "Betty", "Landon", "28"}
            };
            TestCombobox1.Labels = ["Camaro", "Corvette", "BMW", "Mercedes Benz", "Santro Xing", "Bugatti", "Lamborghini",
                "Honda City", "Toyota Camry", "Hugo", "Jaguar", "Maruti", "Fantasy Car 1", "Fantasy Car 2", "Fantasy Car 3" ];
            TestRadioButtonGroup1.Labels = ["Rock", "Paper", "Scissors"];
            TestImage1.ImageTitle = "Dr. Strange";
            TestImage1.LoadImage(GetType().GetTypeInfo().Assembly, "MauiControlsLibraryExamples.Resources.Images.DrStrange.png");
        }

        private void TestButton1_OnMCLButtonTapped(object sender, EventArgs e)
        {
            TestLabel1.LabelText = "TestButton1";
        }

        private void TestListbox1_OnMCCLListboxTapped(object sender, MauiControlsLibrary.MCLListbox.ListboxEventArgs e)
        {
            if (e.CurrentIndex >= 0 && e.CurrentIndex < TestListbox1.Labels.Length)
            {
                TestLabel1.LabelText = TestListbox1.Labels[e.CurrentIndex];
            }
        }

        private void TestGrid1_OnMCLGridTapped(object sender, MauiControlsLibrary.MCLGrid.GridEventArgs e)
        {
            if(TestGrid1.Data != null && e.CurrentRowIndex >= 0 && e.CurrentRowIndex < TestGrid1.Data.GetLength(0) && 
                e.CurrentColIndex >= 0 && e.CurrentColIndex < TestGrid1.Data.GetLength(1))
            {
                TestLabel1.LabelText = TestGrid1.Data[e.CurrentRowIndex, e.CurrentColIndex];
            }
        }

        private void TestCombobox1_SelectedItemChanged(object sender, MauiControlsLibrary.MCLCombobox.ComboboxEventArgs e)
        {
            if (TestCombobox1.Labels != null && e.SelectedIndex >= 0 && e.SelectedIndex < TestCombobox1.Labels.Length)
            {
                TestLabel1.LabelText = TestCombobox1.Labels[e.SelectedIndex];
            }
        }

        private void TestCheckbox1_OnMCLCheckboxChanged(object sender, EventArgs e)
        {
            if(sender is MCLCheckbox mclCheckbox)
            {
                TestLabel1.LabelText = mclCheckbox.IsChecked ? "Checked" : "Not checked";
            }
        }

        private void TestRadioButtonGroup1_OnMCLRadioButtonGroupTapped(object sender, MCLRadioButtonGroup.RadioButtonGroupEventArgs e)
        {
            if(sender is MCLRadioButtonGroup radioButtonGroup && radioButtonGroup.SelectedRadioButtonIndex >= 0 && 
                radioButtonGroup.SelectedRadioButtonIndex < radioButtonGroup.Labels.Length)
            {
                TestLabel1.LabelText = radioButtonGroup.Labels[radioButtonGroup.SelectedRadioButtonIndex];
            }
        }

        private void TestImage1_OnMCLImageTapped(object sender, EventArgs e)
        {
            if(sender is MCLImage mclImage && mclImage.Image != null && !string.IsNullOrEmpty(mclImage.ImageTitle))
            {
                TestLabel1.LabelText = mclImage.ImageTitle;
            }
        }
    }
}
