using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    public Button settingBtn;
    public Button openSongPageBtn;
    public Button loadSquareSceneBtn;
    public Button characterSetBtn;

    public CharacterSetPage characterSetPage;
    public SongPage songPage;
    public LobbySetting lobbySetting;
    void Start()
    {
        //��ư �̺�Ʈ ���
        settingBtn.onClick.AddListener(delegate { lobbySetting.Init(); });
        loadSquareSceneBtn.onClick.AddListener(LoadSquareScene);
        openSongPageBtn.onClick.AddListener(delegate { songPage.Open(); });
        characterSetBtn.onClick.AddListener(delegate { characterSetPage.Open(); });

        //user ���̴� �������� �޾ƿͼ� UserData.Instance�� ����
        //���� ����(�Լ� ȣ��)
        //
    }

    void LoadSquareScene()
    {//����� �ε�

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
