using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;//�� ���� ���̺귯���� ����Ѵ�


public class SocketIoClient : MonoBehaviour
{
    private WebSocket ws;

    void Start()
    {
        ws = new WebSocket("ws://localhost:8080/routes/api");// 127.0.0.1�� ������ ������ �ּ��̴�. 3333��Ʈ�� �����Ѵٴ� �ǹ��̴�.
        ws.OnMessage += ws_OnMessage; //�������� ����Ƽ ������ �޼����� �� ��� ������ �Լ��� ����Ѵ�.
        ws.OnOpen += ws_OnOpen;//������ ����� ��� ������ �Լ��� ����Ѵ�
        ws.OnClose += ws_OnClose;//������ ���� ��� ������ �Լ��� ����Ѵ�.
        ws.Connect();//������ �����Ѵ�.
        //ws.Send("hello");//�������� "hello"��� �޼����� ������.
    }
    void ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log(e.Data);//���� �޼����� ����� �ֿܼ� ����Ѵ�.
    }
    void ws_OnOpen(object sender, System.EventArgs e)
    {
        Debug.Log("open"); //����� �ֿܼ� "open"�̶�� ��´�.
    }
    void ws_OnClose(object sender, CloseEventArgs e)
    {
        Debug.Log("close"); //����� �ֿܼ� "close"�̶�� ��´�.
    }


    /*
        void Start()
    {
        
        m_WebSocket = new WebSocket("ws://localhost:8080");
        m_WebSocket.Connect();

        m_WebSocket.OnMessage += (sender, e) =>
        {
            Debug.Log($"{((WebSocket)sender).Url}���� + ������ : {e.Data}�� ��.");
        };
    }

    void Update()
    {
        if (m_WebSocket == null)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_WebSocket.Send("�ȳ�");
        }
    }
*/
}