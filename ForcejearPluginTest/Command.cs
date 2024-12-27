using System;
using CommandSystem;
using Exiled.API.Features;
using MEC;

namespace ForcejearPluginTest
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class Command : CommandSystem.ICommand
    {
        private bool esperar = false;

        public string[] Aliases => new string[] { null };

        public string Description => "Este comando ayuda al jugador a forcejear";

        string CommandSystem.ICommand.Command => "forcejear";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);

            if (player.IsCuffed)
            {
                if (!esperar)
                {
                    if (UnityEngine.Random.Range(1, 101) >= Main.Instance.Config.Chanze)
                    {
                       player.RemoveHandcuffs();
                       esperar = true;
                       Timing.CallDelayed(Main.Instance.Config.WaitingTime , () => esperar = false);


                       player.ShowHint(Main.Instance.Config.MessageWorks);
                       response = null;
                       return true;
                    }
                }
                else
                {
                    player.ShowHint(Main.Instance.Config.MesssageMessageWaiting);
                    response = null;
                    return false;
                }

                response = null;
                return true;
            }
            else
            {
                player.ShowHint(Main.Instance.Config.PlayerDontHaveCuffedHands);
                response = null;
                return false;
            }
        }
    }
}
