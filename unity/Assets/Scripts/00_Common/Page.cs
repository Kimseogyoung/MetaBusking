using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Page : MonoBehaviour
{//��ӿ� Ŭ����
    public Button exitBtn;
    // Start is called before the first frame update
    void Awake()
    {
        exitBtn.onClick.AddListener(Close);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Open()
    {
        gameObject.SetActive(true);

    }
    public void Close()
    {
        //�ʱ�ȭ
        Reset();
        //�ݱ�
        gameObject.SetActive(false);
    }
    virtual public void Reset()
    {//�ش� ������ �ʱ�ȭ�ϱ�

    }
}
