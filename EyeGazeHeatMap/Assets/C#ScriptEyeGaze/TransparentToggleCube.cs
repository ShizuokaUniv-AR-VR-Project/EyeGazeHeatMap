using UnityEngine;

public class TransparentToggleCube : MonoBehaviour
{
    public GameObject cube; // �����ɂ���Cube���w��
    public KeyCode toggleKey = KeyCode.T; // �����ɐ؂�ւ���L�[

    private bool isTransparent = false; // ���݂̓�����Ԃ�ǐ�

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            ToggleTransparency();
        }
    }

    void ToggleTransparency()
    {
        Renderer cubeRenderer = cube.GetComponent<Renderer>();
        if (cubeRenderer != null)
        {
            Color color = cubeRenderer.material.color;
            isTransparent = !isTransparent; // ������Ԃ�؂�ւ�
            color.a = isTransparent ? 0 : 1; // �A���t�@��0�܂���1�ɐݒ�
            cubeRenderer.material.color = color;
        }
    }
}
