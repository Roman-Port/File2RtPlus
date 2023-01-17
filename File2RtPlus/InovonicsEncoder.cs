using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace File2RtPlus
{
    public class InovonicsEncoder
    {
        public InovonicsEncoder()
        {
            sock = new Socket(SocketType.Dgram, ProtocolType.Udp);
        }

        private readonly Socket sock;

        public delegate void FinishedEventArgs(bool success);

        public void SendRtPlus(IPEndPoint endpoint, string dps, string rt, RtpTag tag1, RtpTag tag2, FinishedEventArgs callback)
        {
            //Prepare all of the commands
            string commands = $"DPS={dps.Replace("\r", "").Replace("\n", "")}\r\nTEXT={rt.Replace("\r", "").Replace("\n", "")}\r\nRTP={FormatRtpTag(tag1)},{FormatRtpTag(tag2)}\r\nRTPRUN=1\r\nRTPTOG=1\r\n";

            //Encode and send
            byte[] data = Encoding.ASCII.GetBytes(commands);
            sock.BeginSendTo(data, 0, data.Length, SocketFlags.None, endpoint, OnSendFinished, callback);
        }

        private void OnSendFinished(IAsyncResult ar)
        {
            //Finish
            bool success = true;
            try
            {
                sock.EndSendTo(ar);
            } catch
            {
                success = false;
            }

            //Fire callback
            ((FinishedEventArgs)ar.AsyncState)?.Invoke(success);
        }

        private static string FormatRtpTag(RtpTag tag)
        {
            return tag.Type.ToString("00") + "," + tag.Start.ToString("00") + "," + tag.Length.ToString("00");
        }
    }
}
