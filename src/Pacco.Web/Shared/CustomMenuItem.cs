namespace Pacco.Web.Shared
{
    public class CustomMenuItem
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; private set; }
        public string CssClass { get; private set; } = "button is-light";

        public CustomMenuItem(string url, string name, bool isActive = false)
        {
            Url = url;
            Name = name;
            if (isActive)
            {
                Activate();
                return;
            }

            Deactivate();
        }

        public void Activate()
        {
            IsActive = true;
            CssClass = "button is-primary";
        }

        public void Deactivate()
        {
            IsActive = false;
            CssClass = "button is-light";
        }
    }
}