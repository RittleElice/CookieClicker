using UnityEngine;
using TMPro;

public class ClickUpgrade : MonoBehaviour
{
    // GameManager 연결 (쿠키 소비, 클릭 파워 증가에 사용)
    public GameManager gameManager;

    // 업그레이드 비용/이름 등을 담은 데이터 파일 (Inspector에서 연결)
    public UpgradeData upgradeData;

    // 업그레이드 비용을 표시할 텍스트
    public TextMeshProUGUI costText;

    // 현재 업그레이드 비용 (누를 때마다 증가함, 시작값은 데이터에서 가져옴)
    private long currentCost;

    void Start()
    {
        currentCost = upgradeData.baseCost;
        UpdateCostText();
    }

    // 업그레이드 버튼을 눌렀을 때 호출될 함수
    public void OnUpgradeButtonClicked()
    {
        if (gameManager.SpendCookies(currentCost))
        {
            gameManager.AddCookiesPerClick(upgradeData.clickPowerIncrease);

            // 다음 구매 비용을 올림
            currentCost = (long)(currentCost * upgradeData.costMultiplier);

            UpdateCostText();
        }
    }

    // 비용 텍스트 갱신
    void UpdateCostText()
    {
        costText.text = upgradeData.upgradeName + "\n" + currentCost + " 쿠키";
    }
}