using System.ComponentModel;
using System.Text;
using Exiled.API.Interfaces;

namespace ForcejearPluginTest
{
    public class config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("This variable raises or lowers the chances that the user can remove the handcuffs.")]
        public int Chanze { get; set; } = 80;
        [Description("The message that appears when you have failed to remove the handcuffs")]
        public string MessageFailed { get; set; } = "Failed...";
        [Description("The message he plays when the handcuffs have been removed")]
        public string MessageWorks { get; set; } = "¡Manos liberadas! A disfrutar máquina.";
        [Description("The waiting time it takes for the player to release the handcuffs again")]
        public float WaitingTime { get; set; } = 30f;
        [Description("Waiting message when the cooldown is set. CAUTION: Do not delete {Main.Instance.Config.WaitingTime} to set the waiting seconds")]
        public string MesssageMessageWaiting { get; set; } = "You have to wait to be able to remove the handcuffs";
        public string PlayerDontHaveCuffedHands { get; set; } = "Your hands are not cuffed"; 

    }
}
