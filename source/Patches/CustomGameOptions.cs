using TownOfUs.CrewmateRoles.MedicMod;
using TownOfUs.CustomOption;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.CrewmateRoles.HaunterMod;
using TownOfUs.CrewmateRoles.MediumMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;

namespace TownOfUs
{
    public enum DisableSkipButtonMeetings
    {
        No,
        Emergency,
        Always
    }
    public enum GameMode
    {
        Classic,
        AllAny,
        KillingOnly,
        Cultist
    }
    public enum AdminDeadPlayers
    {
        Nobody,
        Spy,
        EveryoneButSpy,
        Everyone
    }
    public static class CustomGameOptions
    {
        public static int MayorOn => (int)Generate.MayorOn.Get();
        public static int JesterOn => (int)Generate.JesterOn.Get();
        public static int SheriffOn => (int)Generate.SheriffOn.Get();
        public static int JanitorOn => (int)Generate.JanitorOn.Get();
        public static int EngineerOn => (int)Generate.EngineerOn.Get();
        public static int SwapperOn => (int)Generate.SwapperOn.Get();
        public static int AmnesiacOn => (int)Generate.AmnesiacOn.Get();
        public static int InvestigatorOn => (int)Generate.InvestigatorOn.Get();
        public static int MedicOn => (int)Generate.MedicOn.Get();
        public static int SeerOn => (int)Generate.SeerOn.Get();
        public static int GlitchOn => (int)Generate.GlitchOn.Get();
        public static int MorphlingOn => (int)Generate.MorphlingOn.Get();
        public static int ExecutionerOn => (int)Generate.ExecutionerOn.Get();
        public static int SpyOn => (int)Generate.SpyOn.Get();
        public static int SnitchOn => (int)Generate.SnitchOn.Get();
        public static int MinerOn => (int)Generate.MinerOn.Get();
        public static int SwooperOn => (int)Generate.SwooperOn.Get();
        public static int ArsonistOn => (int)Generate.ArsonistOn.Get();
        public static int AltruistOn => (int)Generate.AltruistOn.Get();
        public static int UndertakerOn => (int)Generate.UndertakerOn.Get();
        public static int PhantomOn => (int)Generate.PhantomOn.Get();
        public static int VigilanteOn => (int)Generate.VigilanteOn.Get();
        public static int HaunterOn => (int)Generate.HaunterOn.Get();
        public static int GrenadierOn => (int)Generate.GrenadierOn.Get();
        public static int VeteranOn => (int)Generate.VeteranOn.Get();
        public static int TrackerOn => (int)Generate.TrackerOn.Get();
        public static int TrapperOn => (int)Generate.TrapperOn.Get();
        public static int TraitorOn => (int)Generate.TraitorOn.Get();
        public static int TransporterOn => (int)Generate.TransporterOn.Get();
        public static int MediumOn => (int)Generate.MediumOn.Get();
        public static int SurvivorOn => (int)Generate.SurvivorOn.Get();
        public static int GuardianAngelOn => (int)Generate.GuardianAngelOn.Get();
        public static int MysticOn => (int)Generate.MysticOn.Get();
        public static int BlackmailerOn => (int)Generate.BlackmailerOn.Get();
        public static int PlaguebearerOn => (int)Generate.PlaguebearerOn.Get();
        public static int WerewolfOn => (int)Generate.WerewolfOn.Get();
        public static int DetectiveOn => (int)Generate.DetectiveOn.Get();
        public static int EscapistOn => (int)Generate.EscapistOn.Get();
        public static int ImitatorOn => (int)Generate.ImitatorOn.Get();
        public static int BomberOn => (int)Generate.BomberOn.Get();
        public static int TorchOn => (int)Generate.TorchOn.Get();
        public static int DiseasedOn => (int)Generate.DiseasedOn.Get();
        public static int FlashOn => (int)Generate.FlashOn.Get();
        public static int TiebreakerOn => (int)Generate.TiebreakerOn.Get();
        public static int GiantOn => (int)Generate.GiantOn.Get();
        public static int ButtonBarryOn => (int)Generate.ButtonBarryOn.Get();
        public static int BaitOn => (int)Generate.BaitOn.Get();
        public static int LoversOn => (int)Generate.LoversOn.Get();
        public static int SleuthOn => (int)Generate.SleuthOn.Get();
        public static int BlindOn => (int)Generate.BlindOn.Get();
        public static int RadarOn => (int)Generate.RadarOn.Get();
        public static int DisperserOn => (int)Generate.DisperserOn.Get();
        public static int MultitaskerOn => (int)Generate.MultitaskerOn.Get();
        public static int DoubleShotOn => (int)Generate.DoubleShotOn.Get();
        public static int UnderdogOn => (int)Generate.UnderdogOn.Get();
        public static float InitialCooldowns => Generate.InitialCooldowns.Get();
        public static bool BothLoversDie => Generate.BothLoversDie.Get();
        public static bool NeutralLovers => Generate.NeutralLovers.Get();
        public static bool SheriffKillOther => Generate.SheriffKillOther.Get();
        public static bool SheriffKillsExecutioner => Generate.SheriffKillsExecutioner.Get();
        public static bool SheriffKillsJester => Generate.SheriffKillsJester.Get();
        public static bool SheriffKillsArsonist => Generate.SheriffKillsArsonist.Get();
        public static bool SheriffKillsJuggernaut => Generate.SheriffKillsJuggernaut.Get();
        public static bool SheriffKillsPlaguebearer => Generate.SheriffKillsPlaguebearer.Get();
        public static bool SheriffKillsGlitch => Generate.SheriffKillsGlitch.Get();
        public static bool SheriffKillsWerewolf => Generate.SheriffKillsWerewolf.Get();
        public static float SheriffKillCd => Generate.SheriffKillCd.Get();
        public static int MayorVoteBank => (int)Generate.MayorVoteBank.Get();
        public static bool MayorAnonymous => Generate.MayorAnonymous.Get();
        public static bool SwapperButton => Generate.SwapperButton.Get();
        public static float FootprintSize => Generate.FootprintSize.Get();
        public static float FootprintInterval => Generate.FootprintInterval.Get();
        public static float FootprintDuration => Generate.FootprintDuration.Get();
        public static bool AnonymousFootPrint => Generate.AnonymousFootPrint.Get();
        public static bool VentFootprintVisible => Generate.VentFootprintVisible.Get();
        public static bool JesterButton => Generate.JesterButton.Get();
        public static bool JesterVent => Generate.JesterVent.Get();
        public static bool JesterImpVision => Generate.JesterImpVision.Get();
        public static ShieldOptions ShowShielded => (ShieldOptions)Generate.ShowShielded.Get();

        public static NotificationOptions NotificationShield =>
            (NotificationOptions)Generate.WhoGetsNotification.Get();

        public static bool ShieldBreaks => Generate.ShieldBreaks.Get();
        public static float MedicReportNameDuration => Generate.MedicReportNameDuration.Get();
        public static float MedicReportColorDuration => Generate.MedicReportColorDuration.Get();
        public static bool ShowReports => Generate.MedicReportSwitch.Get();
        public static float SeerCd => Generate.SeerCooldown.Get();
        public static bool CrewKillingRed => Generate.CrewKillingRed.Get();
        public static bool NeutBenignRed => Generate.NeutBenignRed.Get();
        public static bool NeutEvilRed => Generate.NeutEvilRed.Get();
        public static bool NeutKillingRed => Generate.NeutKillingRed.Get();
        public static bool TraitorColourSwap => Generate.TraitorColourSwap.Get();
        public static float MimicCooldown => Generate.MimicCooldownOption.Get();
        public static float MimicDuration => Generate.MimicDurationOption.Get();
        public static float HackCooldown => Generate.HackCooldownOption.Get();
        public static float HackDuration => Generate.HackDurationOption.Get();
        public static float GlitchKillCooldown => Generate.GlitchKillCooldownOption.Get();
        public static int GlitchHackDistance => Generate.GlitchHackDistanceOption.Get();
        public static bool GlitchVent => Generate.GlitchVent.Get();
        public static float JuggKCd => Generate.JuggKillCooldown.Get();
        public static float ReducedKCdPerKill => Generate.ReducedKCdPerKill.Get();
        public static bool JuggVent => Generate.JuggVent.Get();
        public static float MorphlingCd => Generate.MorphlingCooldown.Get();
        public static float MorphlingDuration => Generate.MorphlingDuration.Get();
        public static bool MorphlingVent => Generate.MorphlingVent.Get();
        public static bool ColourblindComms => Generate.ColourblindComms.Get();
        public static OnTargetDead OnTargetDead => (OnTargetDead)Generate.OnTargetDead.Get();
        public static bool ExecutionerButton => Generate.ExecutionerButton.Get();
        public static bool SnitchSeesNeutrals => Generate.SnitchSeesNeutrals.Get();
        public static int SnitchTasksRemaining => (int)Generate.SnitchTasksRemaining.Get();
        public static bool SnitchSeesImpInMeeting => Generate.SnitchSeesImpInMeeting.Get();
        public static bool SnitchSeesTraitor => Generate.SnitchSeesTraitor.Get();
        public static float MineCd => Generate.MineCooldown.Get();
        public static float SwoopCd => Generate.SwoopCooldown.Get();
        public static float SwoopDuration => Generate.SwoopDuration.Get();
        public static bool SwooperVent => Generate.SwooperVent.Get();
        public static bool ImpostorSeeRoles => Generate.ImpostorSeeRoles.Get();
        public static bool DeadSeeRoles => Generate.DeadSeeRoles.Get();
        public static bool DisableLevels => Generate.DisableLevels.Get();
        public static bool WhiteNameplates => Generate.WhiteNameplates.Get();
        public static bool HiddenRoles => Generate.HiddenRoles.Get();
        public static bool SeeTasksDuringRound => Generate.SeeTasksDuringRound.Get();
        public static bool SeeTasksDuringMeeting => Generate.SeeTasksDuringMeeting.Get();
        public static bool SeeTasksWhenDead => Generate.SeeTasksWhenDead.Get();
        public static float DouseCd => Generate.DouseCooldown.Get();
        public static int MaxDoused => (int)Generate.MaxDoused.Get();
        public static bool ArsoImpVision => Generate.ArsoImpVision.Get();
        public static bool IgniteCdRemoved => Generate.IgniteCdRemoved.Get();
        public static int MinNeutralNonKillingRoles => (int)Generate.MinNeutralNonKillingRoles.Get();
        public static int MaxNeutralNonKillingRoles => (int)Generate.MaxNeutralNonKillingRoles.Get();
        public static int MinNeutralKillingRoles => (int)Generate.MinNeutralKillingRoles.Get();
        public static int MaxNeutralKillingRoles => (int)Generate.MaxNeutralKillingRoles.Get();
        public static bool RandomNumberImps => Generate.RandomNumberImps.Get();
        public static int NeutralRoles => (int)Generate.NeutralRoles.Get();
        public static int VeteranCount => (int)Generate.VeteranCount.Get();
        public static int VigilanteCount => (int)Generate.VigilanteCount.Get();
        public static bool AddArsonist => Generate.AddArsonist.Get();
        public static bool AddPlaguebearer => Generate.AddPlaguebearer.Get();
        public static bool ParallelMedScans => Generate.ParallelMedScans.Get();
        public static int MaxFixes => (int)Generate.MaxFixes.Get();
        public static float ReviveDuration => Generate.ReviveDuration.Get();
        public static bool AltruistTargetBody => Generate.AltruistTargetBody.Get();
        public static bool SheriffBodyReport => Generate.SheriffBodyReport.Get();
        public static float DragCd => Generate.DragCooldown.Get();
        public static float UndertakerDragSpeed => Generate.UndertakerDragSpeed.Get();
        public static bool UndertakerVent => Generate.UndertakerVent.Get();
        public static bool UndertakerVentWithBody => Generate.UndertakerVentWithBody.Get();
        public static bool AssassinGuessNeutralBenign => Generate.AssassinGuessNeutralBenign.Get();
        public static bool AssassinGuessNeutralEvil => Generate.AssassinGuessNeutralEvil.Get();
        public static bool AssassinGuessNeutralKilling => Generate.AssassinGuessNeutralKilling.Get();
        public static bool AssassinGuessImpostors => Generate.AssassinGuessImpostors.Get();
        public static bool AssassinGuessModifiers => Generate.AssassinGuessModifiers.Get();
        public static bool AssassinGuessLovers => Generate.AssassinGuessLovers.Get();
        public static bool AssassinCrewmateGuess => Generate.AssassinCrewmateGuess.Get();
        public static int AssassinKills => (int)Generate.AssassinKills.Get();
        public static int NumberOfImpostorAssassins => (int)Generate.NumberOfImpostorAssassins.Get();
        public static int NumberOfNeutralAssassins => (int)Generate.NumberOfNeutralAssassins.Get();
        public static bool AmneTurnImpAssassin => Generate.AmneTurnImpAssassin.Get();
        public static bool AmneTurnNeutAssassin => Generate.AmneTurnNeutAssassin.Get();
        public static bool TraitorCanAssassin => Generate.TraitorCanAssassin.Get();
        public static bool AssassinMultiKill => Generate.AssassinMultiKill.Get();
        public static bool AssassinateAfterVoting => Generate.AssassinateAfterVoting.Get();
        public static float UnderdogKillBonus => Generate.UnderdogKillBonus.Get();
        public static bool UnderdogIncreasedKC => Generate.UnderdogIncreasedKC.Get();
        public static int PhantomTasksRemaining => (int)Generate.PhantomTasksRemaining.Get();
        public static bool VigilanteGuessNeutralBenign => Generate.VigilanteGuessNeutralBenign.Get();
        public static bool VigilanteGuessNeutralEvil => Generate.VigilanteGuessNeutralEvil.Get();
        public static bool VigilanteGuessNeutralKilling => Generate.VigilanteGuessNeutralKilling.Get();
        public static bool VigilanteGuessLovers => Generate.VigilanteGuessLovers.Get();
        public static int VigilanteKills => (int)Generate.VigilanteKills.Get();
        public static bool VigilanteMultiKill => Generate.VigilanteMultiKill.Get();
        public static bool VigilanteAfterVoting => Generate.VigilanteAfterVoting.Get();
        public static int HaunterTasksRemainingClicked => (int)Generate.HaunterTasksRemainingClicked.Get();
        public static int HaunterTasksRemainingAlert => (int)Generate.HaunterTasksRemainingAlert.Get();
        public static bool HaunterRevealsNeutrals => Generate.HaunterRevealsNeutrals.Get();
        public static HaunterCanBeClickedBy HaunterCanBeClickedBy => (HaunterCanBeClickedBy)Generate.HaunterCanBeClickedBy.Get();
        public static float GrenadeCd => Generate.GrenadeCooldown.Get();
        public static float GrenadeDuration => Generate.GrenadeDuration.Get();
        public static bool GrenadierIndicators => Generate.GrenadierIndicators.Get();
        public static bool GrenadierVent => Generate.GrenadierVent.Get();
        public static float FlashRadius => Generate.FlashRadius.Get();
        public static int LovingImpPercent => (int)Generate.LovingImpPercent.Get();
        public static bool KilledOnAlert => Generate.KilledOnAlert.Get();
        public static float AlertCd => Generate.AlertCooldown.Get();
        public static float AlertDuration => Generate.AlertDuration.Get();
        public static int MaxAlerts => (int)Generate.MaxAlerts.Get();
        public static float UpdateInterval => Generate.UpdateInterval.Get();
        public static float TrackCd => Generate.TrackCooldown.Get();
        public static bool ResetOnNewRound => Generate.ResetOnNewRound.Get();
        public static int MaxTracks => (int)Generate.MaxTracks.Get();
        public static int LatestSpawn => (int)Generate.LatestSpawn.Get();
        public static bool NeutralKillingStopsTraitor => Generate.NeutralKillingStopsTraitor.Get();
        public static float TransportCooldown => Generate.TransportCooldown.Get();
        public static int TransportMaxUses => (int)Generate.TransportMaxUses.Get();
        public static bool TransporterVitals => Generate.TransporterVitals.Get();
        public static bool RememberArrows => Generate.RememberArrows.Get();
        public static float RememberArrowDelay => Generate.RememberArrowDelay.Get();
        public static float MediateCooldown => Generate.MediateCooldown.Get();
        public static bool ShowMediatePlayer => Generate.ShowMediatePlayer.Get();
        public static bool ShowMediumToDead => Generate.ShowMediumToDead.Get();
        public static DeadRevealed DeadRevealed => (DeadRevealed)Generate.DeadRevealed.Get();
        public static float VestCd => Generate.VestCd.Get();
        public static float VestDuration => Generate.VestDuration.Get();
        public static float VestKCReset => Generate.VestKCReset.Get();
        public static int MaxVests => (int)Generate.MaxVests.Get();
        public static float ProtectCd => Generate.ProtectCd.Get();
        public static float ProtectDuration => Generate.ProtectDuration.Get();
        public static float ProtectKCReset => Generate.ProtectKCReset.Get();
        public static int MaxProtects => (int)Generate.MaxProtects.Get();
        public static ProtectOptions ShowProtect => (ProtectOptions)Generate.ShowProtect.Get();
        public static BecomeOptions GaOnTargetDeath => (BecomeOptions)Generate.GaOnTargetDeath.Get();
        public static bool GATargetKnows => Generate.GATargetKnows.Get();
        public static bool GAKnowsTargetRole => Generate.GAKnowsTargetRole.Get();
        public static float MysticArrowDuration => Generate.MysticArrowDuration.Get();
        public static float BlackmailCd => Generate.BlackmailCooldown.Get();
        public static float GiantSlow => Generate.GiantSlow.Get();
        public static float FlashSpeed => Generate.FlashSpeed.Get();
        public static float DiseasedMultiplier => Generate.DiseasedKillMultiplier.Get();
        public static float BaitMinDelay => Generate.BaitMinDelay.Get();
        public static float BaitMaxDelay => Generate.BaitMaxDelay.Get();
        public static float InfectCd => Generate.InfectCooldown.Get();
        public static float PestKillCd => Generate.PestKillCooldown.Get();
        public static bool PestVent => Generate.PestVent.Get();
        public static float RampageCd => Generate.RampageCooldown.Get();
        public static float RampageDuration => Generate.RampageDuration.Get();
        public static float RampageKillCd => Generate.RampageKillCooldown.Get();
        public static bool WerewolfVent => Generate.WerewolfVent.Get();
        public static float TrapCooldown => Generate.TrapCooldown.Get();
        public static bool TrapsRemoveOnNewRound => Generate.TrapsRemoveOnNewRound.Get();
        public static int MaxTraps => (int)Generate.MaxTraps.Get();
        public static float MinAmountOfTimeInTrap => Generate.MinAmountOfTimeInTrap.Get();
        public static float TrapSize => Generate.TrapSize.Get();
        public static int MinAmountOfPlayersInTrap => (int) Generate.MinAmountOfPlayersInTrap.Get();
        public static float InitialExamineCd => Generate.InitialExamineCooldown.Get();
        public static float ExamineCd => Generate.ExamineCooldown.Get();
        public static float RecentKill => Generate.RecentKill.Get();
        public static bool DetectiveReportOn => Generate.DetectiveReportOn.Get();
        public static float DetectiveRoleDuration => Generate.DetectiveRoleDuration.Get();
        public static float DetectiveFactionDuration => Generate.DetectiveFactionDuration.Get();
        public static bool ExamineReportOn => Generate.ExamineReportOn.Get();
        public static float EscapeCd => Generate.EscapeCooldown.Get();
        public static bool EscapistVent => Generate.EscapistVent.Get();
        public static float DetonateDelay => Generate.DetonateDelay.Get();
        public static int MaxKillsInDetonation => (int) Generate.MaxKillsInDetonation.Get();
        public static float DetonateRadius => Generate.DetonateRadius.Get();
        public static bool BomberVent => Generate.BomberVent.Get();
        public static AdminDeadPlayers WhoSeesDead => (AdminDeadPlayers)Generate.WhoSeesDead.Get();
        public static bool VentImprovements => Generate.VentImprovements.Get();
        public static bool VitalsLab => Generate.VitalsLab.Get();
        public static bool ColdTempDeathValley => Generate.ColdTempDeathValley.Get();
        public static bool WifiChartCourseSwap => Generate.WifiChartCourseSwap.Get();
        public static bool RandomMapEnabled => Generate.RandomMapEnabled.Get();
        public static float RandomMapSkeld => Generate.RandomMapSkeld.Get();
        public static float RandomMapMira => Generate.RandomMapMira.Get();
        public static float RandomMapPolus => Generate.RandomMapPolus.Get();
        public static float RandomMapAirship => Generate.RandomMapAirship.Get();
        public static float RandomMapSubmerged => Patches.SubmergedCompatibility.Loaded ? Generate.RandomMapSubmerged.Get() : 0f;
        public static bool AutoAdjustSettings => Generate.AutoAdjustSettings.Get();
        public static bool SmallMapHalfVision => Generate.SmallMapHalfVision.Get();
        public static float SmallMapDecreasedCooldown => Generate.SmallMapDecreasedCooldown.Get();
        public static float LargeMapIncreasedCooldown => Generate.LargeMapIncreasedCooldown.Get();
        public static int SmallMapIncreasedShortTasks => (int)Generate.SmallMapIncreasedShortTasks.Get();
        public static int SmallMapIncreasedLongTasks => (int)Generate.SmallMapIncreasedLongTasks.Get();
        public static int LargeMapDecreasedShortTasks => (int)Generate.LargeMapDecreasedShortTasks.Get();
        public static int LargeMapDecreasedLongTasks => (int)Generate.LargeMapDecreasedLongTasks.Get();
        public static DisableSkipButtonMeetings SkipButtonDisable =>
            (DisableSkipButtonMeetings)Generate.SkipButtonDisable.Get();
        public static GameMode GameMode =>
            (GameMode)Generate.GameMode.Get();
        public static int MayorCultistOn => (int)Generate.MayorCultistOn.Get();
        public static int SeerCultistOn => (int)Generate.SeerCultistOn.Get();
        public static int SheriffCultistOn => (int)Generate.SheriffCultistOn.Get();
        public static int SurvivorCultistOn => (int)Generate.SurvivorCultistOn.Get();
        public static int SpecialRoleCount => (int)Generate.NumberOfSpecialRoles.Get();
        public static int MaxChameleons => (int)Generate.MaxChameleons.Get();
        public static int MaxEngineers => (int)Generate.MaxEngineers.Get();
        public static int MaxInvestigators => (int)Generate.MaxInvestigators.Get();
        public static int MaxMystics => (int)Generate.MaxMystics.Get();
        public static int MaxSpies => (int)Generate.MaxSpies.Get();
        public static int MaxTransporters => (int)Generate.MaxTransporters.Get();
        public static int MaxVigilantes => (int)Generate.MaxVigilantes.Get();
        public static float WhisperCooldown => Generate.WhisperCooldown.Get();
        public static float IncreasedCooldownPerWhisper => Generate.IncreasedCooldownPerWhisper.Get();
        public static float WhisperRadius => Generate.WhisperRadius.Get();
        public static int ConversionPercentage => (int) Generate.ConversionPercentage.Get();
        public static int DecreasedPercentagePerConversion => (int) Generate.DecreasedPercentagePerConversion.Get();
        public static float ReviveCooldown => Generate.ReviveCooldown.Get();
        public static float IncreasedCooldownPerRevive => Generate.IncreasedCooldownPerRevive.Get();
        public static int MaxReveals => (int)Generate.MaxReveals.Get();
    }
}