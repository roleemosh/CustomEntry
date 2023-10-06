namespace CustomEntry
{
    public class CustomEntryControl : Entry
    {
        public static BindableProperty IsValidProperty = BindableProperty.Create(
                nameof(IsValid), typeof(bool), typeof(CustomEntryControl), true);
        public bool IsValid
        {
            get => (bool)GetValue(IsValidProperty);
            set => SetValue(IsValidProperty, value);
        }
    }
}
