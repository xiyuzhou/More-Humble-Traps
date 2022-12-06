using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpingtrap : MonoBehaviour
{
    private JumpTrap trap;

    private void Awake()
    {
        trap = new JumpTrap();
    }
    private void OnTriggerEnter(Collider other)
    {
        var characterMover = other.GetComponent<ICharacterMover>();
        trap.HandleCharacterEntered(characterMover);

    }
}

public class JumpTrap
{
    public void HandleCharacterEntered(ICharacterMover characterMover)
    {
        Debug.Log(characterMover.isJumping);
        characterMover.isJumping = true;
        Debug.Log(characterMover.isJumping);
    }
}