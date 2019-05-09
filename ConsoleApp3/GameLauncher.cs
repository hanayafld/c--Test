using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class GameLauncher
    {
        public Hero hero;
        public Monster monster;

        public InGameUI inGameUI;
        

        public GameLauncher()
        {
        }

        public void Init()
        {
            Console.WriteLine("게임준비완료");
            this.inGameUI = new InGameUI();

            this.hero = new Hero();
            this.monster = new Monster();

            this.hero.Init("밥병헌");
            this.monster.Init("승길동");

            //이벤트 등록
            EventDispatcher.GetInstance().AddEventHandler("MONSTER_DIE", EventArgs.Empty);
            this.inGameUI.Btn.OnClickEventHandler += Btn_OnClickEventHandler;

            //사용자가 눌렀다고 치자
        }

        private void Btn_OnClickEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("버튼을 눌렀습니다.");
            this.hero.ActiveSkill();
            this.monster.TakeDamage(5);
        }

        public void Run()
        {
            Console.WriteLine("게임실행");
            this.inGameUI.Btn.Click();
        }
    }
}
