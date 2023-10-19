using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public static class InputManager
{
    private static Controls _controls;

    public static void init(Player myPlayer)
    {
        _controls = new Controls();
        _controls.Permanant.Enable();

        _controls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector2>());
        };

    }

    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void UIMode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable();
    }
}
