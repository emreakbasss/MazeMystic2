using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public void EndGame()
    {
        UIManager.Instance.EndGameUI();
    }
}
