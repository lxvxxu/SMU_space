using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BuildingSelectScript : MonoBehaviour
{

    public int s_fin_5day = 0;
    //public Text out_text;


    public Button A_bt;
    public Button G_bt;
    public Button M_bt;
    public Button N_bt;
    public Button T_bt;
    public Button R_bt;



    public enum Build_Save
    {
        A = 1, //������а�
        G, //��1���а�
        M, //��ȭ�������а�(���ذ�)
        N, //�ι���ȸ���д��а�(���ϰ�)
        T, //�濵�������а�(�з��Ͼ���)
        R //�̷�����
        
    }

    Build_Save MySave = 0;




            // Start is called before the first frame update
    void Start()
    {
        s_fin_5day = GameObject.Find("script").GetComponent<CurrentTime>().day_5_int;
        Debug.Log(s_fin_5day);





    }




    public void sel_A()
    {
        MySave = Build_Save.A;

        //out_text.text = "A";

            //(r, g, b, a) 
            ColorBlock A_cb = A_bt.colors;
            A_cb.selectedColor = new Color(111/255f, 111/255f, 111/255f, 1f);
            A_bt.colors = A_cb;





    }

    public void sel_G()
    {
        MySave = Build_Save.G;
        //out_text.text = "G";

        ColorBlock G_cb = G_bt.colors;
        G_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        G_bt.colors = G_cb;
    }

    public void sel_M()
    {
        MySave = Build_Save.M;
        //out_text.text = "M";


        ColorBlock M_cb = M_bt.colors;
        M_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        M_bt.colors = M_cb;

    }

    public void sel_N() //���ϰ�
    {
        Debug.Log("MySave = N���� �����Ǿ����ϴ�.");
        MySave = Build_Save.N;
        //out_text.text = "N";


        ColorBlock N_cb = N_bt.colors;
        N_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        N_bt.colors = N_cb;
    }

    public void sel_T()
    {
        MySave = Build_Save.T;
        //out_text.text = "T";


        ColorBlock T_cb = T_bt.colors;
        T_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        T_bt.colors = T_cb;
    }

    public void sel_R()
    {
        MySave = Build_Save.R;
        //out_text.text = "R";

        ColorBlock R_cb = R_bt.colors;
        R_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        R_bt.colors = R_cb;
    }



    public void FIN_Scene()
    {
        if (MySave == Build_Save.N)
            Scene_N();
        else if (MySave == Build_Save.A)
            Scene_A();
        else if (MySave == Build_Save.G)
            Scene_G();
        else if (MySave == Build_Save.M)
            Scene_M();
        else if (MySave == Build_Save.R)
            Scene_R();
        else if (MySave == Build_Save.T)
            Scene_T();
    }    


    public void Scene_N()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day�� ���̰� ���� Scene_N �Լ� �ߵ���.");
        switch(s_fin_5day)
        {
            case (0):
                Debug.Log("N_MON ���� ����ٰ�.");
                SceneManager.LoadScene("N_MON");
                break;
            case (1):
                Debug.Log("N_TUE ���� ����ٰ�.");
                SceneManager.LoadScene("N_TUE");
                break;
            case (2):
                Debug.Log("N_WED ���� ����ٰ�.");
                SceneManager.LoadScene("N_WED");
                break;
            case (3):
                Debug.Log("N_THUR ���� ����ٰ�.");
                SceneManager.LoadScene("N_THUR");
                break;
            case (4):
                Debug.Log("N_FRI ���� ����ٰ�.");
                SceneManager.LoadScene("N_FRI");
                break;
        }
    }

    public void Scene_A()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day�� ���̰� ���� Scene_A �Լ� �ߵ���.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("A_MON ���� ����ٰ�.");
                SceneManager.LoadScene("A_MON");
                break;
            case (1):
                Debug.Log("A_TUE ���� ����ٰ�.");
                SceneManager.LoadScene("A_TUE");
                break;
            case (2):
                Debug.Log("A_WED ���� ����ٰ�.");
                SceneManager.LoadScene("A_WED");
                break;
            case (3):
                Debug.Log("A_THUR ���� ����ٰ�.");
                SceneManager.LoadScene("A_THUR");
                break;
            case (4):
                Debug.Log("A_FRI ���� ����ٰ�.");
                SceneManager.LoadScene("A_FRI");
                break;
        }
    }

    public void Scene_G()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day�� ���̰� ���� Scene_G �Լ� �ߵ���.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("G_MON ���� ����ٰ�.");
                SceneManager.LoadScene("G_MON");
                break;
            case (1):
                Debug.Log("G_TUE ���� ����ٰ�.");
                SceneManager.LoadScene("G_TUE");
                break;
            case (2):
                Debug.Log("G_WED ���� ����ٰ�.");
                SceneManager.LoadScene("G_WED");
                break;
            case (3):
                Debug.Log("G_THUR ���� ����ٰ�.");
                SceneManager.LoadScene("G_THUR");
                break;
            case (4):
                Debug.Log("G_FRI ���� ����ٰ�.");
                SceneManager.LoadScene("G_FRI");
                break;
        }
    }

    public void Scene_M()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day�� ���̰� ���� Scene_M �Լ� �ߵ���.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("M_MON ���� ����ٰ�.");
                SceneManager.LoadScene("M_MON");
                break;
            case (1):
                Debug.Log("M_TUE ���� ����ٰ�.");
                SceneManager.LoadScene("M_TUE");
                break;
            case (2):
                Debug.Log("M_WED ���� ����ٰ�.");
                SceneManager.LoadScene("M_WED");
                break;
            case (3):
                Debug.Log("M_THUR ���� ����ٰ�.");
                SceneManager.LoadScene("M_THUR");
                break;
            case (4):
                Debug.Log("M_FRI ���� ����ٰ�.");
                SceneManager.LoadScene("M_FRI");
                break;
        }
    }

    public void Scene_R()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day�� ���̰� ���� Scene_R �Լ� �ߵ���.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("R_MON ���� ����ٰ�.");
                SceneManager.LoadScene("R_MON");
                break;
            case (1):
                Debug.Log("R_TUE ���� ����ٰ�.");
                SceneManager.LoadScene("R_TUE");
                break;
            case (2):
                Debug.Log("R_WED ���� ����ٰ�.");
                SceneManager.LoadScene("R_WED");
                break;
            case (3):
                Debug.Log("R_THUR ���� ����ٰ�.");
                SceneManager.LoadScene("R_THUR");
                break;
            case (4):
                Debug.Log("R_FRI ���� ����ٰ�.");
                SceneManager.LoadScene("R_FRI");
                break;
        }
    }

    public void Scene_T()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day�� ���̰� ���� Scene_T �Լ� �ߵ���.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("T_MON ���� ����ٰ�.");
                SceneManager.LoadScene("T_MON");
                break;
            case (1):
                Debug.Log("T_TUE ���� ����ٰ�.");
                SceneManager.LoadScene("T_TUE");
                break;
            case (2):
                Debug.Log("T_WED ���� ����ٰ�.");
                SceneManager.LoadScene("T_WED");
                break;
            case (3):
                Debug.Log("T_THUR ���� ����ٰ�.");
                SceneManager.LoadScene("T_THUR");
                break;
            case (4):
                Debug.Log("T_FRI ���� ����ٰ�.");
                SceneManager.LoadScene("T_FRI");
                break;
        }
    }

}
