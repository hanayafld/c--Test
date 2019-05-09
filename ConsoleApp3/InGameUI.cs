using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class InGameUI
    {
        private UIGauge heroHpGauge;
        private UIGauge monsterHpGauge;
        public UIButton Btn { get; private set; }

        public InGameUI()
        {
            this.heroHpGauge = new UIGauge();
            this.monsterHpGauge = new UIGauge();

            this.Btn = new UIButton();
        }
    }
}
