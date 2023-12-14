using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlMouseKeyBoard
{
    class AutoUpScalingImage
    {
        private int MAX_IMAGE_NUMBER;
        private const int image_y_interval = 21;
        private int image_y_pos = 141;
        private const int IMAGE_X_POS = 1400;
        private int selected_img_count = 0;
        private bool isEnd = false;

        public AutoUpScalingImage(int max_image_num)
        {
            MAX_IMAGE_NUMBER = max_image_num;
            start();
        }

        private void start()
        {
            while (true)
            {
                ///5초 대기
                System.Threading.Thread.Sleep(5000);

                /// 주소창에 FVC 무료 업스케일러 주소 복붙 후 이동
                moveFVCUpScalingPage();
                /// 1초 대기
                System.Threading.Thread.Sleep(1000);

                /// 이미지 선택 후 드래그
                select_image_and_drag_upScaleBtn();
                /// 60초 대기
                System.Threading.Thread.Sleep(60000);

                /// 저장 버튼 누르기
                click_save_btn();

                if (check_isEnd() == true) break;
            }
            
        }

        private void moveFVCUpScalingPage()
        {
            /// 주소창 커서이동
            Static_Method_Pack.SetCursorPos(371, 62);

            // 주소창 클릭
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);

            // 주소 복사
            Clipboard.SetText("https://www.free-videoconverter.net/ko/free-image-upscaler/");

            // Ctrl + A
            SendKeys.SendWait("^{a}");
            System.Threading.Thread.Sleep(500);

            // Ctrl + V
            SendKeys.SendWait("^{v}");
            System.Threading.Thread.Sleep(500);

            SendKeys.SendWait("{ENTER}");
        }

       private void select_image_and_drag_upScaleBtn()
        {
            /// 마우스 떼는 곳 (480, 490)
            /// 해당 이미지 선택
            Static_Method_Pack.SetCursorPos(IMAGE_X_POS, image_y_pos);
            image_y_pos += image_y_interval;
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.mouse_event(Static_Method_Pack.LEFT_BUTTON_DOWN, 0, 0, 0, 0);
            System.Threading.Thread.Sleep(1000);

            int x_interval = (IMAGE_X_POS - 480) / 10;
            int y_interval = (image_y_pos - 490) / 10;

            int nowMouseXPos = IMAGE_X_POS;
            int nowMouseYPos = image_y_pos;

            for(int i = 0; i < 10; i++)
            {
                nowMouseXPos -= x_interval;
                nowMouseYPos -= y_interval;
                Static_Method_Pack.SetCursorPos(nowMouseXPos, nowMouseYPos);
                System.Threading.Thread.Sleep(500);
            }


            /// 사진 업로드 버튼으로 이동
            //Static_Method_Pack.SetCursorPos(480, 490);
            System.Threading.Thread.Sleep(1000);
            /// 왼쪽 마우스 떼기
            Static_Method_Pack.mouse_event(Static_Method_Pack.LEFT_BUTTON_UP, 0, 0, 0, 0);

            selected_img_count++;
            if (selected_img_count == MAX_IMAGE_NUMBER) isEnd = true;
        }

        private void click_save_btn()
        {
            /// 저장 버튼으로 마우스 커서 이동
            Static_Method_Pack.SetCursorPos(890, 870);
            System.Threading.Thread.Sleep(500);

            /// 마우스 클릭
            Static_Method_Pack.clickMouse();
        }

        private Boolean check_isEnd()
        {
            if(isEnd == true) return true;
            else return false;
        }
    }
}
