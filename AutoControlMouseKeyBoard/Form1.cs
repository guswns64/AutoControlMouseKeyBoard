using System;
using System.Timers;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Input;

namespace AutoControlMouseKeyBoard
{
    public partial class Form1 : Form
    {

        const uint LEFT_BUTTON_DOWN = 0x0002;
        const uint LEFT_BUTTON_UP = 0x0004;

        //[DllImport("user32.dll")]
        //static extern int SetCursorPos(int x, int y);
        //[DllImport("user32.dll")]
        //static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        //[DllImport("user32.dll")]
        //static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo);
        //[DllImport("user32.dll")]
        //static extern bool GetCursorPos(out Point lpPoint);
        //[DllImport("user32.dll")]
        //public static extern int SetForegroundWindow(IntPtr hWnd);
        static class NativeMethods
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AllocConsole();
        }

        public Form1()
        {
            InitializeComponent();
            NativeMethods.AllocConsole();

            init();
        }

        private void init()
        {
            printText("excute init");

            //AutoUpScalingImage upScalingImage = new AutoUpScalingImage();
            //AutoGetSeaArtImage autoGetPikaImage = new AutoGetSeaArtImage();
            //AutoGetBingImage autoGetBingImage = new AutoGetBingImage();

            SimpleTool simpleTool = new SimpleTool();
            //autoMouseGetPos();
            //autoImageCreateMode();
            //autoImageUpScaling();
        }

        private void autoImageUpScaling()
        {
            const int MAX_COUNT = 35;
            int xPos = 1400;
            int yPos = 141;
            int count = 0;

            Static_Method_Pack.keybd_event((byte)Keys.ControlKey, 0, 0, IntPtr.Zero);

            while (true)
            {
                Static_Method_Pack.SetCursorPos(xPos, yPos);

                //SendKeys.SendWait("^");
                //mouse_event(LEFT_BUTTON_DOWN, 0, 0, 0, 0);
                Static_Method_Pack.clickMouse();
                yPos += 21;
                count++;
                if (count == MAX_COUNT) break;
                System.Threading.Thread.Sleep(1000);
            }
            Static_Method_Pack.keybd_event((byte)Keys.ControlKey, 0, 0x0002, IntPtr.Zero);

        }

        private void autoMouseGetPos()
        {
            while (true)
            {
                getMouseXY();
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void autoImageCreateMode()
        {
            printText("5초 뒤 시작");
            System.Threading.Thread.Sleep(1000);
            printText("4초 뒤 시작");
            System.Threading.Thread.Sleep(1000);
            printText("3초 뒤 시작");
            System.Threading.Thread.Sleep(1000);
            printText("2초 뒤 시작");
            System.Threading.Thread.Sleep(1000);
            printText("1초 뒤 시작");
            System.Threading.Thread.Sleep(1000);

            while (true)
            {
                // 랜덤 텍스트 복붙
                copyText();
                System.Threading.Thread.Sleep(1000);
                // 새로고침하고
                Static_Method_Pack.SetCursorPos(71, 47);
                System.Threading.Thread.Sleep(1000);
                Static_Method_Pack.clickMouse();
                printText("새로고침");
                System.Threading.Thread.Sleep(2000);

                // 검색창 누르고
                Static_Method_Pack.SetCursorPos(1344, 184);
                System.Threading.Thread.Sleep(1000);
                Static_Method_Pack.clickMouse();
                printText("검색창 클릭");
                System.Threading.Thread.Sleep(1000);

                // Ctrl + A
                SendKeys.SendWait("^{a}");
                printText("전체 선택");
                System.Threading.Thread.Sleep(1000);

                // Ctrl + V
                SendKeys.SendWait("^{v}");
                printText("붙여넣기");
                System.Threading.Thread.Sleep(1000);

                // 만들기 버튼 클릭
                Static_Method_Pack.SetCursorPos(1635, 182);
                Static_Method_Pack.clickMouse();
                printText("만들기 버튼 클릭");

                // 1분 대기
                System.Threading.Thread.Sleep(60000);
            }
        }


        private void getMouseXY()
        {
            Point cursorPos;
            if (Static_Method_Pack.GetCursorPos(out cursorPos))
            {
                Console.WriteLine($"현재 마우스 좌표: X = {cursorPos.X}, Y = {cursorPos.Y}");
            }
        }

        private void addMouseEvent()
        {
            this.MouseDown += new MouseEventHandler(this.mouseDownEvent);
        }

        private void mouseDownEvent(object sender, MouseEventArgs e)
        {
            Point mousePoint = e.Location;
            //mousePoint = Screen.FromPoint(mousePoint);
            printText("x : " + mousePoint.X);
            printText("y : " + mousePoint.Y);


        }


        private void moveMouse()
        {
            printText("excute moveMouse");
            Cursor.Position = new Point(40, 31); // 내 PC 좌표
            //mouse_event(LEFT_BUTTON_DOWN, 0, 0, 0, 0);
            //mouse_event(LEFT_BUTTON_UP, 0, 0, 0, 0);

        }

        private void copyText()
        {
            Random random = new Random();
            String[] moodStrArr = {
                                    "신비로운"
                                    , "고요한"
                                    , "화려한"
                                    , "평화로운"
                                    , "로맨틱한"
                                    , "환상적인"
                                    , "청량한"
                                    , "차가운"
                                    , "활기찬"
                                    , "신선한"
                                    , "미스테리어스한"
                                    , "우아한"
                                    , "따사로운"
                                    , "화사한"
                                    , "감성적인"
                                    , "낙천적인"
                                    , "차분한"
                                    , "화려한"
                                    , "감각적인"
                                    };
            String[] placeStrArr = {
                                    "비행기 안에서"
                                    , "방 안에서"
                                    , "모텔 안에서"
                                    , "숲 속에서"
                                    , "유적지에서"
                                    , "해변에서"
                                    , "도서관에서"
                                    , "도시 골목에서"
                                    , "꽃밭에서"
                                    , "빈티지 카페에서"
                                    , "호수 둘레에서"
                                    , "산꼭대기에서"
                                    , "밤하늘 아래에서"
                                    , "도심 속 고층빌딩에서"
                                    , "정원에서"
                                    , "밭둑에서"
                                    , "어두운 골목에서"
                                    , "고려 시대 마을에서"
                                    , "우주 정거장에서"
                                    , "성당 내부에서"
                                    };

            String[] firstStr =
            {
                "정화된 숲속 눈부신 새벽에서",
                "공기가 맑은 산에서의 은빛 일출에서",
                "비밀스러운 정원의 아치형 문 앞에서",
                "유럽의 작은 마을 광장에서",
                "푸른 언덕 위의 소박한 오두막에서",
                "전원에서 들려오는 먼 동물 소리와 함께",
                "햇살이 가득한 계곡의 소나무 숲에서",
                "작은 강변 마을의 평온한 강가에서",
                "푸른 언덕에 자리한 아름다운 교회 안에서",
                "고요한 성곽의 정원에서",
                "세련된 빈티지 카페의 고요한 테라스에서",
                "도심 속 작은 공원의 트레일에서",
                "어두운 밤, 오래된 도서관의 조용한 독서실에서",
                "도시의 한적한 빈티지 샵에서",
                "수련과 힐링이 어우러진 동양의 전통 실내에서",
                "사색의 시간을 보낼 수 있는 현대 미술관에서",
                "소박한 시골 카페의 옥상 테라스에서",
                "절경 속에서 머물며 그림을 그릴 수 있는 언덕에서",
                "세계 각지에서 모인 서로 다른 언어 소리가 울리는 국제 공항에서",
                "한적한 산골 마을의 노인들과 함께하는 정원에서",
                "농촌의 작은 저택에서, 어머니가 만든 따스한 빵 냄새가 풍기는 주방에서",
                "동양적인 무드가 물씬 풍기는 명상 전용 공간에서",
                "작은 섬의 갯벌에서 들려오는 파도 소리와 함께",
                "어두운 산길에서 눈부시게 빛나는 별들을 바라보며",
                "오래된 성당에서 감상적인 오르간 연주를 들으며",
                "현대 예술 갤러리의 조용한 전시실에서",
                "고요한 동굴 안에서",
                "노을이 아름다운 시골 마을의 벼랑 끝에서",
                "역사적인 성골 마을의 돌다리 위에서",
                "맑은 봄날, 산속 연못에서 연꽃을 감상하며",
                "동양적인 정원에서 향기로운 차를 마시며",
                "세계 유명 미술관의 쾌적한 갤러리에서",
                "여유로운 아침, 언덕 위의 양떼를 바라보며",
                "물이 흐르는 작은 계곡의 돌다리 위에서",
                "천년의 역사가 느껴지는 중세 마을의 골목에서",
                "어두운 밤, 초승달이 밝게 비치는 산에서",
                "작은 나무집에서 불빛이 나는 창가에서",
                "색다른 도시 골목의 아티스틱한 벽화 앞에서",
                "혼자서 바라보는 무한한 우주의 별들과 함께",
                "어두운 골목에서 소풍 간 듯한 작은 정원에서",
                "어두운 산길에서 별이 빛나는 하늘을 바라보며",
                "물이 맑은 작은 연못의 벤치에서",
                "정화된 힐링 센터의 실내 정원에서",
                "작은 마을의 도서관에서 조용한 독서를 즐기며",
                "청정한 바닷가의 모래 위에서",
                "비밀스러운 정원의 작은 연못에서",
                "마음이 편안해지는 작은 전원 카페에서",
                "꽃 향기가 풍기는 증조할머니의 정원에서",
                "푸른 산속에서 흘러나오는 작은 폭포에서",
                "싱그러운 풀내음이 퍼지는 작은 언덕에서",
                "혼자만의 소박한 정원에서",
                "미세먼지 없이 맑은 공기가 흐르는 계곡 옆에서",
                "옛 도서관의 햇살 가득한 노숙방에서",
                "먼 동물 소리가 들리는 어두운 산책로에서",
                "뜨거운 태양 아래, 시원한 강물에 발 담그는 강가에서",
                "연인과 함께하는 차분한 빈티지 차밭에서",
                "비행기 안에서",
                "방 안에서",
                "모텔 안에서",
                "숲 속에서",
                "유적지에서",
                "해변에서",
                "도서관에서",
                "도시 골목에서",
                "꽃밭에서",
                "빈티지 카페에서",
                "호수 둘레에서",
                "산꼭대기에서",
                "밤하늘 아래에서",
                "도심 속 고층빌딩에서",
                "정원에서",
                "밭둑에서",
                "어두운 골목에서",
                "고려 시대 마을에서",
                "우주 정거장에서",
                "성당 내부에서",
                "호숫가 풍경이 아름다운 오두막에서",
                "정겨운 시골 집 마당에서",
                "공원의 햇살 가득한 벤치에서",
                "민속 마을의 전통 한옥에서",
                "시끄럽지 않은 동네 카페에서",
                "섬세한 조명이 빛나는 작은 갤러리에서",
                "산속 작은 펜션에서",
                "레트로 분위기의 서점 안에서",
                "몽환적인 뮤지엄 내부에서",
                "도심 속 조용한 수목원에서",
                "조용한 호텔의 테라스에서",
                "밤하늘이 무척이나 맑은 사랑스러운 마을에서",
                "새소리가 들리는 골동품 상점 안에서",
                "해가 떨어진 해발 높은 언덕에서",
                "증조할머니가 손수 짠 담요로 덮인 다락방에서",
                "소란스럽지 않은 고요한 차밭에서",
                "어두운 골목의 고요한 사적인 공간에서",
                "명상과 휴식이 어우러진 동양의 전통 정원에서",
                "아침 햇살이 따스한 바다 마을에서",
                "정갈하고 편안한 숙소의 객실에서",
                "항구도시의 조용한 부두에서",
                "수려한 계곡의 샘물 옆에서",
                "햇살 가득한 옥상 정원에서",
                "오래된 도서관의 한 구석에서",
                "연인과 함께하는 루프탑 바에서",
                "청정한 바다가 펼쳐진 작은 섬에서",
                "자연 속에 위치한 고요한 사우나에서",
                "동네 카페의 작은 정원에서",
                "고요한 저수지 둘레에서",
                "어두운 밤하늘 아래 불빛 없는 산에서"
            };
            String finalStr = "잠을 자고 있는 동양 여성";
            int moodRandomIndex = random.Next(moodStrArr.Length);
            int placeRandomIndex = random.Next(placeStrArr.Length);
            string copyText = moodStrArr[moodRandomIndex] + " " + placeStrArr[placeRandomIndex] + " " + finalStr;

            int firstStrRandomIndex = random.Next(firstStr.Length);
            copyText = firstStr[firstStrRandomIndex] + " " + finalStr;
            printText("카페 문구 생성 ===> " + copyText);
            Clipboard.SetText(copyText);
        }

        private void pasteText()
        {
            printText("excute pasteText");

        }

        private void startTimer(int timerMinute)
        {
            printText("excute startTimer");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60 * 60 * 1000; // 1 시간

            timer.Start();

        }


        private void printText(String str)
        {
            Console.WriteLine(str);
        }
    }
}
