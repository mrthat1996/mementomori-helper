﻿using System.ComponentModel;
using MementoMori.Ortega.Share.Data.Battle;
using MementoMori.Ortega.Share.Data.Character;
using MementoMori.Ortega.Share.Data.GuildRaid;
using MementoMori.Ortega.Share.Enums;
using MementoMori.Ortega.Share.Master.Attributes;
using MementoMori.Ortega.Share.Utils;
using MessagePack;

namespace MementoMori.Ortega.Share.Master.Data
{
    [Description(" ギルドレイドボスデータ")]
    [MessagePackObject(true)]
    public class GuildRaidBossMB : MasterBookBase, IHasStartEndTime
    {
		[PropertyOrder(17)]
		[Description("アクティブスキルIDのリスト")]
		public IReadOnlyList<long> ActiveSkillIds { get; }

		[Nest(true, 1)]
		[PropertyOrder(14)]
		[Description("ベースパラメータ")]
		public BaseParameter BaseParameter { get; }

		[Nest(true, 1)]
		[PropertyOrder(15)]
		[Description("バトルパラメータ")]
		public BattleParameter BattleParameter { get; }

		[PropertyOrder(12)]
		[Description("戦闘力")]
		public long BattlePower { get; }

		[PropertyOrder(13)]
		[Description("レアリティ")]
		public CharacterRarityFlags CharacterRarityFlags { get; }

		[PropertyOrder(10)]
		[Description("属性")]
		public ElementType ElementType { get; }

		[PropertyOrder(8)]
		[Description("敵のランク")]
		public long EnemyRank { get; }

		[Nest(false, 0)]
		[PropertyOrder(20)]
		[Description("ギルドダメージバー")]
		public IReadOnlyList<GuildRaidDamageBar> GuildDamageBar { get; }

		[PropertyOrder(3)]
		[Description("ボス種別")]
		public GuildRaidBossType GuildRaidBossType { get; }

		[PropertyOrder(11)]
		[Description("職業")]
		public JobFlags JobFlags { get; }

		[PropertyOrder(9)]
		[Description("名称キー")]
		public string NameKey { get; }

		[Nest(false, 0)]
		[PropertyOrder(19)]
		[Description("通常ダメージバー")]
		public IReadOnlyList<GuildRaidDamageBar> NormalDamageBar { get; }

		[PropertyOrder(16)]
		[Description("通常攻撃として使ってくるスキルID")]
		public long NormalSkillId { get; }

		[PropertyOrder(18)]
		[Description("パッシブスキルIDのリスト")]
		public IReadOnlyList<long> PassiveSkillIds { get; }

		[PropertyOrder(6)]
		[Description("必要ギルド貢献値")]
		public long ReleasableGuildFame { get; }

		[PropertyOrder(2)]
		[Description("ユニットアイコンID")]
		public long UnitIconId { get; }

		[PropertyOrder(1)]
		[Description("ユニットアイコンタイプ")]
		public UnitIconType UnitIconType { get; }

		[PropertyOrder(4)]
		[Description("開始日時（現地時間）")]
		public string StartTime { get; }

		[PropertyOrder(5)]
		[Description("終了日時（現地時間")]
		public string EndTime { get; }

		[PropertyOrder(21)]
		[Description("キャラクター座標X")]
		public float CharacterImageX { get; }

		[PropertyOrder(22)]
		[Description("キャラクター座標Y")]
		public float CharacterImageY { get; }

		[PropertyOrder(23)]
		[Description("キャラクタースケール")]
		public float CharacterImageScale { get; }

		[PropertyOrder(24)]
		[Description("バナーテキスト")]
		public string BannerText { get; }

		[PropertyOrder(25)]
		[Description("ギルドレイドボタン座標U")]
		public float GuildRaidButtonU { get; }

		[PropertyOrder(26)]
		[Description("ギルドレイドボタン座標V")]
		public float GuildRaidButtonV { get; }

		[PropertyOrder(27)]
		[Description("ワールド報酬キャラ画像座標X")]
		public float WorldDamageBarRewardCharacterImageX { get; }

		[PropertyOrder(28)]
		[Description("ワールド報酬キャラ画像座標Y")]
		public float WorldDamageBarRewardCharacterImageY { get; }

		[PropertyOrder(29)]
		[Description("ワールド報酬キャラ画像サイズ")]
		public float WorldDamageBarRewardCharacterImageSize { get; }

        [SerializationConstructor]
        public GuildRaidBossMB(long id, bool? isIgnore, string memo, BaseParameter baseParameter, BattleParameter battleParameter, UnitIconType unitIconType, long unitIconId, long normalSkillId, GuildRaidBossType guildRaidBossType, long releasableGuildFame, IReadOnlyList<long> activeSkillIds, IReadOnlyList<long> passiveSkillIds, long enemyRank, JobFlags jobFlags, ElementType elementType, long battlePower, CharacterRarityFlags characterRarityFlags, string nameKey, IReadOnlyList<GuildRaidDamageBar> normalDamageBar, IReadOnlyList<GuildRaidDamageBar> guildDamageBar, string startTime, string endTime, float characterImageX, float characterImageY, float characterImageScale, string bannerText, float guildRaidButtonU, float guildRaidButtonV, float worldDamageBarRewardCharacterImageX, float worldDamageBarRewardCharacterImageY, float worldDamageBarRewardCharacterImageSize)
            : base(id, isIgnore, memo)
        {
            this.BaseParameter = baseParameter;
            this.BattleParameter = battleParameter;
            this.UnitIconType = unitIconType;
            this.UnitIconId = unitIconId;
            this.NormalSkillId = normalSkillId;
            this.GuildRaidBossType = guildRaidBossType;
            this.ReleasableGuildFame = releasableGuildFame;
            this.ActiveSkillIds = activeSkillIds;
            this.PassiveSkillIds = passiveSkillIds;
            this.EnemyRank = enemyRank;
            this.JobFlags = jobFlags;
            this.ElementType = elementType;
            this.BattlePower = battlePower;
            this.CharacterRarityFlags = characterRarityFlags;
            this.NameKey = nameKey;
            this.NormalDamageBar = normalDamageBar;
            this.GuildDamageBar = guildDamageBar;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.CharacterImageX = characterImageX;
            this.CharacterImageY = characterImageY;
            this.BannerText = bannerText;
            this.GuildRaidButtonU = guildRaidButtonU;
            this.GuildRaidButtonV = guildRaidButtonV;
            this.WorldDamageBarRewardCharacterImageX = worldDamageBarRewardCharacterImageX;
            this.WorldDamageBarRewardCharacterImageY = worldDamageBarRewardCharacterImageY;
            this.WorldDamageBarRewardCharacterImageSize = worldDamageBarRewardCharacterImageSize;
        }

        public GuildRaidBossMB() : base(0L, false, "")
        {
        }
    }
}