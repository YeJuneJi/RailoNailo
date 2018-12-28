using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailoNailo
{
    class Translation
    {
        public static string translationText(string name) {
            switch (name)
            {
                case "가평":
                    name = "Gapyeong";
                    break;
                case "강릉":
                    name = "Gangneung";
                    break;
                case "경주":
                    name = "Gyeongju";
                    break;
                case "광명":
                    name = "Gwangmyeong";
                    break;
                case "광주":
                    name = "Gwangju";
                    break;
                case "광주송정":
                    name = "GwangjuSongjeong";
                    break;
                case "구미":
                    name = "Gumi";
                    break;
                case "김천(구미)":
                    name = "Gimcheongumi";
                    break;
                case "나주":
                    name = "Naju";
                    break;
                case "남원":
                    name = "Namwon";
                    break;
                case "단양":
                    name = "Danyang";
                    break;
                case "대구":
                    name = "Daegu";
                    break;
                case "대전":
                    name = "Daejeon";
                    break;
                case "동대구":
                    name = "EastDaegu";
                    break;
                case "동해":
                    name = "Donghae";
                    break;
                case "마산":
                    name = "Masan";
                    break;
                case "목포":
                    name = "Mokpo";
                    break;
                case "민둥산":
                    name = "Mindungsan";
                    break;
                case "부산":
                    name = "Busan";
                    break;
                case "부전":
                    name = "Bujeon";
                    break;
                case "서울":
                    name = "Seoul";
                    break;
                case "수원":
                    name = "Suwon";
                    break;
                case "순천":
                    name = "Suncheon";
                    break;
                case "신경주":
                    name = "Singyeongju";
                    break;
                case "안동":
                    name = "Andong";
                    break;
                case "여수엑스포":
                    name = "YeosuExpo";
                    break;
                case "영등포":
                    name = "Yeongdeungpo";
                    break;
                case "영월":
                    name = "Yeongwol";
                    break;
                case "영전":
                    name = "Promotional";
                    break;
                case "영주":
                    name = "Yeongju";
                    break;
                case "영천":
                    name = "Yeongcheon";
                    break;
                case "용산":
                    name = "Yongsan";
                    break;
                case "울산":
                    name = "Ulsan";
                    break;
                case "익산":
                    name = "Iksan";
                    break;
                case "전주":
                    name = "Jeonju";
                    break;
                case "점촌":
                    name = "Jeomchon";
                    break;
                case "정읍":
                    name = "Jeongeup";
                    break;
                case "제천":
                    name = "Jecheon";
                    break;
                case "진주":
                    name = "Jinju";
                    break;
                case "천안":
                    name = "Cheonan";
                    break;
                case "천안아산":
                    name = "CheonanAsan";
                    break;
                case "청량리":
                    name = "Cheongnyangni";
                    break;
                case "춘양":
                    name = "Chunyang";
                    break;
                case "춘천":
                    name = "Chuncheon";
                    break;
                case "충주":
                    name = "Chungju";
                    break;
                case "태백":
                    name = "Taebaek";
                    break;
                case "평창":
                    name = "Pyeongchang";
                    break;
                case "포항":
                    name = "Pohang";
                    break;
                default:
                    break;
            }

            return name;
        }
    }
}
