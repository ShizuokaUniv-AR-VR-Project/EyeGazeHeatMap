using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    void Update()
    {
        // �L�[�{�[�h���͂�Cube�̕\������
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ToggleVisibility(cube1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ToggleVisibility(cube2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ToggleVisibility(cube3);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            // ���ׂĂ�Cube��\���E��\���ؑ�
            ToggleVisibility(cube1, cube2, cube3);
        }
    }

    void ToggleVisibility(params GameObject[] objects)
    {
        foreach (var obj in objects)
        {
            bool isActive = obj.activeSelf;
            obj.SetActive(!isActive);
        }
    }
}
