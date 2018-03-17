using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace MVCApp.Controllers
{
    public class PhotoResizer
    {
        //protected void Resize(object sender, EventArgs e)
        //{
        //    // GET THE UPLOADED FILE.
        //    HttpFileCollection hfc = Request.Files;

        //    if (hfc.Count > 0)
        //    {
        //        HttpPostedFile hpf = hfc[0];

        //        if (hpf.ContentLength > 0)
        //        {
        //            string sImageName = hpf.FileName;

        //            // FIRST SAVE THE FILE ON THE SERVER.
        //            //hpf.SaveAs(Server.MapPath("~/" + Path.GetFileName(sImageName)));

        //            // ORIGINAL WIDTH AND HEIGHT.
        //            Bitmap bitmap = new Bitmap(Server.MapPath("~/" + Path.GetFileName(hpf.FileName)));

        //            int iwidth = bitmap.Width;
        //            int iheight = bitmap.Height;
        //            bitmap.Dispose();

        //            // ONCE WE GOT ALL THE INFORMATION, WE'll NOW PROCESS IT.

        //            // CREATE AN IMAGE OBJECT USING ORIGINAL WIDTH AND HEIGHT.
        //            // ALSO DEFINE A PIXEL FORMAT (FOR RICH RGB COLOR).

        //            Image objOptImage = new Bitmap(iwidth, iheight, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);

        //            // GET THE ORIGINAL IMAGE.
        //            using (System.Drawing.Image objImg = Image.FromFile(HttpContext.Current.Server.MapPath("~/" + sImageName)))
        //            {

        //                // RE-DRAW THE IMAGE USING THE NEWLY OBTAINED PIXEL FORMAT.
        //                using (System.Drawing.Graphics oGraphic = System.Drawing.Graphics.FromImage(objOptImage))
        //                {
        //                    var _1 = oGraphic;
        //                    System.Drawing.Rectangle oRectangle = new System.Drawing.Rectangle(0, 0, iwidth, iheight);

        //                    _1.DrawImage(objImg, oRectangle);
        //                }

        //                // SAVE THE OPTIMIZED IMAGE.
        //                objOptImage.Save(HttpContext.Current.Server.MapPath("~/images/" + sImageName),System.Drawing.Imaging.ImageFormat.Png);

        //                objImg.Dispose();
        //            }

        //            objOptImage.Dispose();

        //            // FINALLY SHOW THE OPTIMIZED IMAGE DETAILS WITH SIZE.
        //            Bitmap bitmap_Opt = new Bitmap(Server.MapPath("~/images/" + Path.GetFileName(sImageName)));

        //            int iwidth_Opt = bitmap_Opt.Width;
        //            int iheight_Opt = bitmap_Opt.Height;
        //            bitmap_Opt.Dispose();

        //            // FOR SIZE.
        //            FileInfo OptImgInfo = new FileInfo(Server.MapPath("~/images/" + Path.GetFileName(sImageName)));
        //            long lFileSize = OptImgInfo.Length;   // GET THE SIZE IN BYTES.
        //        }
        //    }
        //}
    }
}