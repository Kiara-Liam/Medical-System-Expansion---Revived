﻿using HarmonyLib;
using Verse;

namespace MSE2.HarmonyPatches
{
    public class Hediff_PrettyLabel
    {
        [HarmonyPatch( typeof( Hediff ) )]
        [HarmonyPatch( "LabelBase", MethodType.Getter )]
        internal class Hediff_LabelBase
        {
            [HarmonyPostfix]
            [HarmonyPriority( Priority.Last )]
            private static void HediffPrettyLabel ( ref string __result, Hediff __instance )
            {
                if ( __instance is Hediff_AddedPart || __instance is Hediff_Implant )
                {
                    __result = MedicalSystemExpansion.PrettyLabel( __instance );
                }
            }
        }
    }
}