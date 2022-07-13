using Stump.DofusProtocol.Enums;
using Stump.Server.WorldServer.Database.World;
using Stump.Server.WorldServer.Game.Fights;
using System.Collections.Generic;
using System.Linq;

namespace Stump.Server.WorldServer.Game.Spells.Casts.Osamodas
{
    [SpellCastHandler(SpellIdEnum.TOXINES)]
    [SpellCastHandler(SpellIdEnum.TOXINES_9796)]
    public class ToxineCastHandler : DefaultSpellCastHandler
    {
        public ToxineCastHandler(SpellCastInformations cast)
            : base(cast)
        {
        }

        public override bool Initialize()
        {
            if (base.Initialize())
            {
                var toxineBis = Handlers.FirstOrDefault(x => x.Effect.EffectId == EffectsEnum.Effect_RemoveSpellEffects && x.Dice.Value == 9844);
                if (toxineBis != null)
                    toxineBis.Priority = 0;
                return true;
            }

            return false;
        }
    }
}