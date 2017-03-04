namespace ControlDevelopment.Controls
{
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public sealed partial class MyUserControl : UserControl
    {
        public static readonly DependencyProperty SomeTextProperty = DependencyProperty.Register(
            nameof(SomeText),
            typeof(string),
            typeof(MyUserControl),
            new PropertyMetadata(string.Empty));

        public MyUserControl()
        {
            this.InitializeComponent();
        }

        public string SomeText
        {
            get
            {
                return (string)this.GetValue(SomeTextProperty);
            }

            set
            {
                this.SetValue(SomeTextProperty, value);
            }
        }
    }
}