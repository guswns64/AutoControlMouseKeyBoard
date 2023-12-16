using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlMouseKeyBoard
{
    class AutoUpScalingImage
    {
        //private int MAX_IMAGE_NUMBER;
        //private const int image_y_interval = 21;
        const string TARGET_PATH = @"C:\Users\KHJ\Downloads\AI_Image\";
        private int image_y_pos = 141;
        //private const int IMAGE_X_POS = 1400;
        string[] files = null;
        private int selected_file_index = 0;
        private string now_file_name;
        private string now_file_name_without_extension;

        public AutoUpScalingImage()
        {
            start();
        }

        private void start()
        {

            Random rand = new Random();
            int waitTime;

            setFileListToUpscale();

            return;

            Console.WriteLine("이미지 업스케일 작업 시작");
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
                /// 타겟 파일 설정
                setTargetFile();

                /// 사진 업로드 버튼 클릭 후 이미지 선택
                clickUploadBtnAndChooseImg();

                /// 랜덤 대기 시간 설정
                waitTime = 60000 + rand.Next(60000);
                Console.WriteLine((waitTime / 1000) + "초 대기");
                Console.WriteLine("현 시각 : " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                System.Threading.Thread.Sleep(waitTime);

                /// 저장 버튼 누르기
                click_save_btn();

                /// 저장된 파일 이름 변경 후 옮기기
                changeImageName();

                /// 모든 파일 작업이 끝났는지 확인 후 종료 여부 결정
                if (check_isEnd() == true) break;
            }
            
        }

        private void setFileListToUpscale()
        {
            string folderPath = TARGET_PATH; 
            string fileExtension;
            string onlyFileName;
            files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                onlyFileName = Path.GetFileName(file); // 파일이름과 확장자까지 나옴
                now_file_name_without_extension = Path.GetFileNameWithoutExtension(file);
                fileExtension = Path.GetExtension(file); // .jpg <- 이런 식으로 나옴
                Console.WriteLine("onlyFileName : " + onlyFileName);
                Console.WriteLine("onlyFileName : " + now_file_name_without_extension);
                Console.WriteLine("fileExtension : " + fileExtension);
            }
        }
        private void setTargetFile()
        {
            string targetFile = files[selected_file_index];
            selected_file_index++;
            now_file_name = Path.GetFileName(targetFile); // 파일이름과 확장자까지 나옴
            now_file_name_without_extension = Path.GetFileNameWithoutExtension(targetFile);
            Console.WriteLine("now_file_name : " + now_file_name);
        }


        private void clickUploadBtnAndChooseImg()
        {
            SendKeys.SendWait("{F5}");
            System.Threading.Thread.Sleep(1000);

            /// 4배 옵션 클릭
            Static_Method_Pack.SetCursorPos(448, 598);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);

            /// 업로드 버튼 클릭
            Static_Method_Pack.SetCursorPos(488, 494);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(1000);

            // 파일 이름 창 클릭
            Static_Method_Pack.SetCursorPos(400, 419);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);

            // 타겟 파일 이름 복붙
            // 주소 복사
            Clipboard.SetText(now_file_name);
            System.Threading.Thread.Sleep(500);
            // Ctrl + A
            SendKeys.SendWait("^{a}");
            System.Threading.Thread.Sleep(500);
            // Ctrl + V
            SendKeys.SendWait("^{v}");
            System.Threading.Thread.Sleep(500);

            // 열기버튼 클릭
            Static_Method_Pack.SetCursorPos(600, 447);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);
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

        private void click_save_btn()
        {
            /// 팝업 버튼 클릭
            Static_Method_Pack.SetCursorPos(480, 647);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(500);


            /// 저장 버튼 클릭
            Static_Method_Pack.SetCursorPos(886, 866);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(1000);


            /// X 버튼 클릭
            Static_Method_Pack.SetCursorPos(933, 303);
            System.Threading.Thread.Sleep(500);
            Static_Method_Pack.clickMouse();
            System.Threading.Thread.Sleep(1000);
        }

        private void changeImageName()
        {
            string folderPath = @"C:\Users\KHJ\Downloads\Image_upScale\temp\";
            string destinationPath = @"C:\Users\KHJ\Downloads\Image_upScale\";
            string fileExtension;
            int fileNum = 1;
            try
            {
                // 폴더 안에 있는 모든 파일 가져오기
                string[] files = Directory.GetFiles(folderPath);

                // 파일 리스트 출력
                Console.WriteLine("폴더 안에 있는 파일 리스트:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                    fileExtension = Path.GetExtension(file);
                    renameFile(file, now_file_name_without_extension + "__" + (fileNum++) + fileExtension);
                    Console.WriteLine("파일 이름을 성공적으로 변경했습니다.");
                }

                files = Directory.GetFiles(folderPath);
                foreach (string moveFile in files)
                {
                    Console.WriteLine(moveFile);
                    File.Move(moveFile, Path.Combine(destinationPath, Path.GetFileName(moveFile)));
                    Console.WriteLine("파일을 성공적으로 이동시켰습니다.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일 리스트를 가져오는 도중 오류 발생: {ex.Message}");
            }
        }
        private void renameFile(string filePath, string newFileName)
        {
            // 파일 이름을 포함한 새로운 경로 생성
            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), newFileName);

            // 파일 이름 변경
            File.Move(filePath, newFilePath);
        }

        private Boolean check_isEnd()
        {
            if(selected_file_index == (files.Length - 1)) return true;
            else return false;
        }
    }
}
