using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snedmail_script : MonoBehaviour
{
    public void sendmail()
    {
        string mailto = "202210133@sangmyung.kr"; //�޴� ���� �ּ�
        string subject = EscapeURL("[���͵����÷���] ���� ����Ʈ / ��Ÿ ���ǻ���"); //���� ������ ����
        string body = EscapeURL // ���� ������ ����
            (
            "���͵����÷��� <������ ����> ����&�� ������ ��ä������ ������ �����մϴ�!\n\n\n"+
             "�� ���� ������ �ۼ����ּ���.\n\n" +
             "________________\n\n" +
             "Device Model : " + SystemInfo.deviceModel + "\n\n" +
             "Device OS : " + SystemInfo.operatingSystem + "\n\n" +
             "���� ���� : "+
             "________________\n\n"
            );

        Application.OpenURL("mailto:" + mailto + "?subject=" + subject + "&body=" + body);
    }

    private string EscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }


}
