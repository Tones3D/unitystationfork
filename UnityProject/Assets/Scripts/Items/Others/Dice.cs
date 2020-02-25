using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// A die that can be rolled for roleplay purposes; a rolling state should occur every time it is 
/// dropped, thrown, clicked in-inventory, or placed (like on a table). It should play a sound every time
/// it is rolled, as well as scroll through a few possible numbers for a few short frames before finally landing
/// on a chosen number, which will be displayed on a separate sprite above the item.
/// </summary>

public class Dice : MonoBehaviour
{
	[SerializeField]
	public enum DiceType {d2, d4, d6, d8, d10, d12, d20}
    public DiceType DieType;


}

/// <summary>
/// Roll Dice in your hand by clicking on it
/// I literally just took this from edible.cs
/// </summary>
public void ServerPerformInteraction(HandActivate interaction)
{
	TryToEat(interaction.PerformerPlayerScript, interaction.PerformerPlayerScript);
}