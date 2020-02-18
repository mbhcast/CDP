using CDP.Core.Logs;
using CDP.Service.Logs;
using CDP_Dev.PdfProvider.DataModel;
using Microsoft.AspNetCore.Authorization;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using System;
using System.IO;
using System.Linq;

namespace CDP_Dev.PdfProvider
{
    [Authorize]
    public class PdfSharpService : IPdfSharpService
    {
        private string _createdDocsPath = ".\\PdfProvider\\Created";
        private string _imagesPath = ".\\PdfProvider\\Images";
        private string _resourcesPath = ".\\PdfProvider\\Resources";
        int startingHeight = 50;
        int leftMargin = 40;
        ILog _ILog;
        public PdfSharpService( ILog log)
        {
            _ILog = log;
        }
        //int listItemHeight = 20;
        public string CreatePdf(PdfData pdfData)
        {
            Log l = new Log();
            try
            {
                if (GlobalFontSettings.FontResolver == null)
                {
                    GlobalFontSettings.FontResolver = new FontResolver(_resourcesPath);
                }

                var document = new PdfDocument();
                var page = document.AddPage();
                var gfx = XGraphics.FromPdfPage(page);

                AddTitleLogo(gfx, page, $"{_imagesPath}\\logo.png", 10, 10);

                AddTitleAndFooter(page, gfx, pdfData.DocumentTitle, document, pdfData);
                //AddDescription(gfx, pdfData);
                l.CreatedOn = System.DateTime.UtcNow;
                l.ShortDescription = "Adding User Detail";
                l.FullDescription = "AAdding User Detail";
                _ILog.InsertLog(l);

                AddUserDetails(gfx, pdfData);
                if (pdfData.Aspiration.Count > 0)
                {
                    AddAspiration(gfx, pdfData);
                }
                if (pdfData.Training.Count > 0)
                {
                    AddTraining(gfx, pdfData);
                }
                //AddList(gfx, pdfData);
                if (pdfData.Mentor.Count > 0)
                {
                    AddMentor(gfx, pdfData);
                }
                if (pdfData.Allocation.Count > 0)
                {
                    AddAllocation(gfx, pdfData);
                }
                if (pdfData.IInternal.Count > 0)
                {
                    AddInternal(gfx, pdfData);
                }


                //l.CreatedOn = System.DateTime.UtcNow;
                //l.ShortDescription = "Creating docname";
                //l.FullDescription = "Creating docname";
                //_ILog.InsertLog(l);

                string docName = $"{_createdDocsPath}/{pdfData.DocumentName + "-" + pdfData.User.Name}-{DateTime.UtcNow.ToOADate()}.pdf";
                //string docName = $"{_createdDocsPath}/{pdfData.DocumentName + "-" + pdfData.User.Name}.pdf";
                document.Save(docName);
                return docName;
            }
            catch(Exception ex)
            {
                l.CreatedOn = System.DateTime.UtcNow;
                l.ShortDescription = ex.Message;
                l.FullDescription = ex.InnerException.ToString();
                _ILog.InsertLog(l);
                throw ex;
            }
        }

        void AddTitleLogo(XGraphics gfx, PdfPage page, string imagePath, int xPosition, int yPosition)
        {
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException(String.Format("Could not find image {0}.", imagePath));
            }

            XImage xImage = XImage.FromFile(imagePath);
            gfx.DrawImage(xImage, xPosition, yPosition, xImage.PixelWidth / 4, xImage.PixelHeight / 4);
        }

        void AddTitleAndFooter(PdfPage page, XGraphics gfx, string title, PdfDocument document, PdfData pdfData)
        {
            Log l = new Log();
            try
            {

                XRect rect = new XRect(new XPoint(), gfx.PageSize);
                rect.Inflate(-10, -15);
                XFont font = new XFont("OpenSans", 14, XFontStyle.Bold);
                gfx.DrawString(title, font, XBrushes.MidnightBlue, rect, XStringFormats.TopCenter);



                rect.Offset(0, 5);
                font = new XFont("OpenSans", 8, XFontStyle.Italic);
                XStringFormat format = new XStringFormat();
                format.Alignment = XStringAlignment.Near;
                format.LineAlignment = XLineAlignment.Far;
                gfx.DrawString(pdfData.CreatedBy, font, XBrushes.Black, rect, format);

                font = new XFont("OpenSans", 8);
                format.Alignment = XStringAlignment.Center;
                gfx.DrawString(document.PageCount.ToString(), font, XBrushes.DarkOrchid, rect, format);

                document.Outlines.Add(title, page, true);
            }
            catch(Exception ex)
            {
                l.CreatedOn = System.DateTime.UtcNow;
                l.ShortDescription = ex.Message;
                l.FullDescription = ex.InnerException.ToString();
                _ILog.InsertLog(l);
                throw ex;
            }
        }

        void AddDescription(XGraphics gfx, PdfData pdfData)
        {
            int ItemHeight = 20;
            var font = new XFont("OpenSans", 14, XFontStyle.Regular);
            XTextFormatter tf = new XTextFormatter(gfx);
            XRect rect = new XRect(40, startingHeight, 520, ItemHeight);
            gfx.DrawRectangle(XBrushes.White, rect);
            tf.DrawString(pdfData.Description, font, XBrushes.Black, rect, XStringFormats.TopLeft);
            startingHeight = startingHeight + ItemHeight;
        }

        void AddList(XGraphics gfx, PdfData pdfData)
        {
            int startingHeight = 200;
            int listItemHeight = 30;

            for (int i = 0; i < pdfData.DisplayListItems.Count; i++)
            {
                var font = new XFont("OpenSans", 14, XFontStyle.Regular);
                XTextFormatter tf = new XTextFormatter(gfx);
                XRect rect = new XRect(60, startingHeight, 500, listItemHeight);
                gfx.DrawRectangle(XBrushes.White, rect);
                var data = $"{i}. {pdfData.DisplayListItems[i].Id} | {pdfData.DisplayListItems[i].Data1} | {pdfData.DisplayListItems[i].Data2}";
                tf.DrawString(data, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                startingHeight = startingHeight + listItemHeight;
            }
        }
        void AddUserDetails(XGraphics gfx, PdfData pdfData)
        {
            //int startingHeight = 135;
            int ItemHeight = 20;

            var fontTitle = new XFont("OpenSans", 10, XFontStyle.Bold);
            XTextFormatter tfTitle = new XTextFormatter(gfx);
            XRect rectTitle = new XRect(leftMargin - 10, startingHeight, 100, ItemHeight);
            gfx.DrawRectangle(XBrushes.White, rectTitle);
            tfTitle.DrawString("Employee Detail", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
            startingHeight = startingHeight + ItemHeight;

            int xMargin = 0;

            XRect rectTitle1 = new XRect(xMargin + leftMargin, startingHeight, 125, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle1);
            tfTitle.DrawString("  " + "Name", fontTitle, XBrushes.White, rectTitle1, XStringFormats.TopLeft);
            xMargin = 126;

            XRect rectTitle2 = new XRect(xMargin + leftMargin, startingHeight, 125, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle2);
            tfTitle.DrawString("  " + "Trigram", fontTitle, XBrushes.White, rectTitle2, XStringFormats.TopLeft);
            xMargin = 252;

            XRect rectTitle3 = new XRect(xMargin + leftMargin, startingHeight, 125, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle3);
            tfTitle.DrawString("  " + "Manager", fontTitle, XBrushes.White, rectTitle3, XStringFormats.TopLeft);
            xMargin = 378;

            XRect rectTitle4 = new XRect(xMargin + leftMargin, startingHeight, 125, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle4);
            tfTitle.DrawString("  " + "Manager Trigram", fontTitle, XBrushes.White, rectTitle4, XStringFormats.TopLeft);
            xMargin = 501;

            startingHeight = startingHeight + ItemHeight + 1;

            var font = new XFont("OpenSans", 10, XFontStyle.Regular);
            XTextFormatter tf = new XTextFormatter(gfx);

            XRect rect1 = new XRect(leftMargin, startingHeight, 125, ItemHeight);
            gfx.DrawRectangle(XBrushes.AliceBlue, rect1);
            var data1 = $"{"  " + pdfData.User.Name}";
            tf.DrawString(data1, font, XBrushes.Black, rect1, XStringFormats.TopLeft);

            XRect rect2 = new XRect(126 + leftMargin, startingHeight, 125, ItemHeight);
            gfx.DrawRectangle(XBrushes.AliceBlue, rect2);
            var data2 = $"{"  " + pdfData.User.Trigram}";
            tf.DrawString(data2, font, XBrushes.Black, rect2, XStringFormats.TopLeft);

            XRect rect3 = new XRect(252 + leftMargin, startingHeight, 125, ItemHeight);
            gfx.DrawRectangle(XBrushes.AliceBlue, rect3);
            var data3 = $"{"  " + pdfData.User.Manager}";
            tf.DrawString(data3, font, XBrushes.Black, rect3, XStringFormats.TopLeft);

            XRect rect4 = new XRect(378 + leftMargin, startingHeight, 125, ItemHeight);
            gfx.DrawRectangle(XBrushes.AliceBlue, rect4);
            var data4 = $"{"  " + pdfData.User.ManagerTrigram}";
            tf.DrawString(data4, font, XBrushes.Black, rect4, XStringFormats.TopLeft);

            startingHeight = startingHeight + ItemHeight + 5;
        }
        //void AddUserDetails(XGraphics gfx, PdfData pdfData)
        //{
        //    //int startingHeight = 135;
        //    int ItemHeight = 20;

        //    var fontTitle = new XFont("OpenSans", 11, XFontStyle.Bold);
        //    XTextFormatter tfTitle = new XTextFormatter(gfx);
        //    XRect rectTitle = new XRect(60, startingHeight, 100, ItemHeight);
        //    gfx.DrawRectangle(XBrushes.White, rectTitle);
        //    tfTitle.DrawString("User Details", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
        //    startingHeight = startingHeight + ItemHeight;

        //        var font = new XFont("OpenSans", 11, XFontStyle.Regular);
        //        XTextFormatter tf = new XTextFormatter(gfx);
        //        XRect rect = new XRect(60, startingHeight, 500, ItemHeight);
        //        gfx.DrawRectangle(XBrushes.White, rect);
        //        var data = $"{pdfData.User.Name} | {pdfData.User.Trigram} | {pdfData.User.Manager} | {pdfData.User.ManagerTrigram}";
        //        tf.DrawString(data, font, XBrushes.Black, rect, XStringFormats.TopLeft);

        //        startingHeight = startingHeight + ItemHeight;
        //}
        void AddTraining(XGraphics gfx, PdfData pdfData)
        {
            //int startingHeight = 135;
            int ItemHeight = 20;

            var fontTitle = new XFont("OpenSans", 11, XFontStyle.Bold);
            XTextFormatter tfTitle = new XTextFormatter(gfx);
            XRect rectTitle = new XRect(leftMargin - 10, startingHeight, 100, ItemHeight);
            gfx.DrawRectangle(XBrushes.White, rectTitle);
            tfTitle.DrawString("Enablement", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
            startingHeight = startingHeight + ItemHeight;

            var primary = pdfData.Training.AsEnumerable().Where(a => a.IsPrimary == true).OrderBy(a => a.TrainingCategory);
            var secondary = pdfData.Training.AsEnumerable().Where(a => a.IsPrimary == false);

            if (primary.Count() > 0)
            {
                var fontTitlePrimary = new XFont("OpenSans", 10.5, XFontStyle.Bold);
                XTextFormatter tfTitlePrimary = new XTextFormatter(gfx);
                XRect rectTitlePrimary = new XRect(leftMargin + 20, startingHeight, 100, ItemHeight);
                gfx.DrawRectangle(XBrushes.White, rectTitlePrimary);
                tfTitle.DrawString("Primary Skills", fontTitlePrimary, XBrushes.Black, rectTitlePrimary, XStringFormats.TopLeft);
                startingHeight = startingHeight + ItemHeight;

                var groups = primary.GroupBy(a => a.TrainingCategory);
                foreach (var group in groups)
                {
                    var fontTitleGroup = new XFont("OpenSans", 10, XFontStyle.Bold);
                    XTextFormatter tfTitleGroup = new XTextFormatter(gfx);
                    XRect rectTitleGroup = new XRect(leftMargin + 40, startingHeight, 150, ItemHeight);
                    gfx.DrawRectangle(XBrushes.White, rectTitleGroup);
                    tfTitleGroup.DrawString(group.Key, fontTitleGroup, XBrushes.Black, rectTitleGroup, XStringFormats.TopLeft);
                    startingHeight = startingHeight + ItemHeight;

                    foreach (var v in group)
                    {
                        var fontTitlev = new XFont("OpenSans", 9, XFontStyle.Regular);
                        XTextFormatter tfTitlev = new XTextFormatter(gfx);
                        XRect rectTitlev = new XRect(leftMargin + 60, startingHeight, 250, ItemHeight);
                        gfx.DrawRectangle(XBrushes.White, rectTitlev);
                        tfTitlev.DrawString(v.TrainingCode + " - " + v.Training, fontTitlev, XBrushes.Black, rectTitlev, XStringFormats.TopLeft);
                        startingHeight = startingHeight + ItemHeight;
                    }
                }
                //foreach(var v in primary)
                //{
                //    var font = new XFont("OpenSans", 11, XFontStyle.Regular);
                //    XTextFormatter tf = new XTextFormatter(gfx);
                //    XRect rect = new XRect(100, startingHeight, 500, ItemHeight);
                //    gfx.DrawRectangle(XBrushes.White, rect);
                //    var data = $"{v.Training} | {v.TrainingCategory}";
                //    tf.DrawString(data, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                //    startingHeight = startingHeight + ItemHeight;
                //}
            }
            if (secondary.Count() > 0)
            {
                var fontTitleSecondary = new XFont("OpenSans", 10.5, XFontStyle.Bold);
                XTextFormatter tfTitleSecondary = new XTextFormatter(gfx);
                XRect rectTitleSecondary = new XRect(leftMargin + 20, startingHeight, 100, ItemHeight);
                gfx.DrawRectangle(XBrushes.White, rectTitleSecondary);
                tfTitle.DrawString("Secondary Skills", fontTitleSecondary, XBrushes.Black, rectTitleSecondary, XStringFormats.TopLeft);
                startingHeight = startingHeight + ItemHeight;

                var groups = secondary.GroupBy(a => a.TrainingCategory);
                foreach (var group in groups)
                {
                    var fontTitleGroup = new XFont("OpenSans", 10, XFontStyle.Bold);
                    XTextFormatter tfTitleGroup = new XTextFormatter(gfx);
                    XRect rectTitleGroup = new XRect(leftMargin + 40, startingHeight, 150, ItemHeight);
                    gfx.DrawRectangle(XBrushes.White, rectTitleGroup);
                    tfTitleGroup.DrawString(group.Key, fontTitleGroup, XBrushes.Black, rectTitleGroup, XStringFormats.TopLeft);
                    startingHeight = startingHeight + ItemHeight;

                    foreach (var v in group)
                    {
                        var fontTitlev = new XFont("OpenSans", 9, XFontStyle.Regular);
                        XTextFormatter tfTitlev = new XTextFormatter(gfx);
                        XRect rectTitlev = new XRect(leftMargin + 60, startingHeight, 250, ItemHeight);
                        gfx.DrawRectangle(XBrushes.White, rectTitlev);
                        tfTitlev.DrawString(v.TrainingCode + " - " + v.Training, fontTitlev, XBrushes.Black, rectTitlev, XStringFormats.TopLeft);
                        startingHeight = startingHeight + ItemHeight;
                    }
                }
                //foreach (var v in secondary)
                //{
                //    var font = new XFont("OpenSans", 11, XFontStyle.Regular);
                //    XTextFormatter tf = new XTextFormatter(gfx);
                //    XRect rect = new XRect(100, startingHeight, 500, ItemHeight);
                //    gfx.DrawRectangle(XBrushes.White, rect);
                //    var data = $"{v.Training} | {v.TrainingCategory}";
                //    tf.DrawString(data, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                //    startingHeight = startingHeight + ItemHeight;
                //}
            }
        }
        void AddAspiration(XGraphics gfx, PdfData pdfData)
        {
            int ItemHeight = 20;

            var fontTitle = new XFont("OpenSans", 10, XFontStyle.Bold);
            XTextFormatter tfTitle = new XTextFormatter(gfx);
            XRect rectTitle = new XRect(leftMargin - 10, startingHeight, 100, ItemHeight);
            gfx.DrawRectangle(XBrushes.White, rectTitle);
            tfTitle.DrawString("Aspiration", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
            startingHeight = startingHeight + ItemHeight;

            int xMargin = 0;

            XRect rectTitle1 = new XRect(xMargin + leftMargin, startingHeight, 500, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle1);
            tfTitle.DrawString("  " + "Description", fontTitle, XBrushes.White, rectTitle1, XStringFormats.TopLeft);

            startingHeight = startingHeight + ItemHeight + 1;
            for (int i = 0; i < pdfData.Aspiration.Count; i++)
            {
                var font = new XFont("OpenSans", 10, XFontStyle.Regular);
                XTextFormatter tf = new XTextFormatter(gfx);

                XRect rect = new XRect(leftMargin, startingHeight, 500, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect);
                var data = $"{"  " + pdfData.Aspiration[i].Description}";
                tf.DrawString(data, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                startingHeight = startingHeight + ItemHeight + 1;
            }
        }
        void AddAllocation(XGraphics gfx, PdfData pdfData)
        {
            //int startingHeight = 135;
            int ItemHeight = 20;

            var fontTitle = new XFont("OpenSans", 10, XFontStyle.Bold);
            XTextFormatter tfTitle = new XTextFormatter(gfx);
            XRect rectTitle = new XRect(leftMargin - 10, startingHeight, 100, ItemHeight);
            gfx.DrawRectangle(XBrushes.White, rectTitle);
            tfTitle.DrawString("Allocation", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
            startingHeight = startingHeight + ItemHeight;

            int xMargin = 0;
            //Draw table Header
            //for (int i = 0; i < 2; i++)
            //{
            //    XRect rectTitle1 = new XRect(xMargin + 60, startingHeight, 250, ItemHeight);
            //    gfx.DrawRectangle(XBrushes.SlateGray, rectTitle1);
            //    tfTitle.DrawString("  " + "Header" + i.ToString(), fontTitle, XBrushes.White, rectTitle1, XStringFormats.TopLeft);
            //    //startingHeight = startingHeight + ItemHeight;
            //    xMargin = 251;
            //}

            XRect rectTitle1 = new XRect(xMargin + leftMargin, startingHeight, 250, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle1);
            tfTitle.DrawString("  " + "Allocation", fontTitle, XBrushes.White, rectTitle1, XStringFormats.TopLeft);
            xMargin = 251;

            XRect rectTitle2 = new XRect(xMargin + leftMargin, startingHeight, 250, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle2);
            tfTitle.DrawString("  " + "Comment", fontTitle, XBrushes.White, rectTitle2, XStringFormats.TopLeft);

            startingHeight = startingHeight + ItemHeight + 1;
            for (int i = 0; i < pdfData.Allocation.Count; i++)
            {
                var font = new XFont("OpenSans", 10, XFontStyle.Regular);
                XTextFormatter tf = new XTextFormatter(gfx);

                XRect rect = new XRect(leftMargin, startingHeight, 250, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect);
                //var data = $"{i} {pdfData.Allocation[i].Allocation} | {pdfData.Allocation[i].Comment}";
                var data = $"{"  " + pdfData.Allocation[i].Allocation}";
                tf.DrawString(data, font, XBrushes.Black, rect, XStringFormats.TopLeft);


                XRect rect2 = new XRect(251 + leftMargin, startingHeight, 250, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect2);
                //var data = $"{i} {pdfData.Allocation[i].Allocation} | {pdfData.Allocation[i].Comment}";
                var data2 = $"{" " + pdfData.Allocation[i].Comment}";
                tf.DrawString(data2, font, XBrushes.Black, rect2, XStringFormats.TopLeft);

                startingHeight = startingHeight + ItemHeight + 1;
            }
        }
        void AddInternal(XGraphics gfx, PdfData pdfData)
        {
            int ItemHeight = 20;

            var fontTitle = new XFont("OpenSans", 10, XFontStyle.Bold);
            XTextFormatter tfTitle = new XTextFormatter(gfx);
            XRect rectTitle = new XRect(leftMargin - 10, startingHeight, 100, ItemHeight);
            gfx.DrawRectangle(XBrushes.White, rectTitle);
            tfTitle.DrawString("Internal", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
            startingHeight = startingHeight + ItemHeight;

            int xMargin = 0;
            //Draw table Header
            XRect rectTitle1 = new XRect(xMargin + leftMargin, startingHeight, 166, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle1);
            tfTitle.DrawString("  " + "Topic", fontTitle, XBrushes.White, rectTitle1, XStringFormats.TopLeft);
            xMargin = 167;

            XRect rectTitle2 = new XRect(xMargin + leftMargin, startingHeight, 166, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle2);
            tfTitle.DrawString("  " + "Training Mode", fontTitle, XBrushes.White, rectTitle2, XStringFormats.TopLeft);
            xMargin = 334;

            XRect rectTitle3 = new XRect(xMargin + leftMargin, startingHeight, 166, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle3);
            tfTitle.DrawString("  " + "Description", fontTitle, XBrushes.White, rectTitle3, XStringFormats.TopLeft);

            startingHeight = startingHeight + ItemHeight + 1;

            //Draw table
            for (int i = 0; i < pdfData.IInternal.Count; i++)
            {
                var font = new XFont("OpenSans", 10, XFontStyle.Regular);
                XTextFormatter tf = new XTextFormatter(gfx);

                XRect rect = new XRect(leftMargin, startingHeight, 166, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect);
                var data = $"{"  " + pdfData.IInternal[i].Topic}";
                tf.DrawString(data, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                XRect rect2 = new XRect(167 + leftMargin, startingHeight, 166, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect2);
                var data2 = $"{"  " + pdfData.IInternal[i].TrainingMode}";
                tf.DrawString(data2, font, XBrushes.Black, rect2, XStringFormats.TopLeft);

                XRect rect3 = new XRect(334 + leftMargin, startingHeight, 166, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect3);
                var data3 = $"{"  " + pdfData.IInternal[i].Description}";
                tf.DrawString(data3, font, XBrushes.Black, rect3, XStringFormats.TopLeft);

                startingHeight = startingHeight + ItemHeight + 1;
            }
            startingHeight = startingHeight + 5;
        }
        //void AddInternal(XGraphics gfx, PdfData pdfData)
        //{
        //    //int startingHeight = 135;
        //    int ItemHeight = 20;

        //    var fontTitle = new XFont("OpenSans", 11, XFontStyle.Bold);
        //    XTextFormatter tfTitle = new XTextFormatter(gfx);
        //    XRect rectTitle = new XRect(60, startingHeight, 100, ItemHeight);
        //    gfx.DrawRectangle(XBrushes.White, rectTitle);
        //    tfTitle.DrawString("Internal", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
        //    startingHeight = startingHeight + ItemHeight;

        //    for (int i = 0; i < pdfData.IInternal.Count; i++)
        //    {
        //        var font = new XFont("OpenSans", 11, XFontStyle.Regular);
        //        XTextFormatter tf = new XTextFormatter(gfx);
        //        XRect rect = new XRect(60, startingHeight, 500, ItemHeight);
        //        gfx.DrawRectangle(XBrushes.SlateGray, rect);
        //        var data = $"{pdfData.IInternal[i].Topic} | {pdfData.IInternal[i].TrainingMode} | {pdfData.IInternal[i].Description}";
        //        tf.DrawString(data, font, XBrushes.White, rect, XStringFormats.TopLeft);

        //        startingHeight = startingHeight + ItemHeight;
        //    }
        //}
        void AddMentor(XGraphics gfx, PdfData pdfData)
        {
            //int startingHeight = 135;
            int ItemHeight = 20;

            var fontTitle = new XFont("OpenSans", 10, XFontStyle.Bold);
            XTextFormatter tfTitle = new XTextFormatter(gfx);
            XRect rectTitle = new XRect(leftMargin - 10, startingHeight, 100, ItemHeight);
            gfx.DrawRectangle(XBrushes.White, rectTitle);
            tfTitle.DrawString("Mentors", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
            startingHeight = startingHeight + ItemHeight;

            int xMargin = 0;
            //Draw table Header
            XRect rectTitle1 = new XRect(xMargin + leftMargin, startingHeight, 166, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle1);
            tfTitle.DrawString("  " + "Mentor", fontTitle, XBrushes.White, rectTitle1, XStringFormats.TopLeft);
            xMargin = 167;

            XRect rectTitle2 = new XRect(xMargin + leftMargin, startingHeight, 166, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle2);
            tfTitle.DrawString("  " + "Training Category", fontTitle, XBrushes.White, rectTitle2, XStringFormats.TopLeft);
            xMargin = 334;

            XRect rectTitle3 = new XRect(xMargin + leftMargin, startingHeight, 166, ItemHeight);
            gfx.DrawRectangle(XBrushes.LightSeaGreen, rectTitle3);
            tfTitle.DrawString("  " + "Comment", fontTitle, XBrushes.White, rectTitle3, XStringFormats.TopLeft);

            startingHeight = startingHeight + ItemHeight + 1;
            for (int i = 0; i < pdfData.Mentor.Count; i++)
            {
                var font = new XFont("OpenSans", 10, XFontStyle.Regular);
                XTextFormatter tf = new XTextFormatter(gfx);

                XRect rect = new XRect(leftMargin, startingHeight, 166, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect);
                var data = $"{"  " + pdfData.Mentor[i].Mentor}";
                tf.DrawString(data, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                XRect rect2 = new XRect(167 + leftMargin, startingHeight, 166, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect2);
                var data2 = $"{"  " + pdfData.Mentor[i].TrainingCategory}";
                tf.DrawString(data2, font, XBrushes.Black, rect2, XStringFormats.TopLeft);

                XRect rect3 = new XRect(334 + leftMargin, startingHeight, 166, ItemHeight);
                gfx.DrawRectangle(XBrushes.AliceBlue, rect3);
                var data3 = $"{"  " + pdfData.Mentor[i].Comment}";
                tf.DrawString(data3, font, XBrushes.Black, rect3, XStringFormats.TopLeft);

                startingHeight = startingHeight + ItemHeight + 1;
            }
            startingHeight = startingHeight + 5;
        }
        //void AddMentor(XGraphics gfx, PdfData pdfData)
        //{
        //    //int startingHeight = 135;
        //    int ItemHeight = 20;

        //    var fontTitle = new XFont("OpenSans", 11, XFontStyle.Bold);
        //    XTextFormatter tfTitle = new XTextFormatter(gfx);
        //    XRect rectTitle = new XRect(60, startingHeight, 100, ItemHeight);
        //    gfx.DrawRectangle(XBrushes.White, rectTitle);
        //    tfTitle.DrawString("Mentors", fontTitle, XBrushes.Black, rectTitle, XStringFormats.TopLeft);
        //    startingHeight = startingHeight + ItemHeight;

        //    for (int i = 0; i < pdfData.Mentor.Count; i++)
        //    {
        //        var font = new XFont("OpenSans", 11, XFontStyle.Regular);
        //        XTextFormatter tf = new XTextFormatter(gfx);
        //        XRect rect = new XRect(60, startingHeight, 500, ItemHeight);
        //        gfx.DrawRectangle(XBrushes.SlateGray, rect);
        //        var data = $"{pdfData.Mentor[i].Mentor} | {pdfData.Mentor[i].TrainingCategory} | {pdfData.Mentor[i].Comment}";
        //        tf.DrawString(data, font, XBrushes.White, rect, XStringFormats.TopLeft);

        //        startingHeight = startingHeight + ItemHeight + 1;
        //    }
        //    startingHeight = startingHeight + 5;
        //}
        void Drawline(XGraphics gfx, PdfData pdfData)
        {
            XPen pen = new XPen(XColor.Empty);
            gfx.DrawLine(pen, 45, 250, 45, 703);

        }

    }
}
