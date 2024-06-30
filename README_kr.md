# SimpleJoystick

SimpleJoystick는 모바일 게임을 위한 사용하기 쉬운 조이스틱 컨트롤을 제공하는 Unity 자산입니다. 최소한의 설정으로 게임에 부드럽고 반응성이 좋은 조이스틱 입력을 추가할 수 있습니다.

## 특징
- **간단한 설정:** 조이스틱 프리팹을 씬에 추가하면 바로 사용할 수 있습니다.
- **커스터마이즈 가능:** 게임 디자인에 맞게 조이스틱의 크기, 위치 및 외관을 쉽게 조정할 수 있습니다.
- **부드러운 입력:** 캐릭터 이동 및 기타 동작을 위한 부드럽고 정확한 입력을 제공합니다.
- **모바일 친화적:** 모바일 장치에 최적화되어 반응이 빠르고 지연이 없는 경험을 보장합니다.

## 데모 비디오
SimpleJoystick 사용 방법에 대한 간단한 개요 및 데모 비디오를 확인하세요. [데모 비디오](https://drive.google.com/file/d/1X2Vl6p994NlfRm478qMUPMAxOTu0KoaD/view?usp=sharing)

## 설치
1. **레포지토리 클론:**
    ```bash
    git clone https://github.com/hyunamy/SimpleJoystick.git
    ```
2. **Unity에서 프로젝트 열기:**
    - Unity Hub를 열고 "Add" 버튼을 클릭합니다.
    - 클론한 레포지토리 폴더로 이동하여 선택합니다.

3. **SimpleJoystick 패키지 가져오기:**
    - Unity 에디터에서 `Assets > Import Package > Custom Package...`로 이동합니다.
    - 클론한 레포지토리에서 SimpleJoystick.unitypackage 파일을 선택하고 모든 자산을 가져옵니다.

## 사용 방법
1. **씬에 조이스틱 추가:**
    - `Prefabs` 폴더에서 `SimpleJoystick` 프리팹을 드래그하여 씬에 추가합니다.

2. **조이스틱 구성:**
    - Inspector에서 조이스틱의 크기, 위치 및 기타 설정을 조정하여 게임 UI에 맞게 설정합니다.

3. **조이스틱 입력 사용:**
    - 스크립트에서 조이스틱 입력을 사용하여 게임 오브젝트를 제어합니다.
    ```csharp
    public class PlayerController : MonoBehaviour
    {
        public SimpleJoystick joystick;

        void Update()
        {
            Vector2 direction = joystick.GetInputDirection();
            // 방향을 사용하여 플레이어를 이동하거나 기타 동작을 수행합니다.
        }
    }
    ```

## 기여
SimpleJoystick을 개선하기 위한 기여를 환영합니다! 제안 사항이 있거나 문제를 발견하면 이슈를 열거나 풀 리퀘스트를 제출해 주세요.

## 라이선스
이 프로젝트는 MIT 라이선스에 따라 라이선스가 부여됩니다. 자세한 내용은 LICENSE 파일을 참조하세요.

## 연락처
질문이나 지원이 필요하면 [GitHub 레포지토리](https://github.com/hyunamy/SimpleJoystick)에 이슈를 열어 주세요.

---

SimpleJoystick을 사용해 주셔서 감사합니다! 게임 개발 과정이 더 쉽고 즐거워지기를 바랍니다.
