using System;

namespace Stump.DofusProtocol.Enums {
    [Flags]
    public enum TeamEnum {
        TEAM_CHALLENGER = 0,
        TEAM_DEFENDER = 1,
        TEAM_SPECTATOR = 2
    }
}