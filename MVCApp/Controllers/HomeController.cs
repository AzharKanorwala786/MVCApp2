using MVCApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase CustomerImage, HttpPostedFileBase VerificationDocument)
        {
            //using DB to store 
            using (var db = new CustomerVerificationContext())
            {
                //variables to store in DB
                var customerImage = String.Empty;
                var documentImage = String.Empty;

                int permittedSizeInBytes = 40000;//4mb

                //respective directories to seprate photos and documents snapshots
                string customerImageDir = Server.MapPath("~/Uploads/Photos");
                string documetnImageDir = Server.MapPath("~/Uploads/Documents");

                //creating directories
                if (!Directory.Exists(customerImageDir))
                {
                    Directory.CreateDirectory(customerImageDir);
                }
                if (!Directory.Exists(documetnImageDir))
                {
                    Directory.CreateDirectory(documetnImageDir);
                }
             
                if (CustomerImage != null)
                {
                    if (CustomerImage.ContentLength < permittedSizeInBytes)
                    {
                        Resize(CustomerImage);
                        ViewBag.Message = "File cannot be more than 4MB";
                    }

                   string fileExtension = Path.GetExtension(CustomerImage.FileName);
                   Guid fileGuid = Guid.NewGuid();
                   //uploading file to respective directory
                   var path = Path.Combine(customerImageDir, fileGuid.ToString() + fileExtension);
                   CustomerImage.SaveAs(path);
                   //store in db
                   customerImage = fileGuid.ToString() + fileExtension;
                   ViewBag.Message = "Image uploaded successfully.";
                }

                if (VerificationDocument != null)
                {
                    if (VerificationDocument.ContentLength < permittedSizeInBytes)
                    {
                        Resize(VerificationDocument);
                        ViewBag.Message = "File cannot be more than 4MB";
                    }

                    string fileExtension = Path.GetExtension(VerificationDocument.FileName);
                    Guid fileGuid = Guid.NewGuid();
                    //uploading file to respective directory
                    var path = Path.Combine(documetnImageDir,fileGuid.ToString() + fileExtension);
                    VerificationDocument.SaveAs(path);
                    //store in db
                    documentImage = fileGuid.ToString() + fileExtension;
                    ViewBag.Message = "Document uploaded successfully.";                 
                }
                //saving changes to db
                var saveToDb = new verification() { Photo = customerImage, C_Document = documentImage };
                db.verification.Add(saveToDb);
                db.SaveChanges();
                var result = GetResult(customerImage, documentImage);
                return View();
            }
        }

        public bool GetResult(string customerImage,string documentImage)
        {
            var URL = "http://52.173.93.94/FaceDetectionService/";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                var uri = String.Concat("api/Face/CompareFacialIdentity?faceImage=" + customerImage + "&documentImage=" + documentImage); 
                var postTask = client.GetAsync(uri);
                postTask.Wait();

                var result = postTask.Result;
            }

            return true;
        }

        protected void Resize(HttpPostedFileBase file)
        {
            Bitmap bitmap = new Bitmap(file.FileName);
            int iwidth = bitmap.Width;
            int iheight = bitmap.Height;
            bitmap.Dispose();

            Image objOptImage = new Bitmap(iwidth, iheight, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);

            using (System.Drawing.Image objImg = Image.FromFile(file.FileName))
            {
                // RE-DRAW THE IMAGE USING THE NEWLY OBTAINED PIXEL FORMAT.
                using (System.Drawing.Graphics oGraphic = System.Drawing.Graphics.FromImage(objOptImage))
                {
                    var _1 = oGraphic;
                    System.Drawing.Rectangle oRectangle = new System.Drawing.Rectangle(0, 0, iwidth, iheight);

                    _1.DrawImage(objImg, oRectangle);
                }

                objOptImage.Save(file.FileName,System.Drawing.Imaging.ImageFormat.Png);

                objImg.Dispose();
            }

            // FINALLY SHOW THE OPTIMIZED IMAGE DETAILS WITH SIZE.
            Bitmap bitmap_Opt = new Bitmap(file.FileName);

            int iwidth_Opt = bitmap_Opt.Width;
            int iheight_Opt = bitmap_Opt.Height;
            bitmap_Opt.Dispose();

            // FOR SIZE.
            FileInfo OptImgInfo = new FileInfo(file.FileName);
            long lFileSize = OptImgInfo.Length;   // GET THE SIZE IN BYTE
        }

        public void CalculateTransactions()
        {
            var transactions = GetTransactions.RetreiveTransactions();
            var creditTransactions = transactions.Where(x => x.CreditDebitIndicator == Models.TransactionType.Credit);
            var sumofCredit = creditTransactions.Sum(x => Convert.ToDouble(x.Amount.Amount));
            var averageCredit = sumofCredit / 6;
            var debitTransactions = transactions.Where(x => x.CreditDebitIndicator == Models.TransactionType.Debit);
            var sumofDebit = debitTransactions.Sum(x => Convert.ToDouble(x.Amount.Amount));
            var balance = sumofCredit - sumofDebit;
            var averageSavings = balance / 6;
            Calculation(averageCredit, averageSavings);

        }

        public bool Calculation(double averageCredit,double averageSavings)
        {
            //Assumptions 
            var propertyMortgageAmount = 100000;
            var maxLoan = (propertyMortgageAmount / 60) * 100;
            var termofLoan = 5;
            var GetInMonths = termofLoan * 12;
            var canBeGiven = 0.00;
            if (averageSavings >= 500)
            {
                canBeGiven = averageSavings * GetInMonths;
            }
            else
            {
                canBeGiven = (averageCredit / 40) * 100; 
            }
            //var canBeGiven = getEligibility * GetInMonths;
            if(propertyMortgageAmount < canBeGiven)
            {
                return true;
            }
            return false;
        }

        public double EMICalculator()
        {
            double LoanAmount = 0;
            double Payment = 0;
            double InterestRate = 0;
            int PaymentPeriods = 0;
            try { 
                if (InterestRate > 1)
                {
                    InterestRate = InterestRate / 100;
                }
                Payment = (LoanAmount * Math.Pow((InterestRate / 12) + 1,
                          (PaymentPeriods)) * InterestRate / 12) / (Math.Pow
                          (InterestRate / 12 + 1, (PaymentPeriods)) - 1);
            }
            catch
            {
            }
            return Payment;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}