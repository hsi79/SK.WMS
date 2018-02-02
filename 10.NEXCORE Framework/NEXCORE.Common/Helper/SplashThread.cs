using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NEXCORE.Common.Helper
{
    public class SplashThread
    {
        private Thread thread;
        private frmProgressBar form;
 
        public SplashThread()
        {
            thread = new Thread(new ThreadStart(RunSplash));

        }

        public void Open()
        {
            //if (!thread.IsAlive)
            thread.Start();

        }

        public void Close()
        {

            try
            {
                form.Invoke(new CloseCallback(form.Close));
                //thread.Abort();
            }
            catch 
            {
                
               
            }
            
        }


        private void RunSplash()
        {
            form = new frmProgressBar();
            form.Load += new EventHandler(OnLoad);
            form.ShowDialog();
        }

        void OnLoad(object sender, EventArgs e)
        {

        }

        private delegate void CloseCallback();

    }
}
