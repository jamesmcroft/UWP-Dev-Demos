namespace ControlDevelopment.Controls
{
    using System;

    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media;

    public class MyTemplatedControl : Control
    {
        public static readonly DependencyProperty SomeTextProperty = DependencyProperty.Register(
            nameof(SomeText),
            typeof(string),
            typeof(MyTemplatedControl),
            new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
            nameof(ImageSource),
            typeof(ImageSource),
            typeof(MyTemplatedControl),
            new PropertyMetadata(null, OnImageSourceChanged));

        private static void OnImageSourceChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var control = dependencyObject as MyTemplatedControl;
            if (control != null)
            {
                control.UpdateUI((Windows.UI.Xaml.Media.ImageSource)dependencyPropertyChangedEventArgs.NewValue);
            }
        }

        private void UpdateUI(ImageSource newValue)
        {
            
        }

        public ImageSource ImageSource
        {
            get
            {
                return (ImageSource)GetValue(ImageSourceProperty);
            }
            set
            {
                SetValue(ImageSourceProperty, value);
            }
        }

        public MyTemplatedControl()
        {
            this.DefaultStyleKey = typeof(MyTemplatedControl);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var image = GetTemplateChild("Image") as Image;
            if (image != null)
            {
                image.Stretch = Stretch.UniformToFill;
            }
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