using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Button button; // Ссылка на компонент кнопки
    private Color originalTextColor; // Исходный цвет текста кнопки
    private Color hoverTextColor = Color.black; // Цвет текста при наведении
    private float originalAlpha; // Исходная прозрачность кнопки
    private float hoverAlpha = 1f; // Прозрачность при наведении

    void Start()
    {
        // Получаем ссылку на компонент кнопки
        button = GetComponent<Button>();

        // Сохраняем исходные значения цвета текста и прозрачности кнопки
        originalTextColor = button.GetComponentInChildren<TextMeshProUGUI>().color;
        originalAlpha = button.image.color.a;
    }

    // Вызывается при наведении курсора на кнопку
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Устанавливаем цвет текста и прозрачность кнопки при наведении
        button.GetComponentInChildren<TextMeshProUGUI>().color = hoverTextColor;
        Color newColor = button.image.color;
        newColor.a = hoverAlpha;
        button.image.color = newColor;
    }

    // Вызывается при выходе курсора за пределы кнопки
    public void OnPointerExit(PointerEventData eventData)
    {
        // Возвращаем исходный цвет текста и прозрачность кнопки
        button.GetComponentInChildren<TextMeshProUGUI>().color = originalTextColor;
        Color newColor = button.image.color;
        newColor.a = originalAlpha;
        button.image.color = newColor;
    }
}
