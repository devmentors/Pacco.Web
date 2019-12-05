using System.Collections.Generic;

namespace Pacco.Web.Shared
{
    public class CustomMenu
    {
        private readonly HashSet<CustomMenuItem> _items = new HashSet<CustomMenuItem>();
        public IEnumerable<CustomMenuItem> Items => _items;

        public void AddItem(string url, string name)
        {
            _items.Add(new CustomMenuItem(url, name));
        }
    }
}