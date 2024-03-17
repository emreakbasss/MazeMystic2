using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CoinCollection : MonoBehaviour
{
    private int _coin = 0;
    [SerializeField] private GameObject _gate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            _coin++;
            UIManager.Instance.UpdateCoinText(_coin);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Trigger"))
        {
            _gate.GetComponent<Animator>().Play("Rotate");
        }
    }
}
