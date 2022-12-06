using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class TrapTests
{
    [Test]
    public void PlayerEnteringTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        CharacterMover characterMover = new CharacterMover();
        trap.HandleCharacterEntered(characterMover);
        Assert.AreEqual(-1, characterMover.Health);
    }
    [Test]
    public void PlayerEnteringTrap_jump()
    {
        JumpTrap mtrap = new JumpTrap();
        CharacterMover characterMover = new CharacterMover();
        mtrap.HandleCharacterEntered(characterMover);
        Assert.AreEqual(false, characterMover.IsMatColor);
    }

    [Test]
    public void PlayerEnteringTrap_ChangeColor()
    {
        ColorTrap ctrap = new ColorTrap();
        CharacterMover characterMover = new CharacterMover();
        ctrap.HandleCharacterEntered(characterMover);
        Assert.AreEqual(false, characterMover.isJumping);
    }
}
