using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorTrap : MonoBehaviour
{
    private ColorTrap trap;

    private void Awake()
    {
        trap = new ColorTrap();
    }
    private void OnTriggerEnter(Collider other)
    {
        var characterMover = other.GetComponent<ICharacterMover>();
        trap.HandleCharacterEntered(characterMover);
    }
}

public class ColorTrap
{
    public void HandleCharacterEntered(ICharacterMover characterMover)
    {
        characterMover.IsMatColor = true;
    }
}