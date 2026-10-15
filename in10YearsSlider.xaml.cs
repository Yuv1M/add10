namespace HowOld;

public partial class in10YearsSlider : ContentPage
{
    private int age;
	public in10YearsSlider()
	{
		InitializeComponent();
		lblResult.Text = "---Welcome---";
	}
    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int age = (int)sliderAge.Value;
        entryAge.Text = age.ToString();
    }

    private void sliderAge_DragCompleted(object sender, EventArgs e)
    {
        int age = (int)sliderAge.Value;
        lblResult.Text = $"In 10 years {entryName.Text} will be {age + 10} years old";
    }
}