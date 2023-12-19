using System;
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
            String[] imgTextArr = {
                                    "피투성이의 전장에서 나만의 안식처를 찾아 명상에 잠긴 순간",
"모든 것을 잃은 도시의 폐허에서 내면의 평화를 찾아가는 명상의 시간",
"실패와 상실의 아픔을 안고 명상에 푹 빠진 무너진 도시의 모습",
"망가진 건물과 함께하는 심연의 명상, 상실과 허무함에 잠긴 순간",
"절망의 도시에서 마지막 희망을 찾아가는 명상의 여정",
"파괴된 거리에서 나만의 소나무 아래 명상에 잠긴 휴식의 순간",
"허무하게 흩어진 회사의 잔해에서 내면의 평화를 찾아가는 명상의 시간",
"모든 것을 잃은 도시의 고요 속에서 명상에 몰두하는 순간",
"전쟁의 아픔을 감싸는 도시에서 나만의 안식처를 찾아가는 명상의 여정",
"상실의 아픔에 잠긴 마음을 달래기 위한 명상의 순간",
"마음의 상처를 안고 힘들게 서 있는 모습에서 시작하는 명상의 여정",
"좌절과 절망이 깔린 도심 속에서 희망의 빛을 찾아가는 명상의 시간",
"피투성이의 전장에서 마음의 평화를 찾아가는 명상의 순간",
"허무하게 흩어진 도시의 미래를 명상으로 여는 순간",
"실패와 상실의 공간에서 내면의 평온을 찾아가는 명상의 여정",
"허무하게 무너진 건물 사이에서 시작되는 명상의 시간",
"전쟁의 잔해 속에서 내면의 평화를 찾아가는 명상의 순간",
"상실의 무게를 안고 명상에 잠긴 도시의 휴식",
"피투성이의 전장에서 나만의 명상 공간을 찾아가는 순간",
"상실과 절망의 중심지에서 시작하는 명상의 여정",
"힘들게 서 있는 도시의 풍경에서 내면의 안정을 찾아가는 명상의 시간",
"허무하게 흩어진 회사의 잔해에서 명상에 잠긴 순간",
"실패와 상실의 아픔을 명상으로 감싸는 도시의 모습",
"피투성이의 전장에서 마음의 평화를 찾아가는 명상의 여정",
"상실과 절망에 묻힌 도시에서 시작되는 명상의 순간",
"전쟁의 잔해 사이에서 나만의 안식처를 찾아가는 명상의 시간",
"모든 것을 잃은 도시의 폐허에서 내면의 평화를 찾아가는 명상의 여정",
"실패와 상실의 중심에서 명상에 푹 빠진 도시의 순간",
"폐허가 된 도시에서 내면의 평화를 찾아가는 명상의 시간",
"모든 것을 잃은 상태에서 휴식을 찾아가는 심연의 명상 여정",
"전쟁의 잔해 사이에서 내면의 평화를 탐하는 명상의 순간",
"좌절과 상실에 휩싸인 마음을 달래는 명상의 힐링 타임",
"허무하게 흩어진 도시의 폐허에서 명상에 몰두하는 순간",
"실패의 그림자에 가려진 도시에서 내면의 평화를 찾는 명상",
"모든 것을 잃은 상태에서 찾아가는 명상의 휴식과 치유",
"전쟁의 아픔과 상실 속에서 내면의 평화를 찾아가는 명상의 여정",
"절망과 고독에 휘말린 도시에서 시작하는 명상의 힐링 여행",
"좌절과 실패의 그림자에 묻힌 마음을 명상으로 치유하는 순간",
"허무하게 흩어진 회사의 잔해에서 명상에 잠긴 휴식의 순간",
"인간관계의 상실과 고독에서 탈출하는 명상의 힐링 타임",
"도시의 잔해 속에서 찾아가는 내면의 평화를 담은 명상",
"전쟁의 아픔을 감싸는 도시에서 내면의 안식처를 찾아가는 명상",
"상실과 절망에 묻힌 도시에서 시작하는 명상의 순간",
"좌절과 허무함이 깔린 도시 속에서 명상의 힐링을 찾는 순간",
"전쟁의 잔해 사이에서 내면의 평화를 찾아가는 명상의 시간"
            };
            createStrListWithoutDuplicate(imgTextArr);
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
