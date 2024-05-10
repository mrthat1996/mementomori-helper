﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using MementoMori.Ortega.Share.Data.Global;
using MementoMori.Ortega.Share.Master.Attributes;
using MessagePack;

namespace MementoMori.Ortega.Share.Master.Data
{
    [MessagePackObject(true)]
    [Description("よくある質問リスト")]
    public class FaqListMB : MasterBookBase
    {
        [Description("質問項目タイトルKey 2.15.0削除予定")]
        [PropertyOrder(1)]
        public string QuestionTitleKey { get; set; }

        [Nest(false, 0)]
        [PropertyOrder(1)]
        [Description("質問項目タイトル")]
        public TranslatedText QuestionTitle { get; set; }
        
        [Description("遷移先URL")]
        [Nest(false, 0)]
        [PropertyOrder(2)]
        public TranslatedText TransferUrl { get; set; }

        [SerializationConstructor]
        public FaqListMB(long id, bool? isIgnore, string memo, string questionTitleKey, TranslatedText questionTitle, TranslatedText transferUrl)
            : base(id, isIgnore, memo)
        {
            QuestionTitleKey = questionTitleKey;
            QuestionTitle = questionTitle;
            TransferUrl = transferUrl;
        }

        public FaqListMB() : base(0, false, "")
        {
        }
    }
}