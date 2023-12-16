﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoControlMouseKeyBoard
{
    internal class SimpleTool
    {
        public SimpleTool() 
        {
            String[] imgTextArr2 = {
                                    "푹신한 눈이 내리는 소나무 숲에서 크리스마스 캐럴 소리와 함께 누운 이불의 온기를 느끼는 공간",
"따스한 벽난로 앞에서 책과 함께 즐기는 평화로운 크리스마스 휴식",
"도심의 작은 공원에서 반짝이는 크리스마스 조명 아래 누운 이불 위에서의 힐링",
"산속 코티지에서 창문을 열어 흘러나오는 크리스마스 음악과 함께 누운 이불의 따스한 순간",
"도서관 속에서 크리스마스 트리 앞에서 책을 읽으며 크리스마스 분위기를 느끼는 힐링",
"도시의 작은 차례점에서 크리스마스 캐럴 소리와 함께 창밖의 눈을 감상하는 휴식",
"해가 지는 도시 공원에서 크리스마스 불빛과 함께하는 누운 이불의 힐링",
"작은 산골 마을에서 눈 내리는 크리스마스 밤에 불빛 속에서 휴식",
"도서관 코너에서 크리스마스 트리 앞에서 책과 함께하는 신비로운 힐링",
"도심의 작은 공원에서 크리스마스 조명이 반짝이는 소리와 함께 누운 이불의 따스한 순간",
"푸른 소나무 숲에서 크리스마스 캐럴 소리와 함께 누운 이불의 온기를 느끼는 휴식",
"도시의 작은 정원에서 크리스마스 불빛과 함께하는 푹신한 이불의 힐링",
"산 속 작은 오두막에서 창문을 열어 흘러나오는 크리스마스 음악과 함께 누운 이불의 따스한 순간",
"도시의 작은 공원에서 크리스마스 조명이 반짝이는 소리와 함께 누운 이불의 따스한 순간",
"도심 속 크리스마스 시장에서 따스한 음료와 함께하는 크리스마스 불빛 휴식",
"작은 공원의 크리스마스 트리 아래에서 누운 이불과 함께하는 힐링 순간",
"도서관 코너에서 미니어처 크리스마스 트리와 함께 음악을 즐기는 휴식",
"도심 거리를 비추는 크리스마스 조명 아래에서 누운 이불의 힐링 풍경",
"산 속 작은 오두막에서 창문 너머로 바라보는 크리스마스 밤의 평화로운 휴식",
"도시의 작은 공원에서 크리스마스 불빛이 비추는 이불 속 힐링",
"도서관 속 크리스마스 트리와 함께 음악을 들으며 누운 이불의 휴식",
"도심 속 작은 카페에서 크리스마스 캐럴 소리와 함께 차를 마시는 힐링",
"해가 지는 도시 공원에서 크리스마스 불빛이 비추는 누운 이불의 휴식",
"도서관 코너에서 크리스마스 분위기 속에서 미니어처 트리와 함께하는 힐링",
"도심 거리를 채우는 크리스마스 음악과 함께하는 누운 이불의 휴식",
"작은 산골 마을에서 크리스마스 트리 아래에서 누운 이불의 평화로운 힐링",
"도시의 작은 차례점에서 크리스마스 캐럴 소리와 함께 창밖을 내다보는 휴식",
"도서관 속 크리스마스 분위기 속에서 책과 함께 누운 이불의 힐링",
"도심 속 작은 카페에서 크리스마스 음악과 함께 차 한 잔의 휴식",
"해가 지는 도시 공원에서 크리스마스 불빛이 비추는 누운 이불의 평화로운 힐링",
            };
            createStrListWithoutDuplicate(imgTextArr2);
        }
        public void checkDuplicate(String[] strArr)
        {
            Console.WriteLine("제시된 문자 배열 길이 : " + strArr.Length);

            int duplicateCount = 0;
            string targetStr;
            string otherStr;
            for (int i = 0; i < strArr.Length; i++)
            {
                targetStr = strArr[i];
                for (int m = (i + 1); m < strArr.Length; m++)
                {
                    otherStr = strArr[m];
                    if (targetStr == otherStr)
                    {
                        Console.WriteLine("아래 글은 서로 중복" + "count : " + (++duplicateCount));
                        Console.WriteLine("targetStr : " + targetStr);
                        Console.WriteLine("otherStr : " + otherStr);
                    }
                }
            }

        }

        public void createStrListWithoutDuplicate(String[] strArr)
        {
            List<string> stringList = new List<string>();
            string targetStr;
            for (int i = 0; i < strArr.Length; i++)
            {
                targetStr = strArr[i];

                if(checkDuplicateStrInList(targetStr, stringList) == true)
                {
                    continue;
                }
                else
                {
                    stringList.Add(targetStr);
                }
            }

            Console.WriteLine("완성된 list");
            foreach (string listStr in stringList)
            {
                Console.WriteLine("\"" + listStr + "\",");
            }
        }

        private bool checkDuplicateStrInList(string targetStr, List<string> stringList)
        {
            foreach (string listStr in stringList)
            {
                if (targetStr == listStr) return true;
            }
            return false;
        }
    }

}
