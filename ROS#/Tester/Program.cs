﻿#region USINGZ

using System;
using System.Threading;
using EricIsAMAZING;
using Messages;
using Messages.custom_msgs;
using XmlRpc_Wrapper;
using String = Messages.std_msgs.String;
using m = Messages.std_msgs;
using gm = Messages.geometry_msgs;
using nm = Messages.nav_msgs;

#endregion

namespace ConsoleApplication1
{
    public class Program
    {
        private const string ROS_MASTER_URI = "http://robot-lab8:11311/";
        //private const string ROS_MASTER_URI = "http://localhost:11311/";

        public static WrapperTest.balls BALLS;

        public static WrapperTest.TellMeHowAwesomeIAm tellmehowawesomeiam;


        public static void thisishowawesomeyouare(string s)
        {
            Console.WriteLine(s);
        }

        public static void chatterCallback(TypedMessage<String> msg)
        {
            Console.WriteLine("HOLY FUCKSTICK!");
        }

        private static void Main(string[] args)
        {
            /*TypedMessage<Messages.rosgraph_msgs.Log> md5test = new TypedMessage<Messages.rosgraph_msgs.Log>();
            string teststr = TypeHelper.MessageDefinitions[md5test.type].Trim();
            Console.WriteLine("DEF = \n" + teststr + "\n\n\n");
            Console.WriteLine(MD5.Sum(md5test.type));
            Console.ReadLine();
            return;*/
            tellmehowawesomeiam = thisishowawesomeyouare;
            WrapperTest.SetAwesomeFunctionPtr(tellmehowawesomeiam);
            ROS.ROS_MASTER_URI = ROS_MASTER_URI;
            ROS.Init(args, "ROSsharp_Listener");
            NodeHandle nh = new NodeHandle();
            //NodeHandle nh2 = new NodeHandle();
            Publisher<arraytest> pub = nh.advertise<arraytest>("chatter", 1000);
            //Subscriber<TypedMessage<String>> sub = nh.subscribe<String>("chatter", 1000, chatterCallback);
            string concatme = "HOLY FUCKSTICK!";
            new Thread
                (() =>
                     {
                         int count = 0;
                         while (ROS.ok)
                         {
                             ROS.Info("ERIC RULZ! 8");
                             Thread.Sleep(1000);
                         }
                     }).Start();
            while (ROS.ok)
            {
                arraytest test = new arraytest {lengthlessintegers = new[] {2, 3, 4}, fuckass = "FUCKASS", fuckasses = new[]{"FUCKASS1","FUCKASS2"}};
                test.integers[0] = 0;
                test.integers[1] = 1;
                pub.publish(test);
                //pub.publish(new String { data = concatme });
                //ROS.Log("HOLY FUCKSTICK");
                ROS.spinOnce();
                Thread.Sleep(1000);
            }


            //Publisher<m.TypedMessage<String>> pub = nh.advertise<String>("chatter", 1000);
            //pub.publish(new m.TypedMessage<String>(new String(){ data = "BLAH BLAH BLAH" }));
            /*if (!node.InitSubscriber("/rxconsole_1308702433994048982", "/rosout_agg"))
            {
                Console.WriteLine("FAILED TO REQUEST TOPIC... FUCK STAINS!");
                Console.ReadLine(); 
                node.Shutdown();
                return;
            }
            else
            {
                Console.WriteLine("HOLY FUCKING SHIT THE XMLRPC SHIT FUCKING CONNECTED!");
            }
            node.ConnectAsync();
             */
            Console.ReadLine();
            //node.Shutdown();
        }
    }

    #region some day... later

    /*
            TcpClient tcp = new TcpClient(new IPEndPoint(IPAddress.Parse("129.63.16.176"), 0));
            UdpClient udp = new UdpClient(new IPEndPoint(IPAddress.Parse("129.63.16.176"), 0));
            udp.BeginReceive(udprape, udp);
            tcp.Connect(new IPEndPoint(IPAddress.Parse("129.63.16.228"), 11311));
            Socket tcpserver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpserver.Bind(new IPEndPoint(IPAddress.Parse("129.63.16.176"), 0));
            tcpserver.Listen(0);
            AcceptRape(tcpserver);
            streamer = tcp.GetStream();


            Dictionary<string, string> headerthing = new Dictionary<string, string>
                                                         {
                                                             {"callerid", "/rosout"},
                                                             {"md5sum", "acffd30cd6b6de30f120938c17c593fb"},
                                                             {"tcp_nodelay", "0"},
                                                             {"topic", "/rosout"},
                                                             {"type", "rosgraph_msgs/log"}
                                                         };
            WriteThatShit(DictionaryBlender(headerthing));
            Dictionary<string, string> headerthing2 = new Dictionary<string, string>
                                                         {
                                                             {"callerid", NodeName},
                                                             {"latching","1"},
                                                             {"md5sum", "acffd30cd6b6de30f120938c17c593fb8"},
                                                             {"tcp_nodelay", "0"},
                                                             {"message_definition", "##\n## Severity level constants\n##\nbyte DEBUG=1 #debug level\nbyte INFO=2  #general level\nbyte WARN=4  #warning level\nbyte ERROR=8 #error level\nbyte FATAL=16 #fatal/critical level\n##\n## Fields\n##\nHeader header\nbyte level\nstring name # name of the node\nstring msg # message\nstring file # file the message came from\nstring function # function the message came from\nuint32 line # line the message came from\n\nstring[] topics # topic names that the node publishes\n================================================================================\nMSG: std_msgs/Header\n# Standard metadata for higher-level stamped data types.\n# This is generally used to communicate timestamped data \n# in a particular coordinate frame.\n# \n# sequence ID: consecutively increasing ID \nuint32 seq\n#Two-integer timestamp that is expressed as:\n# * stamp.secs: seconds (stamp_secs) since epoch\n# * stamp.nsecs: nanoseconds since stamp_secs\n# time-handling sugar is provided by the client library\ntime stamp\n#Frame this data is associated with\n# 0: no frame\n# 1: global frame\nstring frame_id\n\n"}
                                                         };
            WriteThatShit(DictionaryBlender(headerthing2));

             byte[] buf = new byte[8192];
            int res = 0;
            res = streamer.Read(buf, 0, 8192);
            Console.WriteLine(Encoding.ASCII.GetString(buf).Trim('\n',' ', '\0', '\t', '\r'));

            */

    #endregion

    /*public class NodeClient : MarshalByRefObject, NodeProxy
    {

        public BusStats getBusStats(string caller_id)
        {
            Console.WriteLine(caller_id);
            return default(BusStats);
        }

        public IAsyncResult beginGetBusStats(string caller_id)
        {
            Console.WriteLine(caller_id);
            return default(IAsyncResult);
        }

        public BusStats endGetBusStats(IAsyncResult iar)
        {
            Console.WriteLine(iar.ToString());
            return default(BusStats);
        }
    }*/

    #region LUL

    /*short len = 1196;
            byte[] consoleheader = new byte[]
                                       {
                                           39, 0, 0, 0, 99, 97, 108, 108, 101, 114, 105, 100, 61, 47, 114, 120, 99, 111,
                                           110, 115, 111, 108, 101, 95, 49, 51, 48, 56, 54, 56, 52, 55, 57, 56, 49, 50,
                                           57, 55, 56, 52, 55, 49, 49, 39, 0, 0, 0, 109, 100, 53, 115, 117, 109, 61, 97,
                                           99, 102, 102, 100, 51, 48, 99, 100, 54, 98, 54, 100, 101, 51, 48, 102, 49, 50
                                           , 48, 57, 51, 56, 99, 49, 55, 99, 53, 57, 51, 102, 98, 13, 0, 0, 0, 116, 99,
                                           112, 95, 110, 111, 100, 101, 108, 97, 121, 61, 48, 17, 0, 0, 0, 116, 111, 112
                                           , 105, 99, 61, 47, 114, 111, 115, 111, 117, 116, 95, 97, 103, 103, 22, 0, 0,
                                           0, 116, 121, 112, 101, 61, 114, 111, 115, 103, 114, 97, 112, 104, 95, 109,
                                           115, 103, 115, 47, 76, 111, 103
                                       };
            byte[] consoleheader2 = new byte[]
                                        {
                                            39, 0, 0, 0, 99, 97, 108, 108, 101, 114, 105, 100, 61, 47, 114, 120, 99, 111
                                            , 110, 115, 111, 108, 101, 95, 49, 51, 48, 56, 54, 56, 52, 55, 57, 56, 49,
                                            50, 57, 55, 56, 52, 55, 49, 49, 10, 0, 0, 0, 108, 97, 116, 99, 104, 105, 110
                                            , 103, 61, 49, 39, 0, 0, 0, 109, 100, 53, 115, 117, 109, 61, 97, 99, 102,
                                            102, 100, 51, 48, 99, 100, 54, 98, 54, 100, 101, 51, 48, 102, 49, 50, 48, 57
                                            , 51, 56, 99, 49, 55, 99, 53, 57, 51, 102, 98, 56, 4, 0, 0, 109, 101, 115,
                                            115, 97, 103, 101, 95, 100, 101, 102, 105, 110, 105, 116, 105, 111, 110, 61,
                                            35, 35, 10, 35, 35, 32, 83, 101, 118, 101, 114, 105, 116, 121, 32, 108, 101,
                                            118, 101, 108, 32, 99, 111, 110, 115, 116, 97, 110, 116, 115, 10, 35, 35, 10
                                            , 98, 121, 116, 101, 32, 68, 69, 66, 85, 71, 61, 49, 32, 35, 100, 101, 98,
                                            117, 103, 32, 108, 101, 118, 101, 108, 10, 98, 121, 116, 101, 32, 73, 78, 70
                                            , 79, 61, 50, 32, 32, 35, 103, 101, 110, 101, 114, 97, 108, 32, 108, 101,
                                            118, 101, 108, 10, 98, 121, 116, 101, 32, 87, 65, 82, 78, 61, 52, 32, 32, 35
                                            , 119, 97, 114, 110, 105, 110, 103, 32, 108, 101, 118, 101, 108, 10, 98, 121
                                            , 116, 101, 32, 69, 82, 82, 79, 82, 61, 56, 32, 35, 101, 114, 114, 111, 114,
                                            32, 108, 101, 118, 101, 108, 10, 98, 121, 116, 101, 32, 70, 65, 84, 65, 76,
                                            61, 49, 54, 32, 35, 102, 97, 116, 97, 108, 47, 99, 114, 105, 116, 105, 99,
                                            97, 108, 32, 108, 101, 118, 101, 108, 10, 35, 35, 10, 35, 35, 32, 70, 105,
                                            101, 108, 100, 115, 10, 35, 35, 10, 72, 101, 97, 100, 101, 114, 32, 104, 101
                                            , 97, 100, 101, 114, 10, 98, 121, 116, 101, 32, 108, 101, 118, 101, 108, 10,
                                            115, 116, 114, 105, 110, 103, 32, 110, 97, 109, 101, 32, 35, 32, 110, 97,
                                            109, 101, 32, 111, 102, 32, 116, 104, 101, 32, 110, 111, 100, 101, 10, 115,
                                            116, 114, 105, 110, 103, 32, 109, 115, 103, 32, 35, 32, 109, 101, 115, 115,
                                            97, 103, 101, 32, 10, 115, 116, 114, 105, 110, 103, 32, 102, 105, 108, 101,
                                            32, 35, 32, 102, 105, 108, 101, 32, 116, 104, 101, 32, 109, 101, 115, 115,
                                            97, 103, 101, 32, 99, 97, 109, 101, 32, 102, 114, 111, 109, 10, 115, 116,
                                            114, 105, 110, 103, 32, 102, 117, 110, 99, 116, 105, 111, 110, 32, 35, 32,
                                            102, 117, 110, 99, 116, 105, 111, 110, 32, 116, 104, 101, 32, 109, 101, 115,
                                            115, 97, 103, 101, 32, 99, 97, 109, 101, 32, 102, 114, 111, 109, 10, 117,
                                            105, 110, 116, 51, 50, 32, 108, 105, 110, 101, 32, 35, 32, 108, 105, 110,
                                            101, 32, 116, 104, 101, 32, 109, 101, 115, 115, 97, 103, 101, 32, 99, 97,
                                            109, 101, 32, 102, 114, 111, 109, 10, 115, 116, 114, 105, 110, 103, 91, 93,
                                            32, 116, 111, 112, 105, 99, 115, 32, 35, 32, 116, 111, 112, 105, 99, 32, 110
                                            , 97, 109, 101, 115, 32, 116, 104, 97, 116, 32, 116, 104, 101, 32, 110, 111,
                                            100, 101, 32, 112, 117, 98, 108, 105, 115, 104, 101, 115, 10, 10, 61, 61, 61
                                            , 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61
                                            , 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61
                                            , 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61
                                            , 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61
                                            , 61, 10, 77, 83, 71, 58, 32, 115, 116, 100, 95, 109, 115, 103, 115, 47, 72,
                                            101, 97, 100, 101, 114, 10, 35, 32, 83, 116, 97, 110, 100, 97, 114, 100, 32,
                                            109, 101, 116, 97, 100, 97, 116, 97, 32, 102, 111, 114, 32, 104, 105, 103,
                                            104, 101, 114, 45, 108, 101, 118, 101, 108, 32, 115, 116, 97, 109, 112, 101,
                                            100, 32, 100, 97, 116, 97, 32, 116, 121, 112, 101, 115, 46, 10, 35, 32, 84,
                                            104, 105, 115, 32, 105, 115, 32, 103, 101, 110, 101, 114, 97, 108, 108, 121,
                                            32, 117, 115, 101, 100, 32, 116, 111, 32, 99, 111, 109, 109, 117, 110, 105,
                                            99, 97, 116, 101, 32, 116, 105, 109, 101, 115, 116, 97, 109, 112, 101, 100,
                                            32, 100, 97, 116, 97, 32, 10, 35, 32, 105, 110, 32, 97, 32, 112, 97, 114,
                                            116, 105, 99, 117, 108, 97, 114, 32, 99, 111, 111, 114, 100, 105, 110, 97,
                                            116, 101, 32, 102, 114, 97, 109, 101, 46, 10, 35, 32, 10, 35, 32, 115, 101,
                                            113, 117, 101, 110, 99, 101, 32, 73, 68, 58, 32, 99, 111, 110, 115, 101, 99,
                                            117, 116, 105, 118, 101, 108, 121, 32, 105, 110, 99, 114, 101, 97, 115, 105,
                                            110, 103, 32, 73, 68, 32, 10, 117, 105, 110, 116, 51, 50, 32, 115, 101, 113,
                                            10, 35, 84, 119, 111, 45, 105, 110, 116, 101, 103, 101, 114, 32, 116, 105,
                                            109, 101, 115, 116, 97, 109, 112, 32, 116, 104, 97, 116, 32, 105, 115, 32,
                                            101, 120, 112, 114, 101, 115, 115, 101, 100, 32, 97, 115, 58, 10, 35, 32, 42
                                            , 32, 115, 116, 97, 109, 112, 46, 115, 101, 99, 115, 58, 32, 115, 101, 99,
                                            111, 110, 100, 115, 32, 40, 115, 116, 97, 109, 112, 95, 115, 101, 99, 115,
                                            41, 32, 115, 105, 110, 99, 101, 32, 101, 112, 111, 99, 104, 10, 35, 32, 42,
                                            32, 115, 116, 97, 109, 112, 46, 110, 115, 101, 99, 115, 58, 32, 110, 97, 110
                                            , 111, 115, 101, 99, 111, 110, 100, 115, 32, 115, 105, 110, 99, 101, 32, 115
                                            , 116, 97, 109, 112, 95, 115, 101, 99, 115, 10, 35, 32, 116, 105, 109, 101,
                                            45, 104, 97, 110, 100, 108, 105, 110, 103, 32, 115, 117, 103, 97, 114, 32,
                                            105, 115, 32, 112, 114, 111, 118, 105, 100, 101, 100, 32, 98, 121, 32, 116,
                                            104, 101, 32, 99, 108, 105, 101, 110, 116, 32, 108, 105, 98, 114, 97, 114,
                                            121, 10, 116, 105, 109, 101, 32, 115, 116, 97, 109, 112, 10, 35, 70, 114, 97
                                            , 109, 101, 32, 116, 104, 105, 115, 32, 100, 97, 116, 97, 32, 105, 115, 32,
                                            97, 115, 115, 111, 99, 105, 97, 116, 101, 100, 32, 119, 105, 116, 104, 10,
                                            35, 32, 48, 58, 32, 110, 111, 32, 102, 114, 97, 109, 101, 10, 35, 32, 49, 58
                                            , 32, 103, 108, 111, 98, 97, 108, 32, 102, 114, 97, 109, 101, 10, 115, 116,
                                            114, 105, 110, 103, 32, 102, 114, 97, 109, 101, 95, 105, 100, 10, 10, 22, 0,
                                            0, 0, 116, 121, 112, 101, 61, 114, 111, 115, 103, 114, 97, 112, 104, 95, 109
                                            , 115, 103, 115, 47, 76, 111, 103
                                        };
            byte[] listenerheader = new byte[]
                                        {
                                            21, 0, 0, 0, 99, 97, 108, 108, 101, 114, 105, 100, 61, 47, 69, 114, 105, 99,
                                            82, 117, 108, 122, 70, 97, 110, 10, 0, 0, 0, 108, 97, 116, 99, 104, 105, 110
                                            , 103, 61, 49, 39, 0, 0, 0, 109, 100, 53, 115, 117, 109, 61, 97, 99, 102,
                                            102, 100, 51, 48, 99, 100, 54, 98, 54, 100, 101, 51, 48, 102, 49, 50, 48, 57
                                            , 51, 56, 99, 49, 55, 99, 53, 57, 51, 102, 98, 56, 4, 0, 0, 109, 101, 115,
                                            115, 97, 103, 101, 95, 100, 101, 102, 105, 110, 105, 116, 105, 111, 110, 61,
                                            35, 35, 10, 35, 35, 32, 83, 101, 118, 101, 114, 105, 116, 121, 32, 108, 101,
                                            118, 101, 108, 32, 99, 111, 110, 115, 116, 97, 110, 116, 115, 10, 35, 35, 10
                                            , 98, 121, 116, 101, 32, 68, 69, 66, 85, 71, 61, 49, 32, 35, 100, 101, 98,
                                            117, 103, 32, 108, 101, 118, 101, 108, 10, 98, 121, 116, 101, 32, 73, 78, 70
                                            , 79, 61, 50, 32, 32, 35, 103, 101, 110, 101, 114, 97, 108, 32, 108, 101,
                                            118, 101, 108, 10, 98, 121, 116, 101, 32, 87, 65, 82, 78, 61, 52, 32, 32, 35
                                            , 119, 97, 114, 110, 105, 110, 103, 32, 108, 101, 118, 101, 108, 10, 98, 121
                                            , 116, 101, 32, 69, 82, 82, 79, 82, 61, 56, 32, 35, 101, 114, 114, 111, 114,
                                            32, 108, 101, 118, 101, 108, 10, 98, 121, 116, 101, 32, 70, 65, 84, 65, 76,
                                            61, 49, 54, 32, 35, 102, 97, 116, 97, 108, 47, 99, 114, 105, 116, 105, 99,
                                            97, 108, 32, 108, 101, 118, 101, 108, 10, 35, 35, 10, 35, 35, 32, 70, 105,
                                            101, 108, 100, 115, 10, 35, 35, 10, 72, 101, 97, 100, 101, 114, 32, 104, 101
                                            , 97, 100, 101, 114, 10, 98, 121, 116, 101, 32, 108, 101, 118, 101, 108, 10,
                                            115, 116, 114, 105, 110, 103, 32, 110, 97, 109, 101, 32, 35, 32, 110, 97,
                                            109, 101, 32, 111, 102, 32, 116, 104, 101, 32, 110, 111, 100, 101, 10, 115,
                                            116, 114, 105, 110, 103, 32, 109, 115, 103, 32, 35, 32, 109, 101, 115, 115,
                                            97, 103, 101, 32, 10, 115, 116, 114, 105, 110, 103, 32, 102, 105, 108, 101,
                                            32, 35, 32, 102, 105, 108, 101, 32, 116, 104, 101, 32, 109, 101, 115, 115,
                                            97, 103, 101, 32, 99, 97, 109, 101, 32, 102, 114, 111, 109, 10, 115, 116,
                                            114, 105, 110, 103, 32, 102, 117, 110, 99, 116, 105, 111, 110, 32, 35, 32,
                                            102, 117, 110, 99, 116, 105, 111, 110, 32, 116, 104, 101, 32, 109, 101, 115,
                                            115, 97, 103, 101, 32, 99, 97, 109, 101, 32, 102, 114, 111, 109, 10, 117,
                                            105, 110, 116, 51, 50, 32, 108, 105, 110, 101, 32, 35, 32, 108, 105, 110,
                                            101, 32, 116, 104, 101, 32, 109, 101, 115, 115, 97, 103, 101, 32, 99, 97,
                                            109, 101, 32, 102, 114, 111, 109, 10, 115, 116, 114, 105, 110, 103, 91, 93,
                                            32, 116, 111, 112, 105, 99, 115, 32, 35, 32, 116, 111, 112, 105, 99, 32, 110
                                            , 97, 109, 101, 115, 32, 116, 104, 97, 116, 32, 116, 104, 101, 32, 110, 111,
                                            100, 101, 32, 112, 117, 98, 108, 105, 115, 104, 101, 115, 10, 10, 61, 61, 61
                                            , 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61
                                            , 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61
                                            , 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61
                                            , 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61
                                            , 61, 10, 77, 83, 71, 58, 32, 115, 116, 100, 95, 109, 115, 103, 115, 47, 72,
                                            101, 97, 100, 101, 114, 10, 35, 32, 83, 116, 97, 110, 100, 97, 114, 100, 32,
                                            109, 101, 116, 97, 100, 97, 116, 97, 32, 102, 111, 114, 32, 104, 105, 103,
                                            104, 101, 114, 45, 108, 101, 118, 101, 108, 32, 115, 116, 97, 109, 112, 101,
                                            100, 32, 100, 97, 116, 97, 32, 116, 121, 112, 101, 115, 46, 10, 35, 32, 84,
                                            104, 105, 115, 32, 105, 115, 32, 103, 101, 110, 101, 114, 97, 108, 108, 121,
                                            32, 117, 115, 101, 100, 32, 116, 111, 32, 99, 111, 109, 109, 117, 110, 105,
                                            99, 97, 116, 101, 32, 116, 105, 109, 101, 115, 116, 97, 109, 112, 101, 100,
                                            32, 100, 97, 116, 97, 32, 10, 35, 32, 105, 110, 32, 97, 32, 112, 97, 114,
                                            116, 105, 99, 117, 108, 97, 114, 32, 99, 111, 111, 114, 100, 105, 110, 97,
                                            116, 101, 32, 102, 114, 97, 109, 101, 46, 10, 35, 32, 10, 35, 32, 115, 101,
                                            113, 117, 101, 110, 99, 101, 32, 73, 68, 58, 32, 99, 111, 110, 115, 101, 99,
                                            117, 116, 105, 118, 101, 108, 121, 32, 105, 110, 99, 114, 101, 97, 115, 105,
                                            110, 103, 32, 73, 68, 32, 10, 117, 105, 110, 116, 51, 50, 32, 115, 101, 113,
                                            10, 35, 84, 119, 111, 45, 105, 110, 116, 101, 103, 101, 114, 32, 116, 105,
                                            109, 101, 115, 116, 97, 109, 112, 32, 116, 104, 97, 116, 32, 105, 115, 32,
                                            101, 120, 112, 114, 101, 115, 115, 101, 100, 32, 97, 115, 58, 10, 35, 32, 42
                                            , 32, 115, 116, 97, 109, 112, 46, 115, 101, 99, 115, 58, 32, 115, 101, 99,
                                            111, 110, 100, 115, 32, 40, 115, 116, 97, 109, 112, 95, 115, 101, 99, 115,
                                            41, 32, 115, 105, 110, 99, 101, 32, 101, 112, 111, 99, 104, 10, 35, 32, 42,
                                            32, 115, 116, 97, 109, 112, 46, 110, 115, 101, 99, 115, 58, 32, 110, 97, 110
                                            , 111, 115, 101, 99, 111, 110, 100, 115, 32, 115, 105, 110, 99, 101, 32, 115
                                            , 116, 97, 109, 112, 95, 115, 101, 99, 115, 10, 35, 32, 116, 105, 109, 101,
                                            45, 104, 97, 110, 100, 108, 105, 110, 103, 32, 115, 117, 103, 97, 114, 32,
                                            105, 115, 32, 112, 114, 111, 118, 105, 100, 101, 100, 32, 98, 121, 32, 116,
                                            104, 101, 32, 99, 108, 105, 101, 110, 116, 32, 108, 105, 98, 114, 97, 114,
                                            121, 10, 116, 105, 109, 101, 32, 115, 116, 97, 109, 112, 10, 35, 70, 114, 97
                                            , 109, 101, 32, 116, 104, 105, 115, 32, 100, 97, 116, 97, 32, 105, 115, 32,
                                            97, 115, 115, 111, 99, 105, 97, 116, 101, 100, 32, 119, 105, 116, 104, 10,
                                            35, 32, 48, 58, 32, 110, 111, 32, 102, 114, 97, 109, 101, 10, 35, 32, 49, 58
                                            , 32, 103, 108, 111, 98, 97, 108, 32, 102, 114, 97, 109, 101, 10, 115, 116,
                                            114, 105, 110, 103, 32, 102, 114, 97, 109, 101, 95, 105, 100, 10, 10, 22, 0,
                                            0, 0, 116, 121, 112, 101, 61, 114, 111, 115, 103, 114, 97, 112, 104, 95, 109
                                            , 115, 103, 115, 47, 76, 111, 103
                                        };*/
    //hton(ref listenerheader);
    /*for (int i = 0; i < listenerheader.Length; i++)
        Console.Write(listenerheader[i] + ",");*/
    //byte[] fuckstainedass = new byte[] {21, 0, 0, 0};
    //WriteThatShit(headershit);
    //WriteThatShit(consoleheader);
    //WriteThatShit(consoleheader2);
    //WriteThatShit(fuckstainedass);
    //WriteThatShit(listenerheader);

    #endregion
}