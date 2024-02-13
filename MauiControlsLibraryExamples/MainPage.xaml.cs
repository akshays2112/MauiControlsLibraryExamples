namespace MauiControlsLibraryExamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TestListbox1.Labels = ["Akshay", "John", "Bob", "Alice", "Jane", "Jill", "Brandon", "Josh", "Allen", "Jake", "Zed",
                "Kate", "Allison", "Chris", "Mike", "Lauren", "James" ];
        }

        private void TestButton1_OnMCCLButtonTapped(object sender, EventArgs e)
        {
            TestLabel1.LabelText = "TestButton1";
        }

        private void TestListbox1_OnMCCLListboxTapped(object sender, MauiControlsLibrary.MCCLListbox.ListboxEventArgs e)
        {
            if (e.CurrentIndex >= 0 && e.CurrentIndex < TestListbox1.Labels.Length)
            {
                TestLabel1.LabelText = TestListbox1.Labels[e.CurrentIndex];
            }
        }
    }

}
