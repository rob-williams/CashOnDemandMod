using ColossalFramework;
using UnityEngine;

public class CashOnDemandComponent : MonoBehaviour {

    private static readonly int CashAmount = 5000000;

    private bool CtrlCmdDown {
        get {
            return Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl) ||
                   Input.GetKey(KeyCode.LeftCommand) || Input.GetKey(KeyCode.RightCommand);
        }
    }

    private bool ShiftDown {
        get {
            return Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        }
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.M) && this.CtrlCmdDown && this.ShiftDown && Singleton<EconomyManager>.exists) {
            Singleton<EconomyManager>.instance.AddResource(EconomyManager.Resource.RewardAmount,
                                                           CashAmount,
                                                           ItemClass.Service.None,
                                                           ItemClass.SubService.None,
                                                           ItemClass.Level.None);
        }
    }
}