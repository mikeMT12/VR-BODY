using System;
using UnityEngine;

public class GameManagerForTriggers : MonoBehaviour
{
    [SerializeField] private HandForTriggers _leftHand;
    [SerializeField] private HandForTriggers _rightHand;
    [SerializeField] private GameObject _oldClothes;
    //[SerializeField] private Transform _newClothes;
    [SerializeField] private GameObject _newClothesGO;
    [SerializeField] private GameObject _oldPlayerController;
    [SerializeField] private GameObject _newPlayerController;
    [SerializeField] private GameObject _trousers;
    [SerializeField] private GameObject _boots1;
    [SerializeField] private GameObject _boots2;
    [SerializeField] private GameObject _coat;
    [SerializeField] private GameObject _belt;
    [SerializeField] private GameObject _helmet;
    [SerializeField] private GameObject _gloves1;
    [SerializeField] private GameObject _gloves2;
    public int TrouserStage = 2;
    public int CoatStage = 6;
    public int BeltStage = 7;
    public int HelmetStage = 8;
    public int GlovesStage = 9;
    private float _leftStage, _rightStage;


    private void Start()
    {
        _leftStage = _leftHand.stage;
        _rightStage = _rightHand.stage;
        Debug.Log(_leftHand.points.Length);
    }
    
    public void ClothesOn()
    {
        if(_leftStage == TrouserStage && _rightStage == TrouserStage)
        {
            _trousers.SetActive(true);
            _boots1.SetActive(true);
            _boots2.SetActive(true);

        }
        if (_leftStage == CoatStage && _rightStage == CoatStage)
        {
            _coat.SetActive(true);
        }
        if (_leftStage == BeltStage && _rightStage == BeltStage)
        {
            _belt.SetActive(true);
        }
        if (_leftStage == HelmetStage && _rightStage == HelmetStage)
        {
            _helmet.SetActive(true);
        }
        if (_leftStage == GlovesStage && _rightStage == GlovesStage)
        {
            _gloves1.SetActive(true);
            _gloves2.SetActive(true);
        }

    }
    public void CheckOfAll()
    {
        if (_leftStage == _leftHand.points.Length && _rightStage == _rightHand.points.Length)
        {
            //_oldClothes.transform.SetParent(_newClothes);
            _oldClothes.SetActive(false);
            _trousers.SetActive(false);
            _coat.SetActive(false);
            _belt.SetActive(false);
            _helmet.SetActive(false);
            _gloves1.SetActive(false);
            _gloves2.SetActive(false);
            _boots1.SetActive(false);
            _boots2.SetActive(false);
            _oldPlayerController.SetActive(false);
            _newClothesGO.SetActive(true);
            _newPlayerController.SetActive(true);

        }
    }
}