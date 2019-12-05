using Microsoft.AspNetCore.Components;

namespace Pacco.Web.Shared
{
    public class MenuComponent
    {
        private readonly NavigationManager _navigationManager;
        public CustomMenu RightMenu { get; } = new CustomMenu();
        public CustomMenu LeftMenu { get; } = new CustomMenu();

        public MenuComponent(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            InitLeftMenu();
            InitRightMenu();
        }

        private void InitLeftMenu()
        {
            LeftMenu.AddItem("orders", "Orders");
            LeftMenu.AddItem("parcels", "Parcels");

            foreach (var item in LeftMenu.Items)
            {
                if (_navigationManager.Uri.Contains(item.Url))
                {
                    item.Activate();
                }
            }
        }

        private void InitRightMenu()
        {
            RightMenu.AddItem("sign-in", "Sign in");
            RightMenu.AddItem("sign-up", "Sign up");

            foreach (var item in RightMenu.Items)
            {
                if (_navigationManager.Uri.Contains(item.Url))
                {
                    item.Activate();
                }
            }
        }

        public void SetActiveRightMenuItem(CustomMenuItem customMenuItem)
        {
            foreach (var item in RightMenu.Items)
            {
                customMenuItem.Deactivate();
            }

            customMenuItem.Activate();
        }

        public void SetActiveLeftMenuItem(CustomMenuItem customMenuItem)
        {
            foreach (var item in LeftMenu.Items)
            {
                customMenuItem.Deactivate();
            }
            
            customMenuItem.Activate();
        }
    }
}