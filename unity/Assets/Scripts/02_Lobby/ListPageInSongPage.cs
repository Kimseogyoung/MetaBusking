using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ListPageInSongPage : Page
{

    public TextMeshProUGUI contentText;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Open(int id, string content)
    {//�����ε�
        gameObject.SetActive(true);
        contentText.text = content;
        Load(id);
    }
    void Load(int id)
    {//id�� ���� �˸��� �������� �ҷ����� �Լ�

    }

    override public void Reset()
    {   
        //������ �ʱ�ȭ

        //�ʱ�ȭ
        contentText.text = "";
    }
}
