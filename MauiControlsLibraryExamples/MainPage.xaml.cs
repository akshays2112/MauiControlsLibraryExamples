﻿using MauiControlsLibrary;
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
            TestCombobox1.DropdownLabels = ["Camaro", "Corvette", "BMW", "Mercedes Benz", "Santro Xing", "Bugatti", "Lamborghini",
                "Honda City", "Toyota Camry", "Hugo", "Jaguar", "Maruti", "Fantasy Car 1", "Fantasy Car 2", "Fantasy Car 3" ];
            TestRadioButtonGroup1.Labels = ["Rock", "Paper", "Scissors"];
            TestRadioButtonGroup2.Labels = ["America", "Brazil", "United Kingdom", "India", "China", "Australia", "New Zealand",
                "Germany", "Austria", "Poland", "Vietnam", "Cambodia", "Kenya", "South Africa" ];
            TestRadioButtonGroup2.ArrangeHorizontal = false;
            TestImage1.ImageTitle = "Dr. Strange";
            TestImage1.LoadImage(GetType().GetTypeInfo().Assembly, "MauiControlsLibraryExamples.Resources.Images.DrStrange.png");
            TestImage1.ImageTapAreas = [new RectF(0, 0, 40, 60), new RectF(41, 0, 40, 60), new RectF(41, 61, 40, 60), new RectF(0, 61, 40, 60)];
            TestTreeview1.TreeviewNodes =
                [
                    new MCLTreeviewBase.TreeviewNode("RootNode1_RN1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                    [
                        new MCLTreeviewBase.TreeviewNode("RN1_Child1_RN1C1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN1C1_Child1_RN1C1C1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                                [
                                    new MCLTreeviewBase.TreeviewNode("RN1C1C1_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                                    new MCLTreeviewBase.TreeviewNode("RN1C1C1_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                                    new MCLTreeviewBase.TreeviewNode("RN1C1C1_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                                    new MCLTreeviewBase.TreeviewNode("RN1C1C1_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                                ]),
                            new MCLTreeviewBase.TreeviewNode("RN1C1_Child2_RN1C1C2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                                [
                                    new MCLTreeviewBase.TreeviewNode("RN1C1C2_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                                    new MCLTreeviewBase.TreeviewNode("RN1C1C2_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                                    new MCLTreeviewBase.TreeviewNode("RN1C1C2_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                                    new MCLTreeviewBase.TreeviewNode("RN1C1C2_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                                ]),
                            new MCLTreeviewBase.TreeviewNode("RN1C1_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C1_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN1_Child2_RN1C2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN1C2_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C2_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C2_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C2_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN1_Child3_RN1C3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN1C3_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C3_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C3_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C3_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN1_Child4_RN1C4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN1C4_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C4_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C4_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN1C4_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ])
                    ]),
                    new MCLTreeviewBase.TreeviewNode("RootNode2_RN2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                    [
                        new MCLTreeviewBase.TreeviewNode("RN2_Child1_RN2C1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN2C1_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C1_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C1_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C1_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN2_Child2_RN2C2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN2C2_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C2_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C2_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C2_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN2_Child3_RN2C3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN2C3_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C3_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C3_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C3_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN2_Child4_RN2C4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN2C4_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C4_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C4_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN2C4_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ])
                    ]),
                    new MCLTreeviewBase.TreeviewNode("RootNode3_RN3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                    [
                        new MCLTreeviewBase.TreeviewNode("RN3_Child1_RN3C1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN3C1_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C1_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C1_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C1_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN3_Child2_RN3C2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN3C2_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C2_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C2_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C2_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN3_Child3_RN3C3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN3C3_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C3_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C3_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C3_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ]),
                        new MCLTreeviewBase.TreeviewNode("RN3_Child4_RN3C4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded,
                        [
                            new MCLTreeviewBase.TreeviewNode("RN3C4_Child1", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C4_Child2", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C4_Child3", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null),
                            new MCLTreeviewBase.TreeviewNode("RN3C4_Child4", MCLTreeviewBase.ExpandCollapseButtonState.Expanded, null)
                        ])
                    ])
                ];
            TestImageTreeview1.TreeviewNodes = TestTreeview1.TreeviewNodes;
            TestImageTreeview1.LoadExpandCollapseImages(GetType().GetTypeInfo().Assembly, "MauiControlsLibraryExamples.Resources.Images.Expand.png",
                "MauiControlsLibraryExamples.Resources.Images.Collapse.png");
            TestImageProgressBar1.ProgressBarBackgroundColor = Color.FromRgb(0x08, 0x76, 0x71);
            TestImageProgressBar1.LoadProgressBarImages(GetType().GetTypeInfo().Assembly, null, "MauiControlsLibraryExamples.Resources.Images.ProgressBarImage.png");
            TestImageProgressBar2.ProgressBarBackgroundColor = Color.FromRgb(0x08, 0x76, 0x71);
            TestImageProgressBar2.LoadProgressBarImages(GetType().GetTypeInfo().Assembly, null, "MauiControlsLibraryExamples.Resources.Images.ProgressBarImageVertical.png");
            TestImageButton1.LoadButtonBackgroundImages(GetType().GetTypeInfo().Assembly, "MauiControlsLibraryExamples.Resources.Images.ButtonNotPressed.png",
                "MauiControlsLibraryExamples.Resources.Images.ButtonPressed.png");
            TestImageCombobox1.DropdownLabels = ["California", "Michigan", "Texas", "Arkansas", "New York", "Ohio", "Washington", "Philidelphia", "Florida",
                "New Mexico", "Minnesota", "Nevada", "Tenesse", "Illinois", "Oregon"];
            TestImageCombobox1.LoadComboboxButtonImages(GetType().GetTypeInfo().Assembly, "MauiControlsLibraryExamples.Resources.Images.ComboboxButtonNotPressedImage.png",
                "MauiControlsLibraryExamples.Resources.Images.ComboboxButtonPressedImage.png");
            TestImageCheckbox1.LoadCheckboxImages(GetType().GetTypeInfo().Assembly, "MauiControlsLibraryExamples.Resources.Images.CheckboxUnchecked.png",
                "MauiControlsLibraryExamples.Resources.Images.CheckboxChecked.png");
            TestIconWithLabelButton1.MCLLabelWidth = 225;
            TestIconWithLabelButton1.MCLLabelHeight = 25;
            TestIconWithLabelButton1.MCLLabel.LabelText = "TestIconWithLabelButton1";
            TestIconWithLabelButton1.MCLIconImageWidth = 17;
            TestIconWithLabelButton1.MCLIconImageHeight = 23;
            TestIconWithLabelButton1.MCLIconImage.ImageTitle = "File";
            TestIconWithLabelButton1.MCLIconImage.LoadImage(GetType().GetTypeInfo().Assembly, "MauiControlsLibraryExamples.Resources.Images.FileIcon.png");
            TestIconWithLabelButton1.OnMCLButtonTapped += TestIconWithLabelButton1_OnMCLButtonTapped;
        }

        private void TestIconWithLabelButton1_OnMCLButtonTapped(object? sender, EventArgs e)
        {
            TestLabel1.LabelText = "TestIconWithLabelButton1";
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
            if (TestGrid1.Data != null && e.CurrentRowIndex >= 0 && e.CurrentRowIndex < TestGrid1.Data.GetLength(0) &&
                e.CurrentColIndex >= 0 && e.CurrentColIndex < TestGrid1.Data.GetLength(1))
            {
                TestLabel1.LabelText = TestGrid1.Data[e.CurrentRowIndex, e.CurrentColIndex];
            }
        }

        private void TestCombobox1_SelectedItemChanged(object sender, MauiControlsLibrary.MCLComboboxBase.ComboboxEventArgs e)
        {
            if (TestCombobox1.DropdownLabels != null && e.SelectedIndex >= 0 && e.SelectedIndex < TestCombobox1.DropdownLabels.Length)
            {
                TestLabel1.LabelText = TestCombobox1.DropdownLabels[e.SelectedIndex];
            }
        }

        private void TestCheckbox1_OnMCLCheckboxChanged(object sender, EventArgs e)
        {
            if (sender is MCLCheckbox mclCheckbox)
            {
                TestLabel1.LabelText = mclCheckbox.IsChecked ? "Checked" : "Not checked";
            }
        }

        private void TestRadioButtonGroup1_OnMCLRadioButtonGroupTapped(object sender, MCLRadioButtonGroup.RadioButtonGroupEventArgs e)
        {
            if (sender is MCLRadioButtonGroup radioButtonGroup && radioButtonGroup.SelectedRadioButtonIndex >= 0 &&
                radioButtonGroup.SelectedRadioButtonIndex < radioButtonGroup.Labels.Length)
            {
                TestLabel1.LabelText = radioButtonGroup.Labels[radioButtonGroup.SelectedRadioButtonIndex];
            }
        }

        private void TestImage1_OnMCLImageTapped(object sender, MCLImage.MCLImageEventArgs e)
        {
            if (sender is MCLImage mclImage && mclImage.Image != null && !string.IsNullOrEmpty(mclImage.ImageTitle))
            {
                string tmp = mclImage.ImageTitle;
                if (e.TappedImageAreasIndexes != null && e.TappedImageAreasIndexes.Length > 0)
                {
                    for (int i = 0; i < e.TappedImageAreasIndexes.Length; i++)
                    {
                        switch (e.TappedImageAreasIndexes[i])
                        {
                            case 0:
                                tmp += " TopLeft";
                                break;
                            case 1:
                                tmp += " TopRight";
                                break;
                            case 2:
                                tmp += "BottomRight";
                                break;
                            case 3:
                                tmp += " BottomLeft";
                                break;
                        }
                    }
                }
                TestLabel1.LabelText = tmp;
            }
        }

        private void TestRadioButtonGroup2_OnMCLRadioButtonGroupTapped(object sender, MCLRadioButtonGroup.RadioButtonGroupEventArgs e)
        {
            if (sender is MCLRadioButtonGroup radioButtonGroup && radioButtonGroup.SelectedRadioButtonIndex >= 0 &&
                radioButtonGroup.SelectedRadioButtonIndex < radioButtonGroup.Labels.Length)
            {
                TestLabel1.LabelText = radioButtonGroup.Labels[radioButtonGroup.SelectedRadioButtonIndex];
            }
        }

        private void TestProgressBar2_OnMCLProgressBarTapped(object sender, MCLProgressBarBase.MCLProgressBarEventArgs e)
        {
            if (sender is MCLProgressBar mclProgressBar)
            {
                decimal beforeIncrementValue = mclProgressBar.CurrentValue;
                mclProgressBar.CurrentValue += 10;
                if (mclProgressBar.CurrentValue > mclProgressBar.MaxValue)
                {
                    mclProgressBar.CurrentValue = mclProgressBar.MinValue;
                }
                TestLabel1.LabelText = $"Before:: {mclProgressBar.BeforeValueLabel}{beforeIncrementValue}{mclProgressBar.AfterValueLabel}; After:: {mclProgressBar.BeforeValueLabel}{mclProgressBar.CurrentValue}{mclProgressBar.AfterValueLabel}";
            }
        }

        private void TestProgressBar1_OnMCLProgressBarTapped(object sender, MCLProgressBarBase.MCLProgressBarEventArgs e)
        {
            if (sender is MCLProgressBar mclProgressBar)
            {
                decimal beforeIncrementValue = mclProgressBar.CurrentValue;
                mclProgressBar.CurrentValue -= 10;
                if (mclProgressBar.CurrentValue < mclProgressBar.MinValue)
                {
                    mclProgressBar.CurrentValue = mclProgressBar.MaxValue;
                }
                TestLabel1.LabelText = $"Before:: {mclProgressBar.BeforeValueLabel}{beforeIncrementValue}{mclProgressBar.AfterValueLabel}; After:: {mclProgressBar.BeforeValueLabel}{mclProgressBar.CurrentValue}{mclProgressBar.AfterValueLabel}";
            }
        }

        private void TestImageProgressBar1_OnMCLProgressBarTapped(object sender, MCLProgressBarBase.MCLProgressBarEventArgs e)
        {
            if (sender is MCLImageProgressBar mclProgressBar)
            {
                decimal beforeIncrementValue = mclProgressBar.CurrentValue;
                mclProgressBar.CurrentValue += 10;
                if (mclProgressBar.CurrentValue > mclProgressBar.MaxValue)
                {
                    mclProgressBar.CurrentValue = mclProgressBar.MinValue;
                }
                TestLabel1.LabelText = $"Before:: {mclProgressBar.BeforeValueLabel}{beforeIncrementValue}{mclProgressBar.AfterValueLabel}; After:: {mclProgressBar.BeforeValueLabel}{mclProgressBar.CurrentValue}{mclProgressBar.AfterValueLabel}";
            }
        }

        private void TestImageProgressBar2_OnMCLProgressBarTapped(object sender, MCLProgressBarBase.MCLProgressBarEventArgs e)
        {
            if (sender is MCLImageProgressBar mclProgressBar)
            {
                decimal beforeIncrementValue = mclProgressBar.CurrentValue;
                mclProgressBar.CurrentValue -= 10;
                if (mclProgressBar.CurrentValue < mclProgressBar.MinValue)
                {
                    mclProgressBar.CurrentValue = mclProgressBar.MaxValue;
                }
                TestLabel1.LabelText = $"Before:: {mclProgressBar.BeforeValueLabel}{beforeIncrementValue}{mclProgressBar.AfterValueLabel}; After:: {mclProgressBar.BeforeValueLabel}{mclProgressBar.CurrentValue}{mclProgressBar.AfterValueLabel}";
            }
        }

        private void TestImageButton1_OnMCLButtonTapped(object sender, EventArgs e)
        {
            TestLabel1.LabelText = "TestButton2";
        }

        private void TestImageCombobox1_SelectedItemChanged(object sender, MCLComboboxBase.ComboboxEventArgs e)
        {
            if (TestImageCombobox1.DropdownLabels != null && e.SelectedIndex >= 0 && e.SelectedIndex < TestCombobox1.DropdownLabels.Length)
            {
                TestLabel1.LabelText = TestImageCombobox1.DropdownLabels[e.SelectedIndex];
            }
        }

        private void TestImageCheckbox1_OnMCLCheckboxChanged(object sender, EventArgs e)
        {
            if (sender is MCLImageCheckbox mclImageCheckbox)
            {
                TestLabel1.LabelText = mclImageCheckbox.IsChecked ? "Image Checked" : "Image Not checked";
            }
        }

        private void TestImageTreeview1_OnMCLTreeviewNodeLabelTapped(object sender, MCLTreeviewBase.TreeviewNodeLabelTappedEventArgs e)
        {
            if (e != null && e.TreeviewNode != null && e.TreeviewNode.Label != null)
            {
                TestLabel1.LabelText = e.TreeviewNode.Label;
            }
        }

        private void TestTreeview1_OnMCLTreeviewNodeLabelTapped(object sender, MCLTreeviewBase.TreeviewNodeLabelTappedEventArgs e)
        {
            if (e != null && e.TreeviewNode != null && e.TreeviewNode.Label != null)
            {
                TestLabel1.LabelText = e.TreeviewNode.Label;
            }
        }
    }
}
