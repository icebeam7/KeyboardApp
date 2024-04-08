namespace KeyboardApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNewControl(object sender, EventArgs e)
        {
            var stack = new HorizontalStackLayout() { Spacing = 20 };
            var label = new Label() { Text = "New item" };
            var entry = new Entry() { Placeholder = "Add text here" };
            var button = new Button() { Text = "Click me" };
            stack.Children.Add(label);
            stack.Children.Add(entry);
            stack.Children.Add(button);

            stackContainer.Children.Add(stack);
        }

        private void OnDeleteControl(object sender, EventArgs e)
        {
            if (stackContainer.Children.Count > 0) 
                stackContainer.Children.RemoveAt(
                    stackContainer.Children.Count - 1);
        }
    }

}
