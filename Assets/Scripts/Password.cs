using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{

    private string userPassword;
    [Header("Mой пароль")]
    public string myPassword = "123";
    [Header("Поле ввода")]
    public Text entryField;
    [Header("Вывод на экран")]
    public Text outputOnDisplay;
    [Header("Подтвердить ввод")]
    public Button myButton;
    public static bool OpenClosse = false;

    void Start()
    {
        myButton.onClick.AddListener(Enter);
    }

    void Enter()
    {
        userPassword = entryField.GetComponent<Text>().text;
        if (userPassword == myPassword)
        {
            outputOnDisplay.GetComponent<Text>().text = "Доступ открыт";
            outputOnDisplay.GetComponent<Text>().color = new Color(0, 80, 50);
            OpenClosse = true;
        }
        if (userPassword != myPassword)
        {
            outputOnDisplay.GetComponent<Text>().text = "Нет доступа";
            outputOnDisplay.GetComponent<Text>().color = new Color(130, 0, 0);
        }
    }
}
