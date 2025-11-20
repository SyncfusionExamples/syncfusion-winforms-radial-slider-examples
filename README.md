# How to Format Text in RadialSlider
The RadialSlider control in Syncfusion WinForms allows you to customize the appearance of text displayed on the slider. You can format the text for intervals, the pointer, and the selected value by handling the [DrawText](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawText) event.

## Why This Is Useful
- **Custom Styling**: Apply different fonts and colors for various slider elements.
- **Dynamic Formatting**: Change text appearance based on value ranges.
- **Enhanced UX**: Make the slider visually appealing and informative.

## Key Properties
- [DrawTextEventArgs.Text](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawTextEventArgs_Text) – The text to display.
- [DrawTextEventArgs.ForeColor](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawTextEventArgs_ForeColor) – The color of the text.
- [DrawTextEventArgs.Font](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawTextEventArgs_Font) – The font used for the text.
- [DrawTextEventArgs.TextType](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawTextEventArgs_TextType) – Enum to identify whether the text belongs to an interval, pointer, or value.


## Implementation Steps
- Handle the [RadialSlider.DrawText](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawText) event.
- Append custom text (e.g., units like °C).
- Apply conditional formatting based on value ranges.
- Differentiate styles for intervals, pointer, and value using TextType.

## Sample Code
```C#
private void RadialSlider1_DrawText(object sender, RadialSlider.DrawTextEventArgs e)
{
    int value = int.Parse(e.Text);
    e.Text += "°C"; // Append degree symbol

    if (e.TextType == TextType.Interval)
    {
        if (value <= 33)
        {
            e.Font = new Font("Arial", 8);
            e.ForeColor = Brushes.Green;
        }
        else if (value > 33 && value <= 66)
        {
            e.Font = new Font("Courier", 10);
            e.ForeColor = Brushes.Gold;
        }
        else
        {
            e.Font = new Font("Georgia", 10);
            e.ForeColor = Brushes.Red;
        }
    }
    else if (e.TextType == TextType.Pointer)
    {
        e.Font = new Font("Segoe UI Black", 8);
        e.ForeColor = Brushes.Blue;
    }
    else if (e.TextType == TextType.Value)
    Font("MoolBoran", 12);
        e.ForeColor = Brushes.DeepPink;
    }
}
```

## Output

![RadialSlider TextFormatting](Samples/Text_Formatting/Image/RadialSlider%20TextFormatting.png)
