using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Button button; // ������ �� ��������� ������
    private Color originalTextColor; // �������� ���� ������ ������
    private Color hoverTextColor = Color.black; // ���� ������ ��� ���������
    private float originalAlpha; // �������� ������������ ������
    private float hoverAlpha = 1f; // ������������ ��� ���������

    void Start()
    {
        // �������� ������ �� ��������� ������
        button = GetComponent<Button>();

        // ��������� �������� �������� ����� ������ � ������������ ������
        originalTextColor = button.GetComponentInChildren<TextMeshProUGUI>().color;
        originalAlpha = button.image.color.a;
    }

    // ���������� ��� ��������� ������� �� ������
    public void OnPointerEnter(PointerEventData eventData)
    {
        // ������������� ���� ������ � ������������ ������ ��� ���������
        button.GetComponentInChildren<TextMeshProUGUI>().color = hoverTextColor;
        Color newColor = button.image.color;
        newColor.a = hoverAlpha;
        button.image.color = newColor;
    }

    // ���������� ��� ������ ������� �� ������� ������
    public void OnPointerExit(PointerEventData eventData)
    {
        // ���������� �������� ���� ������ � ������������ ������
        button.GetComponentInChildren<TextMeshProUGUI>().color = originalTextColor;
        Color newColor = button.image.color;
        newColor.a = originalAlpha;
        button.image.color = newColor;
    }
}
