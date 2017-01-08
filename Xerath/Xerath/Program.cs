using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
    

namespace Xerath
{
    class Program
    {
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
       


        }

        private static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.Hero != Champion.Xerath) return;

            Chat.Print("<font color = #000099>Xerath Loaded</font>");
            //this prints my shit on the chat
            Game.OnTick += OnTick;
            //uses ontick
        }

        private static void OnTick(EventArgs args)
        {
            Spells.InitializeSpells();
            Menus.CreateMenu();

            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo)) ExecuteCombo();
        }

        private static void ExecuteCombo()
        {
           
        }
    }
}
