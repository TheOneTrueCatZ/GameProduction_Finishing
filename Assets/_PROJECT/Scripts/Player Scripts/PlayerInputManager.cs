using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform[] spawnPoints;
    
    private bool wasdJoined = false;
    private bool ControllerJoined = false;

    private void Update()
    {
        if (Keyboard.current == null) return;

        if (!wasdJoined && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            var player = PlayerInput.Instantiate(playerPrefab,controlScheme: "Keyboard",pairWithDevice:Keyboard.current);

            if (spawnPoints.Length > 0)
            {
                player.transform.position = spawnPoints[0].position;
            }
            wasdJoined = true;
        }

        foreach (var gamePad in Gamepad.all)
        {
            if (gamePad.startButton.wasPressedThisFrame)
            {
                PlayerInput.Instantiate(playerPrefab,controlScheme: "Gamepad",pairWithDevice:gamePad);
            }
        }
    }
}

