using Naninovel;
using Naninovel.Commands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    private async void Start()
    {

        await RuntimeInitializer.InitializeAsync();

        var advCamera = GameObject.Find("AdventureModeCamera").GetComponent<Camera>();
        advCamera.enabled = false;
        var advCanvas = GameObject.Find("CanvasGame").GetComponent<Canvas>();
        advCanvas.enabled = false;
        var advCanvasLevel = GameObject.Find("Canvas").GetComponent<Canvas>();
        advCanvasLevel.enabled = false;
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = true;



        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

    }


    public async void BackToGame()
    {

        await RuntimeInitializer.InitializeAsync();

        var advCamera = GameObject.Find("AdventureModeCamera").GetComponent<Camera>();
        advCamera.enabled = false;
        var advCanvas = GameObject.Find("CanvasGame").GetComponent<Canvas>();
        advCanvas.enabled = false;
        var advCanvasLevel = GameObject.Find("Canvas").GetComponent<Canvas>();
        advCanvasLevel.enabled = false;
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = true;

       // var naniAudio = Engine.GetService<IAudioManager>();
       // await naniAudio.PlayBgmAsync("Mini_game_theme", 0.3f);

        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;


        var player = Engine.GetService<IScriptPlayer>();
        await player.PreloadAndPlayAsync("After_minigame");
    }

}
