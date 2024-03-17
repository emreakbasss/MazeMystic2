using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinText;
    [SerializeField] private GameObject _endingPanel;
    private bool _isEnd;
    public bool IsEnd { get => _isEnd; }

    private void Start()
    {
        _endingPanel.SetActive(false);
    }
    public static UIManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void UpdateCoinText(int coin)
    {
        _coinText.text = coin.ToString();
    }
    public void EndGameUI()
    {
        _isEnd = true;
        _endingPanel.SetActive(true);
    }
}
