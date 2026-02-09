using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class SubscriptionServiceDetailsDTO
    {
        public int SubscriptionServiceId { get; set; }
        public string SubscriptionServiceName { get; set; }
        public double? Price { get; set; }
        public List<VideogameSlimDTO> Videogames { get; set; }



        //None,
        //XboxGamePass_Core,
        //XboxGamePass_PC,
        //XboxGamePass_Console,
        //XboxGamePass_Ultimate,
        //PlayStationPlus_Essential,
        //PlayStationPlus_Extra,
        //PlayStationPlus_Premium,
        //NintendoSwitchOnline_Standard,
        //NintendoSwitchOnline_ExpansionPack,

        //EAPlay,
        //EAPlay_Pro,
        //UbisoftPlus_Classics,
        //UbisoftPlus_Premium,
        //OriginAccess,
        //HumbleChoice,

        //AmazonLuna,
        //GeForceNow,
        //NetflixGames,
        //AntstreamArcade,

        //AppleArcade,
        //GooglePlayPass,

        //PlayStationNow,
        //XboxCloudGaming,
        //PlayStationNow_CloudStreaming,
        //ShadowPC,

        //StadiaPro,
        //OnLive,
        //Gaikai,
        //GameFlyStreaming,

        //Jump,

        //GameLine,
        //Desura,
        //Impulse,
        //GCluster
    }
}
