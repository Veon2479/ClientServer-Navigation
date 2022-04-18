﻿using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public class Server
    {
        //read default settings from App.config
        private static int DEFAULT_TCP_PORT = int.Parse(ConfigurationManager.AppSettings.Get("DEFAULT_TCP_PORT"));
        private static int DEFAULT_UDP_PORT = int.Parse(ConfigurationManager.AppSettings.Get("DEFAULT_UDP_PORT"));

        //thread signal.  
        private static ManualResetEvent allDoneTcp = new ManualResetEvent(false);
        private static ManualResetEvent allDoneUdp = new ManualResetEvent(false);

        public static void Main(string[] args)
        {
            Server.Start();
        }

        /// <summary>
        /// start TcpListener & UdpListener
        /// </summary>
        public static int Start()
        {
            Thread tcpListener = new Thread(StartTcpListener);
            Thread udpListener = new Thread(StartUdpListener);

            tcpListener.Start();
            udpListener.Start();

            return 0;
        }

        /// <summary>
        /// create and start TcpListener
        /// </summary>
        private static void StartTcpListener()
        {
            var listener = new TcpListener(IPAddress.Any, DEFAULT_TCP_PORT);

            try
            {
                listener.Start();
                Console.WriteLine("TcpListener started");

                while (true)
                {
                    //set the event to nonsignaled state
                    allDoneTcp.Reset();

                    //start an asynchronous socket to listen for connections
                    listener.BeginAcceptTcpClient(new AsyncCallback(AcceptTcpClient), listener);

                    //wait until a connection is made before continuing
                    allDoneTcp.WaitOne();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                listener.Stop();
            }
        }

        /// <summary>
        /// asynchronous accept tcp client
        /// </summary>
        /// <param name="ar">async result</param>
        private static async void AcceptTcpClient(IAsyncResult ar)
        {
            //signal the main thread to continue
            allDoneTcp.Set();

            //get the socket that handles the client request
            TcpListener listener = (TcpListener)ar.AsyncState;
            TcpClient handler = listener.EndAcceptTcpClient(ar);
            try
            {
                //get user stream
                var stream = handler.GetStream();

                //receive data from user
                using var reader = new StreamReader(stream);
                var data = await reader.ReadLineAsync();
                Console.WriteLine("[TCP receive] {0}", data);

                //magic with data

                //send answer to user
                using var writer = new StreamWriter(stream);
                await writer.WriteLineAsync(data);
                await writer.FlushAsync();
                Console.WriteLine("[TCP    send] {0}", data);

                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// create and start UdpListener
        /// </summary>
        private static void StartUdpListener()
        {
            UdpClient listener = new UdpClient(DEFAULT_UDP_PORT);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, DEFAULT_UDP_PORT);
            Console.WriteLine("UdpListener started");

            try
            {
                while (true)
                {
                    //set the event to nonsignaled state
                    allDoneUdp.Reset();

                    //start an asynchronous socket to listen for connections
                    listener.BeginReceive(new AsyncCallback(AcceptUdpClient), listener);

                    //wait until a connection is made before continuing
                    allDoneUdp.WaitOne();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                listener.Close();
            }
        }

        /// <summary>
        /// asynchronous accept udp client
        /// </summary>
        /// <param name="ar">async result</param>
        private static void AcceptUdpClient(IAsyncResult ar)
        {
            //signal the main thread to continue
            allDoneUdp.Set();

            UdpClient listener = (UdpClient)ar.AsyncState;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, DEFAULT_UDP_PORT);

            byte[] data = listener.EndReceive(ar, ref endPoint);
            
            UserPacket packet = UserPacket.getStruct(data);
            
            Console.WriteLine("[UDP receive] {0}", packet.ToString());

            //magic with data
        }
    }
}