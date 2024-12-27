using Exiled.API.Features;

namespace ForcejearPluginTest
{
    public class Main : Plugin<config>
    {
        public static Main Instance { get; private set; } = new();
        public override void OnEnabled()
        {
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}
