using System;
using UnityEngine;

public class GameManagerForTriggers : MonoBehaviour
{
    [SerializeField] private HandForTriggers _leftHand;
    [SerializeField] private HandForTriggers _rightHand;
    [SerializeField] private GameObject _oldClothes;
    [SerializeField] private Transform _newClothes;
    [SerializeField] private GameObject _newClothesGO;
    [SerializeField] private GameObject _oldPlayerController;
    [SerializeField] private GameObject _newPlayerController;

    private float _leftStage, _rightStage;


    private void Start()
    {
        _leftStage = _leftHand.stage;
        _rightStage = _rightHand.stage;
    }

    public void Check()
    {
        if (_leftStage == _leftHand.points.Length && _rightStage == _rightHand.points.Length)
        {
            _oldClothes.transform.SetParent(_newClothes);
            _oldClothes.SetActive(false);
            _oldPlayerController.SetActive(true);
            _newClothesGO.SetActive(true);
            _newPlayerController.SetActive(true);
        }
    }
}