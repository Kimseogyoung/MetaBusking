using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inputObject : MonoBehaviour
{
    public string key;
    public string name_content;
    public string btn_content;
    public string under_content;


    public TextMeshProUGUI nameText;
    public Button btn;
    public TMP_InputField inputField;

    public TextMeshProUGUI underText;
    // Start is called before the first frame update
    void Start()
    {
        if (inputField != null)
        {
            if (btn_content == "")
            {
                btn.gameObject.SetActive(false);
            }
            else
            {
                (btn.GetComponentInChildren<TextMeshProUGUI>()).text = btn_content;
            }
        }
        if (underText != null)
        {
            underText.text = under_content;
        }
        nameText.text = name_content;

    }
    public void init()
    {
        inputField.text = "";
        check();
    }
    void check()
    {
        //������ Ȯ���ϰ� �˸��� �޽����� �����ֵ��� �ϴ� �Լ�
        //������ �ӽ÷� �⺻ �޽����� �������� ��
        if (underText != null)
        {
            underText.text = under_content;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
