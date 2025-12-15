using System;
using HarmonyLib;
using Winch.Config;

namespace DredgeMooTemplate.Costs.Patches
{
	[HarmonyPatch(typeof(GameConfigData), "HullRepairCostPerSquare", MethodType.Getter)]
	public static class GameConfigData_HullRepair_Patch
	{
		[HarmonyPostfix]
		static void HullRepairCostPerSquare(ref decimal __result)
		{
			__result *= 10;
		}
	}
}