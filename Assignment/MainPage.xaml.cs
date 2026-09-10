using Microsoft.Maui.Controls;

namespace Assignment;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    void OnCalculateClicked(object sender, EventArgs e)
    {
        double bill = double.Parse(billEntry.Text);

        double tip = bill * 0.20;
        double total = bill + tip;

        resultLabel.Text = $"Tip: {tip:C}\nTotal: {total:C}";
    }
}
