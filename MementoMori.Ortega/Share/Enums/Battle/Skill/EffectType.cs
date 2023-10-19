﻿using System.ComponentModel;

namespace MementoMori.Ortega.Share.Enums.Battle.Skill
{
    [Description("バフ・デバフ効果種別")]
    public enum EffectType
    {
        [Description("なし")] None = 0,
        [Description("スピード増加")] SpeedUp = 1001,
        [Description("最大HP増加")] MaxHpUp = 1002,
        [Description("攻撃力増加")] AttackPowerUp = 1003,
        [Description("防御力増加")] DefenseUp = 1004,
        [Description("物理ダメージ緩和増加")] PhysicalDamageRelaxUp = 1005,
        [Description("魔法ダメージ緩和増加")] MagicDamageRelaxUp = 1006,
        [Description("防御貫通力増加")] DefensePenetrationUp = 1007,
        [Description("ダメージ強化増加")] DamageEnhanceUp = 1008,
        [Description("命中増加")] HitUp = 1009,
        [Description("回避増加")] AvoidanceUp = 1010,
        [Description("クリティカル増加")] CriticalUp = 1011,
        [Description("クリティカル耐性増加")] CriticalResistUp = 1012,
        [Description("HP吸収増加")] HpDrainUp = 1013,
        [Description("カウンタ増加")] DamageReflectUp = 1014,
        [Description("クリダメ強化増加")] CriticalDamageEnhanceUp = 1015,
        [Description("物理クリダメ緩和増加")] PhysicalCriticalDamageRelaxUp = 1016,
        [Description("魔法クリダメ緩和増加")] MagicCriticalDamageRelaxUp = 1017,
        [Description("弱体効果命中増加")] DebuffHitUp = 1018,
        [Description("弱体効果耐性増加")] DebuffResistUp = 1019,
        [Description("与HP回復量増加")] GiveHealRateUp = 1020,
        [Description("被HP回復量増加")] ReceiveHealRateUp = 1021,
        [Description("与ダメージ増加")] GiveDamageUp = 1022,
        [Description("被ダメージ減少")] ReceiveDamageDown = 1023,
        [Description("スキルクールダウン加速")] CoolTimeRecoveryUp = 1024,
        [Description("属性ダメージボーナス増加")] ElementBonusUp = 1025,
        [Description("与ダメージ基準値増加")] GiveDamageStandardUp = 1026,
        [Description("被ダメージ基準値減少")] ReceiveDamageStandardDown = 1027,
        [Description("命中率増加")] HitRateUp = 1500,
        [Description("回避率増加")] AvoidanceRateUp = 1501,
        [Description("クリティカル率増加")] CriticalRateUp = 1502,
        [Description("クリティカル耐性率増加")] CriticalResistRateUp = 1503,
        [Description("弱体効果命中率増加")] DebuffHitRateUp = 1504,
        [Description("弱体効果耐性率増加")] DebuffResistRateUp = 1505,
        [Description("ダメージ無効化")] DamageGuard = 2001,
        [Description("シールド1")] Shield1 = 2002,
        [Description("シールド2")] Shield2 = 2003,
        [Description("デバフ無効化")] DebuffGuard = 2004,
        [Description("行動阻害無効化")] ConfuseActionDebuffGuard = 2005,
        [Description("挑発")] Taunt = 2006,
        [Description("潜伏")] Stealth = 2007,
        [Description("除外")] NonTarget = 2008,
        [Description("デバフ付与")] GiveDebuff = 2009,
        [Description("通常攻撃強化")] NormalSkillEnhance = 2011,
        [Description("毎ターン回復")] HealOverTime = 2012,
        [Description("必ず回避")] NonHit = 2013,
        [Description("不死身")] Immortal = 2014,
        [Description("印")] SkillMark = 2015,
        [Description("スキル1強化")] ActiveSkill1Enhance = 2100,
        [Description("スキル2強化")] ActiveSkill2Enhance = 2101,
        [Description("カウンタ変更11")] DamageReflectEnhance11 = 2111,
        [Description("カウンタ変更12")] DamageReflectEnhance12 = 2112,
        [Description("カウンタ変更13")] DamageReflectEnhance13 = 2113,
        [Description("カウンタ変更14")] DamageReflectEnhance14 = 2114,
        [Description("カウンタ変更21")] DamageReflectEnhance21 = 2121,
        [Description("カウンタ変更22")] DamageReflectEnhance22 = 2122,
        [Description("カウンタ変更23")] DamageReflectEnhance23 = 2123,
        [Description("カウンタ変更24")] DamageReflectEnhance24 = 2124,
        [Description("カウンタ変更31")] DamageReflectEnhance31 = 2131,
        [Description("カウンタ変更32")] DamageReflectEnhance32 = 2132,
        [Description("カウンタ変更33")] DamageReflectEnhance33 = 2133,
        [Description("カウンタ変更34")] DamageReflectEnhance34 = 2134,
        [Description("全てのスキルのクールタイムを回復")] AllSkillCoolTimeRecovery = 3001,
        [Description("スキル1のクールタイムを回復")] Skill1CoolTimeRecovery = 3002,
        [Description("スキル2のクールタイムを回復")] Skill2CoolTimeRecovery = 3003,
        [Description("全てのスキルのクールタイムを増加")] AllSkillCoolTimeIncrease = 3004,
        [Description("スキル1のクールタイムを増加")] Skill1CoolTimeIncrease = 3005,
        [Description("スキル2のクールタイムを増加")] Skill2CoolTimeIncrease = 3006,
        [Description("すべてのバフ効果のターンを増やす")] ExtendAllBuffTurn = 3041,
        [Description("すべてのデバフ効果のターンを増やす")] ExtendAllDeBuffTurn = 3042,
        [Description("すべてのスタン効果のターンを増やす")] ExtendStunTurn = 3043,
        [Description("すべてのバフ効果のターンを減らす")] ReduceAllBuffTurn = 3044,
        [Description("すべてのデバフ効果のターンを減らす")] ReduceAllDeBuffTurn = 3045,
        [Description("指定した効果グループのターン数を1増やす")] ExtendEffectGroup = 3046,
        [Description("指定した効果グループのターン数を1減らす")] ReduceEffectGroup = 3047,
        [Description("指定したEffectのスタック数を1増やす")] IncreaseEffectStack = 3048,
        [Description("指定したEffectのスタック数を1減らす")] DecreaseEffectStack = 3049,
        [Description("全てのバフを解除")] RemoveAllBuff = 3050,
        [Description("全てのデバフを解除")] RemoveAllDeBuff = 3060,
        [Description("全ての行動阻害デバフを解除")] RemoveAllConfuseActionGroupDebuff = 3061,
        [Description("同じグループ効果を解除")] RemoveEffectGroup = 3101,
        [Description("同じタイプの効果をすべて解除")] RemoveEffectType = 3102,
        [Description("バフを解除")] RemoveBuff = 3103,
        [Description("デバフを解除")] RemoveDeBuff = 3104,
        [Description("同じタイプの固有効果をすべて解除")] RemoveSpecialEffectType = 3105,
        [Description("アーカイブバフをコピー")] CopyArchiveBuff = 3200,
        [Description("アーカイブデバフをコピー")] CopyArchiveDeBuff = 3201,
        [Description("ターゲットの全てのバフをコピー")] CopyAllBuffTargetToSelf = 3202,
        [Description("自分のすべてのデバフをターゲットにコピー")] CopyAllDeBuffSelfToTarget = 3203,
        [Description("敵のバフを奪う")] MoveBuffToMeFromEnemy = 3204,
        [Description("自分のデバフを敵に移す")] MoveDebuffToEnemyFromMe = 3205,
        [Description("スピード減少")] SpeedDown = 5001,
        [Description("最大HP減少")] MaxHpDown = 5002,
        [Description("攻撃力減少")] AttackPowerDown = 5003,
        [Description("防御力減少")] DefenseDown = 5004,
        [Description("物理ダメージ緩和減少")] PhysicalDamageRelaxDown = 5005,
        [Description("魔法ダメージ緩和減少")] MagicDamageRelaxDown = 5006,
        [Description("防御貫通力減少")] DefensePenetrationDown = 5007,
        [Description("ダメージ強化減少")] DamageEnhanceDown = 5008,
        [Description("命中減少")] HitDown = 5009,
        [Description("回避減少")] AvoidanceDown = 5010,
        [Description("クリティカル減少")] CriticalDown = 5011,
        [Description("クリティカル耐性減少")] CriticalResistDown = 5012,
        [Description("HP吸収減少")] HpDrainDown = 5013,
        [Description("カウンタ減少")] DamageReflectDown = 5014,
        [Description("クリダメ強化減少")] CriticalDamageEnhanceDown = 5015,
        [Description("物理クリダメ緩和減少")] PhysicalCriticalDamageRelaxDown = 5016,
        [Description("魔法クリダメ緩和減少")] MagicCriticalDamageRelaxDown = 5017,
        [Description("弱体効果命中減少")] DebuffHitDown = 5018,
        [Description("弱体効果耐性減少")] DebuffResistDown = 5019,
        [Description("与HP回復量減少")] GiveHealRateDown = 5020,
        [Description("被HP回復量減少")] ReceiveHealRateDown = 5021,
        [Description("与ダメージ減少")] GiveDamageDown = 5022,
        [Description("被ダメージ増加")] ReceiveDamageUp = 5023,
        [Description("スキルクールダウン減少")] CoolTimeRecoveryDown = 5024,
        [Description("与ダメージ基準値減少")] GiveDamageStandardDown = 5025,
        [Description("被ダメージ基準値増加")] ReceiveDamageStandardUp = 5026,
        [Description("命中率減少")] HitRateDown = 5500,
        [Description("回避率減少")] AvoidanceRateDown = 5501,
        [Description("クリティカル率減少")] CriticalRateDown = 5502,
        [Description("クリティカル耐性率減少")] CriticalResistRateDown = 5503,
        [Description("弱体効果命中率減少")] DebuffHitRateDown = 5504,
        [Description("弱体効果耐性率減少")] DebuffResistRateDown = 5505,
        [Description("スタン")] Stun = 6001,
        [Description("混乱")] Confuse = 6002,
        [Description("封印")] Silence = 6003,
        [Description("固執")] Stubborn = 6004,
        [Description("HP回復不可")] HpRecoveryForbidden = 7002,
        [Description("バフ獲得不可")] BuffForbidden = 7003,
        [Description("回避不可")] AvoidanceForbidden = 7004,
        [Description("ロックオン11")] LockOnSelf = 7111,
        [Description("ロックオン21")] LockOnAllAlly = 7121,
        [Description("ロックオン31")] LockOnBlueAlly = 7131,
        [Description("ロックオン32")] LockOnRedAlly = 7132,
        [Description("ロックオン33")] LockOnGreenAlly = 7133,
        [Description("ロックオン34")] LockOnYellowAlly = 7134,
        [Description("ロックオン35")] LockOnLightAlly = 7135,
        [Description("ロックオン36")] LockOnDarkAlly = 7136,
        [Description("ロックオン41")] LockOnWarriorAlly = 7141,
        [Description("ロックオン42")] LockOnSniperAlly = 7142,
        [Description("ロックオン43")] LockOnSorcererAlly = 7143,
        [Description("ロックオン51")] LockOnAttack1Ally = 7151,
        [Description("ロックオン52")] LockOnAttack2Ally = 7152,
        [Description("ロックオン53")] LockOnAttack3Ally = 7153,
        [Description("毒")] Poison = 8001,
        [Description("出血")] Bleeding = 8002,
        [Description("浸食")] Combustion = 8003,
        [Description("火傷")] Burn = 8004,
        [Description("ダメージ連携11")] DamageResonanceFromSelfAndDamageReduction = 8111,
        [Description("ダメージ連携21")] DamageResonanceFromHighHpEnemy = 8121,
        [Description("ダメージ連携22")] DamageResonanceFromLowHpEnemy = 8122,
        [Description("ダメージ連携23")] DamageResonanceFromHighDefenseEnemy = 8123,
        [Description("ダメージ連携24")] DamageResonanceFromLowDefenseEnemy = 8124,
        [Description("ダメージ連携25")] DamageResonanceFromRandomEnemy = 8125,
        [Description("ダメージ連携26")] DamageResonanceFromHighBaseMaxHpEnemy = 8126,
        [Description("ダメージ連携27")] DamageResonanceFromLowBaseMaxHpEnemy = 8127,
        [Description("ダメージ連携28")] DamageResonanceFromHighBaseDefenseEnemy = 8128,
        [Description("ダメージ連携29")] DamageResonanceFromLowBaseDefenseEnemy = 8129,
        [Description("ダメージ連携31")] DamageResonanceFromAllEnemy = 8131,
        [Description("ダメージ連携41")] DamageResonanceFromAllAllyAndDamageReduction = 8141,
        [Description("スピード吸収")] SpeedDrain = 9001,
        [Description("攻撃力吸収")] AttackPowerDrain = 9003,
        [Description("防御力吸収")] DefenseDrain = 9004
    }
}