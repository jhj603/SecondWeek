using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.IO;

namespace SecondWeek
{
    internal class MainGame
    {
        Player player = null;

        Map currentMap = null;

        Dictionary<string, Map> maps = new Dictionary<string, Map>();

        int restFee = 500;

        string mapKey = null;

        public bool Initialize()
        {
            if (null == player)
                player = new Player();

            maps.Add("Shop", new Shop());
            maps.Add("Dungeon", new Dungeon());

            return true;
        }

        public void Update()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("4. 던전 입장");
                Console.WriteLine("5. 휴식하기");
                Console.WriteLine();
                Console.WriteLine("8. 게임 저장");
                Console.WriteLine("9. 게임 불러오기");
                Console.WriteLine();
                Console.WriteLine("0. 게임 종료");
                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                switch (Console.ReadLine())
                {
                    case "0":
                        return;
                    case "1":
                        player.Status_Render();
                        break;
                    case "2":
                        player.Inven_Render();
                        break;
                    case "3":
                        if (null != currentMap)
                            maps.Add(mapKey, currentMap);

                        currentMap = maps["Shop"];
                        mapKey = "Shop";
                        maps.Remove(mapKey);

                        currentMap.Update(player);
                        break;
                    case "4":
                        if (null != currentMap)
                            maps.Add(mapKey, currentMap);

                        currentMap = maps["Dungeon"];
                        mapKey = "Dungeon";
                        maps.Remove(mapKey);

                        currentMap.Update(player);
                        break;
                    case "5":
                        Rest_Draw();
                        break;
                    case "8":
                        Save_Game();
                        break;
                    case "9":
                        Load_Game();
                        break;
                    default:
                        Program.Input_Error();
                        break;
                }
            }
        }

        void Rest_Draw()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("휴식하기");
                Console.WriteLine($"{restFee} G 를 내면 체력을 회복할 수 있습니다. (보유 골드 : {player.Gold} G)");
                Console.WriteLine($"현재 체력 : {player.HP}    =>\t휴식 후 체력 : {player.MaxHP}");
                Console.WriteLine();
                Console.WriteLine("1. 휴식하기");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine();

                        if (restFee > player.Gold)
                            Console.WriteLine("Gold가 부족합니다");
                        else
                            player.Rest(restFee);

                        Thread.Sleep(1000);
                        break;
                    case "0":
                        return;
                    default:
                        Program.Input_Error();
                        break;
                }
            }
        }

        void Save_Game()
        {
            string fileName = "PlayerData.json";
            string filePath = Path.Combine("../../../../", fileName);

            var options = new JsonSerializerOptions { WriteIndented = true };

            string playerData = JsonSerializer.Serialize(player, options);

            playerData = Regex.Unescape(playerData);

            File.WriteAllText(filePath, playerData);

            player.Inven_Save();

            Console.WriteLine("\n저장 완료!");

            Thread.Sleep(1000);
        }

        void Load_Game()
        {
            string fileName = "PlayerData.json";
            string filePath = Path.Combine("../../../../", fileName);

            if (File.Exists(filePath))
            {
                string playerJson = File.ReadAllText(filePath);

                playerJson = Regex.Unescape(playerJson);

                player = JsonSerializer.Deserialize<Player>(playerJson);

                player.Load_Data();

                Console.WriteLine("\n불러오기 성공!");

                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("\n저장된 데이터가 없습니다.");
                
                Thread.Sleep(1000);
            }
        }
    }
}
