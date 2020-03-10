using RimWorld;
using UnityEngine;
using Verse;

namespace CloseAll
{
    public class AlertCloseAll: Alert
    {
        public AlertCloseAll()
        {
            defaultLabel = "CloseAll".Translate();
            defaultPriority = AlertPriority.High;
            defaultExplanation = "CloseAllDesc".Translate();
        }

        protected override Color BGColor => new Color(1f, 1f, 1f, 0.2f);

        protected override void OnClick()
        {
            Find.LetterStack.LettersListForReading.ListFullCopy().ForEach(letter => Find.LetterStack.RemoveLetter(letter));
        }

        public override AlertReport GetReport()
        {
            return Find.LetterStack.LettersListForReading.Count > 0;
        }
    }
}