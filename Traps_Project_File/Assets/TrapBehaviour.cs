using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    private Trap trap;

    private void Awake()
    {
        trap = new Trap();
    }
    private void OnTriggerEnter(Collider other)
    {
        var characterMover = other.GetComponent<ICharacterMover>();
        trap.HandleCharacterEntered(characterMover);
    }
}

public class Trap
{
    public void HandleCharacterEntered(ICharacterMover characterMover)
    {
        characterMover.Health--;
        Debug.Log(characterMover.Health);
    }
}