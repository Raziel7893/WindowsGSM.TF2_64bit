using System.IO;
using WindowsGSM.Functions;
using WindowsGSM.GameServer.Engine;

namespace WindowsGSM.Plugins
{
    public class TF2_64bit : Source
    {
        // - Plugin Details
        public const string FullName = "Team Fortress 2 64bit Dedicated Server";
        public override string Defaultmap { get { return "cp_badlands"; } }
        public override string Game { get { return "tf"; } }
        public override string AppId { get { return "232250"; } }

        public string StartPath = "srcds_win64.exe";

        public TF2_64bit(Functions.ServerConfig serverData) : base(serverData)
        {
            base.serverData = serverData;
        }

    }
}
