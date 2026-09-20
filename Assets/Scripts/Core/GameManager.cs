using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // 현재 보유 쿠키 개수
    public long cookieCount = 0;

    // 클릭 한 번당 얻는 쿠키 양 (나중에 업그레이드로 증가시킬 값)
    public long cookiesPerClick = 1;

    // 인스펙터 창에서 연결할 텍스트 오브젝트
    public TextMeshProUGUI cookieCountText;

    void Start()
    {
        UpdateCookieText();
    }

    // 쿠키를 클릭했을 때 호출될 함수 (버튼에 연결할 예정)
    public void OnCookieClicked()
    {
        cookieCount += cookiesPerClick;
        UpdateCookieText();
    }

    // 화면 텍스트 갱신
    void UpdateCookieText()
    {
        cookieCountText.text = cookieCount.ToString();
    }

    // ===== 여기부터 새로 추가 =====

    // 쿠키를 소비하려고 시도. 충분하면 차감하고 true 반환, 부족하면 false 반환
    public bool SpendCookies(long amount)
    {
        if (cookieCount >= amount)
        {
            cookieCount -= amount;
            UpdateCookieText();
            return true;
        }
        return false;
    }

    // 클릭당 획득량을 늘려주는 함수 (업그레이드 시스템에서 호출)
    public void AddCookiesPerClick(long amount)
    {
        cookiesPerClick += amount;
    }
}