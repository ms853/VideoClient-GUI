using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace VideoClientDevelopment
{
    public partial class Form1 : Form
    {
        //Tcp client object that will be used as a socket to connect to the server.
        TcpClient client = new TcpClient();
        static Form1 form1 = new Form1(); //Instance of the first form, which will be used for navigation.

        public static List<IPCamera> frameInfo = new List<IPCamera>();

        public static IPCamera camera;


        public Form1()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //Helper function to check the connection status of the client
        private bool IsConnected(TcpClient tcpClient)
        {
            if (tcpClient.Connected == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Old method! I have implemented this method within the ReadData method
        private static string[] ReadIPHeader(NetworkStream ns)
        {
            int buffer = 0;
            string bufferString = "";
           // string decodedData = null;
           // byte[] iPByteBuffer = null;
            string[] iPHeaderArr = null;

            try
            {
                while ((buffer = ns.ReadByte()) != -1)
                {
                    char tempChar = (char)buffer;
                    //bufferString += tempChar;
                    switch (tempChar)
                    {
                        case ']':
                            continue;
                            //break;
                        default:
                            bufferString += tempChar;
                            break;
                    }
                   
                }
                string formattedStr = bufferString.Replace('[', ' ');
                iPHeaderArr = formattedStr.Split('|');
            }
            catch (Exception)
            {

                throw;
            }
            //Work with the string array and return it.
            return iPHeaderArr;
        }

        //https://stackoverflow.com/questions/1080442/how-to-convert-an-stream-into-a-byte-in-c
  
        //Method for reading data from the server
        private static void ReadData(TcpClient tcpClient)
        {
            IPCamera camera; //A camera class I wrote to hold a camera information.
            String decodedData = null; //storing the decoded response from the server
            byte[] tempJPEGArray = null;
            string[] ipArr = null; //temp array
            int sizeOfPayload = 0;
            string bufferString = "";
            

            try
            {
               
                //Create stream
                NetworkStream stream = tcpClient.GetStream();
                //check if client is connected 
                if (form1.IsConnected(tcpClient))
                {
                    int buffer = 0; //buffer to temp keep track for every byte read.
                    //While loop to ensure every byte is read until the end of the stream. 
                    while ((buffer = stream.ReadByte()) != -1)
                    {
                        char tempChar = (char)buffer;
                        //bufferString += tempChar;
                        switch (tempChar)
                        {
                            case '[':
                                continue; //skip character
                            case ']':
                                //Get the array for the temp IP header and the size of the jpeg
                                ipArr = bufferString.Replace(']',' ').Split('|');
                                sizeOfPayload = Convert.ToInt32(ipArr[6]);
                                //Create a new camera object and set the following properties of the camera object. 
                                camera = new IPCamera
                                {
                                    CameraName = ipArr[2],
                                    Width = Convert.ToInt32(ipArr[3]),
                                    Height =Convert.ToInt32(ipArr[4])
                                };
                                //set the size of the array to the temporary byte array
                                tempJPEGArray = new byte[sizeOfPayload];
                                tempJPEGArray = ReadPayload(tempJPEGArray, stream); //Load the corresponding image
                                decodedData = UTF8Encoding.ASCII.GetString(tempJPEGArray); //decode the data
                                DisplayImage(camera, tempJPEGArray); //Load image
                                break;
                            default:
                                bufferString += tempChar;
                                break;
                        }
                        
                    }

                }
                else
                {
                    stream.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong \n\n" + ex.Message);
                tcpClient.Close();
            }
        }

        //Method for displaying the image for the video stream
        private static void DisplayImage(IPCamera iPCamera, byte[] payload)
        {
            Image image = null;
            int xSize, ySize; //width and height of the image.
            
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    if (!image.Equals(null))
                    {
                        image.Dispose();
                    }
                    ms.Write(payload, 0, payload.Length);
                    //ms.Read(payload, 0, payload.Length);
                    image = Image.FromStream(ms);

                    Label cameraText = new Label(); //label to display the name of the camera.
                    //Set image properties
                    xSize = camera.Width;
                    ySize = camera.Height;
                    cameraText.Text = camera.CameraName;
                    // Stretches the image to fit the pictureBox.
                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.ClientSize = new Size(xSize, ySize);
                    pictureBox1.Image = image;
                   
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error", "\n" + ex.Message);
            }
        }

        private static byte[] ReadPayload(byte[] tempArray, NetworkStream stream)
        {
            int buffer = 0;
            int totalBytesRead = 0;
            string bufferStr = String.Empty;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    while ((buffer = stream.Read(tempArray, 0, tempArray.Length - totalBytesRead)) != 0)
                    {
                        //totalBytesRead += buffer;
                        char c = (char)buffer;
                        //bufferStr += c;
                        switch (c)
                        {
                            case '[':
                                break;
                            case ']':
                                continue;
                            default:
                                totalBytesRead += buffer;
                                break;
                        }

                        if (totalBytesRead == tempArray.Length) break;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Unable to complete operation due to:\n" + ex.Message);
            }
            return tempArray;
        }

        private static string LoadPayload(byte[] dataReceived, NetworkStream networkStream)
        {
            string to_return = null;
            //string str = null;
            try
            {
                int buffer = 0;
                while((buffer = networkStream.Read(dataReceived, 0, dataReceived.Length)) != -1)
                {
                    to_return = Encoding.ASCII.GetString(dataReceived, 0, buffer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", ex.Message);
            }
            //str = Encoding.ASCII.GetString(ms.ToArray(), 0, (int)ms.Length);
            return to_return;
        }

        private static byte[] ReadJPEGPayload(byte[] dataFromBuffer, NetworkStream stream)
        {
            //Read bytes for the payload
            int buffer = 0;
            int totalBytesRead = 0;
            while ((buffer = stream.Read(dataFromBuffer, totalBytesRead, dataFromBuffer.Length - totalBytesRead)) > 0)
            {
                totalBytesRead += buffer;

                if (totalBytesRead == dataFromBuffer.Length)
                {
                    int nextByte = stream.ReadByte();
                    char c = (char)nextByte;
                    if (nextByte != -1) //when the end of the stream hasn't been reached
                    {
                        //create a temp byte array with the length twice the size
                        byte[] temp = new byte[dataFromBuffer.Length * 2];
                        //Call BlockCopy function to copy the number of bytes from start to the destination offset both being zero.
                        Buffer.BlockCopy(dataFromBuffer, 0, temp, 0, dataFromBuffer.Length);
                        Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                        dataFromBuffer = temp;
                        totalBytesRead++;
                    }
                }
            }

            byte[] buffer_to_return = dataFromBuffer;
            if (dataFromBuffer.Length != totalBytesRead)
            {
                buffer_to_return = new byte[totalBytesRead];
                Buffer.BlockCopy(dataFromBuffer, 0, buffer_to_return, 0, totalBytesRead);
            }    
            return dataFromBuffer;
        }

        //Event method for allowing the user to connect.
        private void OnConnectButton_Click(object sender, EventArgs e)
        {

            String address = iPTextBox.Text;
            Int32 port = Int32.Parse(portTextBox.Text);
            
            try
            {
                //Attempting to connect to the server with the given IP address and port.
                client.Connect(address, port);
                //Clear Textboxes
                iPTextBox.Clear();
                portTextBox.Clear();
                MessageBox.Show("Successfully connected to Moose Server!");
                //Read data 
                ReadData(client);

            } catch (SocketException se)
            {
                //Clear Textboxes
                iPTextBox.Clear();
                portTextBox.Clear();
                MessageBox.Show(se.Message);
            }
        }

    }
}
