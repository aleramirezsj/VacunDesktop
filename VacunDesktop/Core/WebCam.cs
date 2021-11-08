using System;
using System.Collections.Generic;
using System.Text;
using OpenCvSharp;
using System.Drawing;
using System.Threading;
using OpenCvSharp.Extensions;
using System.Windows.Forms;

namespace VacunDesktop.Core
{
    public class WebCam
    {
        /// <summary>
        /// Initalizes camera feed
        /// </summary>
        /// <param name="AutoActivate">If set to false this disables the camera from starting, you must call the Initalize method.</param>
        ///
        Form formularioContenedor;
        PictureBox pictureBox1;

        public WebCam(Form formulario, bool AutoActivate = true, PictureBox pictureBox=null)
        {
            if (AutoActivate)
            {
                Initalize();
            }
            pictureBox1 = pictureBox;
            formularioContenedor = formulario;
            formularioContenedor.FormClosing += (s, a) =>
            {
                Deinitalize();
            };
        }


        // Create class-level accesible variables
        static VideoCapture capture;
        static Mat frame;
        static Bitmap image;
        private static Thread camera;
        private static bool isCameraRunning = false;
        private bool imagetakinginprogress = false;

        /// <summary>
        /// Starts the camera feed
        /// </summary>
        public void Initalize()
        {
            CaptureCamera();
            isCameraRunning = true;
        }

        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.IsBackground = true;
            
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            try
            {
                if (!isCameraRunning)
                {
                    return;
                }
                frame = new Mat();
                capture = new VideoCapture(0);
                capture.Open(0);

                if (capture.IsOpened())
                {
                    while (isCameraRunning)
                    {

                        capture.Read(frame);
                        image = BitmapConverter.ToBitmap(frame);
                        pictureBox1.Image = image;
                        image = null;
                    }
                }
            }
            catch
            {
                //
            }
        }

        /// <summary>
        /// Gets a bitmap from the camera
        /// </summary>
        /// <returns>Bitmap image from camera</returns>
        public Bitmap GetBitmap()
        {
            if (isCameraRunning)
            {
                if (image != null)
                {
                    while (imagetakinginprogress) { }
                    try
                    {
                        return new Bitmap(image);
                    }
                    catch
                    {
                        return new Bitmap(image);
                    }
                }
                else
                    return null;
            }
            else
                throw new Exception("Cannot take picutre if the camera is not initalized!");
        }

        /// <summary>
        /// Deinitalizes the camera. Can be reinitalized.
        /// </summary>
        public void Deinitalize()
        {
            //camera.;
            if (isCameraRunning)
            {
                isCameraRunning = false;
                camera.Interrupt();
                camera.Join();
                //camera.j
                capture.Dispose();
                frame.Dispose();
            }

            //frame.Dispose();
            //image.Dispose();

        }

        /// <summary>
        /// Destroys the camera
        /// </summary>
        ~WebCam()
        {
            Deinitalize();
            capture.Dispose();
            frame.Dispose();
            //image.Dispose();
        }
    }

}
