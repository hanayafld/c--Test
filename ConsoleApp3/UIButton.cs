using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class UIButton
    {
        public event EventHandler OnClickEventHandler;

        public class ButtonClickedEvent
        {
        }

        public void AddListener(EventHandler call)
        {

        }

        public ButtonClickedEvent onClick { get; set; }

        public UIButton()
        {
            this.onClick = new ButtonClickedEvent();
        }
        
        public void Click()
        {
            //이벤트 발생
            this.OnClickEvent(EventArgs.Empty);
        }

        private void OnClickEvent(EventArgs e)
        {
            EventHandler handler = OnClickEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
