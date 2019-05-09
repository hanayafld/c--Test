using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class EventDispatcher
    {
        private static EventDispatcher Instantce;
        private Dictionary<string, EventArgs> dicEventHandler = new Dictionary<string, EventArgs>();
        
        public static EventDispatcher GetInstance()
        {
            if (EventDispatcher.Instantce == null)
            {
                EventDispatcher.Instantce = new EventDispatcher();
            }
            return EventDispatcher.Instantce;
        }

        //이벤트 핸들러 등록
        public void AddEventHandler(string eventName, EventArgs eventHandler)
        {
            if (!this.dicEventHandler.ContainsKey(eventName))
            {
                this.dicEventHandler.Add(eventName, eventHandler);
                Console.WriteLine("이벤트 {0}이가 등록됐습니다. : {1}", eventName, eventHandler);
            }
        }

        //이벤트 발생
        public void DispatchEvent(string eventName, EventArgs e)
        {
            var handler = this.dicEventHandler[eventName];
            //handler(EventDispatcher.GetInstance(), e);
            
        }
    }

}
