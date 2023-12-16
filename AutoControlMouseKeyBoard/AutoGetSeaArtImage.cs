using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlMouseKeyBoard
{
    class AutoGetSeaArtImage
    {
        private int imgTextOrder = 3;
        private bool isEnd = false;

        public AutoGetSeaArtImage()
        {
            start();
        }

        private void start()
        {

            Random rand = new Random();
            int waitTime;

            Console.WriteLine("seaArt 이미지 자동 생성");
            System.Threading.Thread.Sleep(1000);
            ///5초 대기
            Console.WriteLine("5초 후 시작합니다");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("4초 후 시작합니다");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3초 후 시작합니다");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2초 후 시작합니다");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1초 후 시작합니다");
            System.Threading.Thread.Sleep(1000);

            while (true)
            {
                /// 이미지 생성 명령 스크립트 복사
                copyText();
                System.Threading.Thread.Sleep(1000);

                /// 네이버 파파고에 스크립트 붙여넣기 후 영어로 번역된 스크립트 복사
                translateImageScript();
                System.Threading.Thread.Sleep(1000);

                /// 1. seaArt 채팅창 클릭,
                /// 2. "/"키 입력
                /// 3. Imagine 클릭
                /// 4. 영문 스크립트 붙여넣기
                /// 5. "Enter"키 입력
                createImgToSeaArt();


                if (check_isEnd() == true)
                {
                    Console.WriteLine("끝!!!!!!!!!!");
                    break;
                }

                waitTime = 40000 + rand.Next(30000) + 10000;
                Console.WriteLine((waitTime / 1000) + "초 대기");
                Console.WriteLine("현 시각 : " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                System.Threading.Thread.Sleep(waitTime);
            }
        }


       private void translateImageScript()
        {
            /// 파파고 입력 창 클릭
            Static_Method_Pack.SetCursorPos(423, 292);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);

            // Ctrl + A
            SendKeys.SendWait("^{a}");
            System.Threading.Thread.Sleep(500);
            /// 복사한 한글 스크립트 붙여넣기
            // Ctrl + V
            SendKeys.SendWait("^{v}");
            System.Threading.Thread.Sleep(3000);

            /// 번역된 영문 스크립트 복사 버튼 클릭
            Static_Method_Pack.SetCursorPos(176, 840);
            System.Threading.Thread.Sleep(1000);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);
        }

        private void createImgToSeaArt()
        {
            /// 1. seaArt 채팅창 클릭,
            Static_Method_Pack.SetCursorPos(1510, 994);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);

            /// 2. "/"키 입력
            SendKeys.SendWait("{DIVIDE}");
            System.Threading.Thread.Sleep(500);

            /// 3. Imagine 클릭
            Static_Method_Pack.SetCursorPos(1396, 605);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);

            /// 4. 영문 스크립트 붙여넣기
            SendKeys.SendWait("^{v}");
            System.Threading.Thread.Sleep(500);

            /// 5. "Enter"키 입력
            SendKeys.SendWait("{ENTER}");
            System.Threading.Thread.Sleep(500);
        }

        private Boolean check_isEnd()
        {
            if(isEnd == true) return true;
            else return false;
        }

        private void copyText()
        {
            String[] imgTextArr = {
                                    "부드러운 불빛이 비추는 침실에서 편안한 포즈로 누워 자는 여성",
                                    "창문으로 새어든 뮤지크와 함께 깊은 수면에 빠진 여성",
                                    "푹신한 이불 속에서 편안한 표정으로 꿈 속의 세계로 떠나는 여성",
                                    "녹색 잔디밭에 누워 햇볕을 맞으며 평화로운 잠에 빠진 여성",
                                    "바다 소리와 함께 모래 위에 누워 해가 지는 풍경을 보다 잠에 든 여성",
                                    "고요한 호수 둘레에서 자연 속에서 편안한 잠을 취하는 여성",
                                    "별이 가득한 밤하늘 아래에서 솔잎으로 만든 침낭에서 푹신한 잠을 취하는 여성",
                                    "서늘한 산림 우거진 계곡에서 바위 위에 누워 휴식을 취하는 여성",
                                    "온화한 샛별 빛 아래에서 푸른 초원에서 나른한 잠에 빠진 여성",
                                    "유리창 밖으로 비오는 날씨를 감상하며 햇볕 가득한 방에서 잠든 여성",
                                    "신선한 공기가 가득한 강가에서 누워 자연 속에서 평화로운 잠을 취하는 여성",
                                    "달빛이 비치는 산 위에서 편안한 눈을 감고 잠에 빠진 여성",
                                    "동화 속 정원에서 꽃 향기에 휩싸여 푹신한 잠을 취하는 여성",
                                    "백사장에 누워 파도 소리를 들으며 해가 지는 풍경을 바라보다 잠에 든 여성",
                                    "오렌지빛 석양 아래에서 푸른 풍경을 바라보다 잠에 든 여성",
                                    "양떼가 풀밭을 거닐며 햇살 가득한 언덕에서 잠든 여성",
                                    "시원한 계곡물 소리가 흐르는 산 속에서 편안한 잠을 취하는 여성",
                                    "북극 빙하 위에서 별빛 아래에서 잠든 여성",
                                    "마법의 숲에서 반짝이는 나비와 함께 누워 자는 여성",
                                    "도심 속 작은 공원에서 나뭇잎으로 깔린 대야에서 편안한 잠에 빠진 여성",
                                    "한적한 시골 집에서 베란다에 누워 새소리와 함께 잠든 여성",
                                    "유성우가 쏟아지는 하늘 아래에서 평화로운 잠을 취하는 여성",
                                    "소프트한 책 소리와 함께 독서실에서 책상 위에 누워 졸고 있는 여성",
                                    "옛 돌다리 위에서 누워 강물 소리에 휩싸이며 잠든 여성",
                                    "햇볕 가득한 푸른 하늘 아래에서 꽃밭에 누워 자는 여성",
                                    "꽃잎이 바람에 흩날리는 정원에서 미소 지은 채로 누운 여성",
                                    "실로 감싸인 창가에서 감미로운 음악 소리에 귀기울이며 자는 여성",
                                    "촛불이 흔들리는 방에서 아늑한 빛 속에서 잠에 빠진 여성",
                                    "수목원에서 나무 그늘에 누워 자연 속에서 편안한 잠을 취하는 여성",
                                    "소규모 텃밭에서 야채와 꽃 사이에 누워 휴식을 취하는 여성",
                                    "유럽 마을 광장에서 돌 바닥에 누워 잠든 여성",
                                    "노을이 칠한 해안가에서 파도 소리와 함께 잠든 여성",
                                    "신비로운 동굴 속에서 크리스털 빛에 비춰지며 푹신한 잠을 취하는 여성",
                                    "어린 숲에서 나무 그늘에 누워 자연 속에서 평화로운 잠에 빠진 여성",
                                    "영롱한 북극광이 춤추는 하늘 아래에서 누워 자는 여성",
                                    "옛 성벽 위에서 별빛에 비친 얼굴로 편안한 잠을 취하는 여성",
                                    "작은 연못에 반영된 달빛 아래에서 누워 자는 여성",
                                    "벚꽃이 피어난 벚꽃길에 누워 꽃보다 더 아름다운 여성",
                                    "고요한 산골에서 초록 풀밭에 누워 햇볕을 맞으며 잠든 여성",
                                    "어둡고 신비로운 숲에서 손에 피 꽃을 들고 누워 자는 여성",
                                    "도심의 작은 공원에서 빈티지 담배 향과 함께 졸고 있는 여성",
                                    "돌담이 둘러싼 작은 정원에서 햇볕에 쬐며 잠에 빠진 여성",
                                    "고요한 언덕에서 풀밭에 누워 바람에 스치는 소리에 귀 기울이는 여성",
                                    "물결치는 보트 위에서 바닷가에서 잠든 여성",
                                    "연인과 함께 피크닉 중인 동안 푸릇한 풀밭에 누워 자는 여성",
                                    "정원에서 흩날리는 나비와 함께 잠에 든 여성",
                                    "수련이 피어난 연못 위에서 누워 차분한 잠에 빠진 여성",
                                    "돌담이 둘러싼 작은 정원에서 햇볕에 쬐며 잠든 여성",
                                    "동양적인 정원에서 소리없이 떨어지는 봄비 소리에 잠든 여성",
                                    "일몰이 진 해변에서 모래 위에 누워 푹신한 잠에 빠진 여성",
                                    };
            string copyText = imgTextArr[imgTextOrder];
            Console.WriteLine("copyText ===> " + copyText);
            Clipboard.SetText(copyText);
            Console.WriteLine("이미지 생성 진척도 ===> " + "[ " + (imgTextOrder + 1) + " / " + (imgTextArr.Length) + " ]");

            imgTextOrder++;
            if (imgTextOrder == (imgTextArr.Length - 1)) isEnd = true;
        }
    }
}
