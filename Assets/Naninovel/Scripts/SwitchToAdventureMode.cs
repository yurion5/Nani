using Naninovel;
using Naninovel.Commands;
using UnityEngine;

[CommandAlias("adventure")]
public class SwitchToAdventureMode : Command
{
    [ParameterAlias("reset")]
    public BooleanParameter ResetState = true;

    public override async UniTask ExecuteAsync (AsyncToken asyncToken = default)
    {

        // 1. Disable Naninovel input.
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = false;

        // 2. Stop script player.
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Stop();

        // 3. Hide text printer.
        var hidePrinter = new HidePrinter();
        hidePrinter.ExecuteAsync(asyncToken).Forget();

        // 4. Reset state (if required).
        if (ResetState)
        {
            var stateManager = Engine.GetService<IStateManager>();
            await stateManager.ResetStateAsync();
        }

        // 5. Switch cameras.
        var advCamera = GameObject.Find("AdventureModeCamera").GetComponent<Camera>();
        advCamera.enabled = true;
        var advCanvas = GameObject.Find("CanvasGame").GetComponent<Canvas>();
        var advCanvasAlpha = advCanvas.GetComponent<CanvasGroup>();
        advCanvasAlpha.alpha = 1;
        advCanvas.enabled = true;
        var advCanvasLevel = GameObject.Find("Canvas").GetComponent<Canvas>();
        var advCanvasLevelAlpha = advCanvasLevel.GetComponent<CanvasGroup>();
        advCanvasLevelAlpha.alpha = 1;
        advCanvasLevel.enabled = true;
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = false;

        //6.Audio
        var naniAudio = Engine.GetService<IAudioManager>();
        await naniAudio.PlayBgmAsync("Mini_game_theme",0.3f);
    }
}
