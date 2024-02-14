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
        }

        private void TestButton1_OnMCCLButtonTapped(object sender, EventArgs e)
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
    }

}
