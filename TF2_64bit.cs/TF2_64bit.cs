using System.IO;
using WindowsGSM.Functions;
using WindowsGSM.GameServer.Engine;

namespace WindowsGSM.Plugins
{
    public class TF2_64bit : Source
    {
        // - Plugin Details
        public Plugin Plugin = new Plugin
        {
            name = "WindowsGSM.TF2_64bit",
            author = "Raziel7893",
            description = "WindowsGSM plugin for supporting TF2 using 64bit Dedicated Server",
            version = "1.0",
            url = "https://github.com/Raziel7893/WindowsGSM.TF2_64bit",
            color = "#34FFeb"
        };
        // - Plugin Details

        public string FullName = "Team Fortress 2 64bit Dedicated Server";
        public override string Defaultmap { get { return "cp_badlands"; } }
        public override string Game { get { return "tf"; } }
        public override string AppId { get { return "232250"; } }
        public override string Additional { get { return "-tickrate 64"; } }

        public TF2_64bit(ServerConfig serverData) : base(serverData)
        {
            if (File.Exists(ServerPath.GetServersServerFiles(serverData.ServerID, "srcds_win64.exe")))
                StartPath = "srcds_win64.exe";
            base.serverData = serverData;
        }

    }
}
