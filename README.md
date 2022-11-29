# How to format text in RadialSlider
You can customize the text format for specific or all sliders by handling the [DrawText](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.html) event. You can change the content, foreground and font of the slider intervals, selected slider or selected value by using the [DrawTextEventArgs.Text](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawTextEventArgs_Text), [DrawTextEventArgs.ForeColor](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawTextEventArgs_ForeColor) and DrawTextEventArgs.Font properties. You can differentiate the slider intervals, selected slider and selected value by using the [DrawTextEventArgs.TextType] (https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.RadialSlider.DrawTextEventArgs.html#Syncfusion_Windows_Forms_Tools_RadialSlider_DrawTextEventArgs_TextType) enum property.

# C#
    private void RadialSlider1_DrawText(object sender, RadialSlider.DrawTextEventArgs e)
            {
                int Value = int.Parse(e.Text);
                e.Text += "°C";
                if (e.TextType == TextType.Interval)
                {
                    if (Value <= 33)
                    {
                        e.Font = new Font("Arial", 8);
                        e.ForeColor = Brushes.Green;
                    }
                    else if (Value > 33 && Value <= 66)
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
                {
                    e.Font = new Font("MoolBoran", 12);
                    e.ForeColor = Brushes.DeepPink;
                }
            }

![RadialSlider TextFormatting](Samples/Text_Formatting/Image/RadialSlider%20TextFormatting.png)
