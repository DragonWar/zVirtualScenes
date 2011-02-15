﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Net;

namespace zVirtualScenesApplication
{
    public class HttpServer
    {
        protected int port;
        TcpListener listener;
        bool is_active = true;
        private zVirtualScenes mForm;

        public HttpServer(int port, zVirtualScenes Form1)
        {
            this.port = port;
            this.mForm = Form1;
        }
        
        public void listen()
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();                
            while (is_active)
            {
                TcpClient s = listener.AcceptTcpClient();
                HttpProcessor processor = new HttpProcessor(s,this,mForm);
                Thread thread = new Thread(new ThreadStart(processor.process));
                thread.Start();
                Thread.Sleep(1);
            }
        }
    }

}
