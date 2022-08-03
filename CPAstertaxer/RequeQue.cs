using System;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

namespace CPAstertaxer
{
    public class AMIDelete
    {
        public void AMIdel(string server, string DataNum)
        {
        //Console.WriteLine("Quick and Dirty Asterisk Manager Daemon Test:\n");
        // Connect to the asterisk server.
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.69"), 5038);
        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(server), 5038);
        clientSocket.Connect(serverEndPoint);

        // Login to the server; manager.conf needs to be setup with matching credentials.
        clientSocket.Send(Encoding.ASCII.GetBytes("Action: Login\r\nUsername: root\r\nSecret: taxer\r\nActionID: 1\r\n\r\n"));

        int bytesRead = 0;

            do
            {
                byte[] buffer = new byte[1024];
                bytesRead = clientSocket.Receive(buffer);

                //Console.WriteLine(bytesRead + " bytes from asterisk server.");

                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                //Console.WriteLine(response);

                if (Regex.Match(response, "Message: Authentication accepted", RegexOptions.IgnoreCase).Success)
                {
                    // Send a ping request the asterisk server will send back a pong response.
                    //clientSocket.Send(Encoding.ASCII.GetBytes("Action: Ping\r\nActionID: 2\r\n\r\n"));
                    clientSocket.Send(Encoding.ASCII.GetBytes("Action: QueueRemove\r\nQueue: queuetax\r\nInterface: Dongle/dongle1/" + DataNum + "\r\n\r\n"));

                    //bytesRead = 0;
                    bytesRead = clientSocket.Receive(buffer);
                    string response2 = Encoding.ASCII.GetString(buffer, 0, bytesRead); //Message: Added interface to queue(Message: Unable to add interface)

                    if (Regex.Match(response2, "Message: Removed interface from queue", RegexOptions.IgnoreCase).Success)
                    MessageBox.Show("Tелефон таксиста " + DataNum + " удален из очереди");
                    bytesRead = 0;
                }
            } 
            while(bytesRead != 0);
            //Console.WriteLine("Connection to server lost.");
            //Console.ReadLine();
            clientSocket.Close();
        }
    }
}